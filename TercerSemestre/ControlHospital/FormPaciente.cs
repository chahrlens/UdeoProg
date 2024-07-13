using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ControlHospital
{
    public partial class FormPaciente : Form
    {
        public FormPaciente()
        {
            InitializeComponent();
        }

        private List<Paciente> pacientes = new List<Paciente>();
        private List<Departamento> departamentos = new List<Departamento>();
        private List<Municipio> municipios = new List<Municipio>();
        private List<Municipio> currentMunic = new List<Municipio>();

        private DataTable dt = new DataTable();
        private void FormPaciente_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnCancel.Enabled = false;
            LoadLocatios();
            LoadDepartments();


            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("Fecha nacimiento");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Municipio");
            dt.Columns.Add("Departamento");

            LoadPatients();
            fillTable();
            dataGrid.DataSource = dt;
        }
        private void LoadDepartments()
        {

            comboDepartment.SelectedIndexChanged -= comboDepartment_SelectedIndexChanged;

            foreach (var departamento in departamentos)
            {
                comboDepartment.Items.Add(departamento.Name);
            }
            comboDepartment.SelectedIndex = -1;
            comboDepartment.SelectedIndexChanged += comboDepartment_SelectedIndexChanged;

        }
        private void LoadLocatios()
        {
            try
            {
                StreamReader reader = new StreamReader(Constants.store_departmens);
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');
                    Departamento departamento = new Departamento()
                    {
                        id = Convert.ToInt32(line[0]),
                        Name = line[1],
                    };
                    departamentos.Add(departamento);
                }
                reader.Close();
            }
            catch
            {
                //
            }
            try
            {
                StreamReader reader = new StreamReader(Constants.store_munic);
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');
                    Municipio municipio = new Municipio()
                    {
                        id = Convert.ToInt32(line[1]),
                        Name = line[2],
                        idDepartamento = Convert.ToInt32(line[0]),
                    };
                    municipios.Add(municipio);
                }
                reader.Close();

            }
            catch { }
        }

        private void LoadPatients()
        {
            //https://stackoverflow.com/questions/10383053/create-file-if-file-does-not-exist
            if (!File.Exists(Constants.store_patient))
            {
                using (StreamWriter writer = new StreamWriter(Constants.store_patient))
                {
                    writer.Write("");
                }

            }
            else
            {
                try
                {
                    StreamReader reader = new StreamReader(Constants.store_patient);
                    while (!reader.EndOfStream)
                    {
                        string[] line = reader.ReadLine().Split(',');
                        Paciente paciente = new Paciente()
                        {
                            id = int.Parse(line[0]),
                            Nombres = line[1],
                            Apellidos = line[2],
                            FechaNacimiento = line[3],
                            Direccion = line[4],
                            Telefono = line[5],
                            idMunicipio = int.Parse(line[6]),
                        };
                        pacientes.Add(paciente);
                    }
                    reader.Close();
                }
                catch
                {
                }
            }
        }

        private void fillTable()
        {
            dt.Clear();
            foreach (Paciente item in pacientes)
            {
                string[] list = item.toList();
                string[] data = new string[7];

                int idMuni = int.Parse(list[6]);
                int indexMun = municipios.FindIndex(element => element.id == idMuni);

                string[] temData = list.Take(list.Length - 1).ToArray().ToArray();
                if (indexMun > -1)
                {
                    Municipio municipio = municipios.ElementAt(indexMun);
                    Departamento departamento = departamentos.Find((element) => element.id == municipio.idDepartamento);

                    data = temData.Concat(new string[] { municipio.Name, departamento.Name }).ToArray();
                }
                else
                {
                    data = temData.Concat(new string[] { "-", "-" }).ToArray();
                }
                dt.Rows.Add(data);
            }
        }
        private void comboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboDepartment.SelectedIndex;
            if (index > -1)
            {
                Departamento dp = departamentos[index];
                comboMunic.Items.Clear();
                currentMunic.Clear();
                currentMunic = municipios.FindAll(element => element.idDepartamento == dp.id);
                foreach (Municipio municipio in currentMunic)
                {
                    comboMunic.Items.Add(municipio.Name);
                }
                comboMunic.SelectedIndex = -1;

            }
        }

        private bool testInputs()
        {
            int indexDeparment = comboDepartment.SelectedIndex;
            int indexMunicipio = comboMunic.SelectedIndex;
            DateTime selecteDate = Convert.ToDateTime(datePicker.Text);
            DateTime now = DateTime.Now;


            bool test = boxName.Text != "" && boxLastName.Text != ""
                        && boxPhone.Text != "" && boxAddress.Text != ""
                        && (indexDeparment > -1 && indexDeparment < departamentos.Count)
                        && (indexMunicipio > -1 && indexMunicipio < currentMunic.Count)
                        && (selecteDate <= now);

            return test;
        }

        private void storeAddItem(Paciente data)
        {
            StreamWriter writer = new StreamWriter(Constants.store_patient, true);
            writer.WriteLine(data.toLineCSV());
            writer.Close();
        }
        
        private void updateStore()
        {
            StreamWriter writer = new StreamWriter(Constants.store_patient);
            foreach (var element in pacientes)
            {
                writer.WriteLine(element.toLineCSV());
            }
            writer.Close();

        }
        private void cleanLabels()
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = true;
            boxCode.Text = "";
            boxName.Text = "";
            boxLastName.Text = "";
            boxAddress.Text = "";
            boxPhone.Text = "";
            datePicker.Text = DateTime.Now.ToString();
            boxAddress.Text = "";
            comboMunic.SelectedIndex = -1;
            comboMunic.Items.Clear();
            currentMunic.Clear();

            comboDepartment.SelectedIndexChanged -= comboDepartment_SelectedIndexChanged;
            comboDepartment.SelectedIndex = -1;
            comboDepartment.SelectedIndexChanged += comboDepartment_SelectedIndexChanged;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (testInputs())
            {
                bool exists = false;
                foreach (Paciente element in pacientes)
                {
                    if (element.Nombres.Equals(boxName.Text) && element.Apellidos.Equals(boxLastName.Text))
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    int maxId = pacientes.Count > 0 ? pacientes.Max(element => element.id) + 1 : 1;

                    int indexMunicipio = comboMunic.SelectedIndex;

                    Municipio muni = currentMunic.ElementAt(indexMunicipio);

                    Paciente paciente = new Paciente()
                    {
                        id = maxId,
                        Nombres = boxName.Text,
                        Apellidos = boxLastName.Text,
                        FechaNacimiento = datePicker.Text,
                        Direccion = boxAddress.Text,
                        Telefono = boxPhone.Text,
                        idMunicipio = muni.id,
                    };
                    pacientes.Add(paciente);
                    storeAddItem(paciente);
                    cleanLabels();
                    fillTable();
                    MessageBox.Show("Elemento creado con exito!");
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (testInputs() && boxCode.Text != "")
            {
                int id = Convert.ToInt32(boxCode.Text);
                int index = pacientes.FindIndex(v => v.id == id);
                if (index > -1)
                {

                    int indexMunicipio = comboMunic.SelectedIndex;

                    Municipio muni = currentMunic.ElementAt(indexMunicipio);

                    pacientes[index] = new Paciente
                    {
                        id = id,
                        Nombres = boxName.Text,
                        Apellidos = boxLastName.Text,
                        FechaNacimiento = datePicker.Text,
                        Direccion = boxAddress.Text,
                        Telefono = boxPhone.Text,
                        idMunicipio = muni.id,
                    };
                }
                updateStore();
                fillTable();
                cleanLabels();
                MessageBox.Show("Elemento actualizado con exito!");
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (boxCode.Text != "")
            {
                DialogResult resultQuestion = MessageBox.Show("Advertencia", "Esta a punto de eliminar el elemeto seleccionado.\nDesea continuar?", MessageBoxButtons.YesNo);
                int id = Convert.ToInt32(boxCode.Text);
                int index = pacientes.FindIndex(v => v.id == id);
                if (index > -1 && resultQuestion == DialogResult.Yes)
                {
                    pacientes.RemoveAt(index);
                    updateStore();
                    cleanLabels();
                    fillTable();
                    MessageBox.Show("Elemento eliminado con exito!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleanLabels();
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < pacientes.Count)
            {
                var element = pacientes[e.RowIndex];
                boxCode.Text = element.id.ToString();
                boxName.Text = element.Nombres;
                boxLastName.Text = element.Apellidos;
                datePicker.Text = element.FechaNacimiento;
                boxPhone.Text = element.Telefono;
                boxAddress.Text = element.Direccion;

                Municipio muni = municipios.FirstOrDefault(v => v.id == element.idMunicipio);

                Departamento deparment = departamentos.FirstOrDefault(v => v.id == muni.idDepartamento);
                int indexDep = departamentos.FindIndex((v) => v.id == deparment.id);

                comboDepartment.SelectedIndex = indexDep;

                int indexMun = currentMunic.FindIndex((v) => v.id == muni.id);

                comboMunic.SelectedIndex = indexMun;

                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnCancel.Enabled = true;
                btnSave.Enabled = false;
            }
        }
    }
}
