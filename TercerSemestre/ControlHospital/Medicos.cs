using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ControlHospital
{
    public partial class Medicos : Form
    {
        public Medicos()
        {
            InitializeComponent();
        }
        private List<Medico> medictos = new List<Medico>();
        private List<Especialidad> especialidades = new List<Especialidad>();
        private List<Departamento> departamentos = new List<Departamento>();
        private List<Municipio> municipios = new List<Municipio>();
        private List<Municipio> currentMunic = new List<Municipio>();

        private DataTable dt = new DataTable();

        private void Medicos_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnCancel.Enabled = false;
            LoadSpecial();
            LoadLocatios();
            LoadDepartments();
            LoadDoctor();

            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Especialidad");
            dt.Columns.Add("Municipio");
            dt.Columns.Add("Departamento");

            fillTable();
            dataGrid.DataSource = dt;

        }

        private void fillTable()
        {
            dt.Clear();
            foreach (Medico item in medictos)
            {
                string[] list = item.toList();
                string[] data = new string[7];

                int idEspecial = int.Parse(list[5]);
                int idMuni = int.Parse(list[6]);
                int indexMun = municipios.FindIndex(element => element.id == idMuni);
                int idexExpecial = especialidades.FindIndex(element => element.id == idEspecial);

                //Tomar primeros N elementos
                //https://stackoverflow.com/questions/319973/how-to-get-first-n-elements-of-a-list-in-c
                string[] temData = list.Take(list.Length - 2).ToArray().ToArray();
                if (indexMun > -1)
                {
                    Especialidad especial = especialidades.ElementAt(idexExpecial);
                    Municipio municipio = municipios.ElementAt(indexMun);
                    Departamento departamento = departamentos.Find((element) => element.id == municipio.idDepartamento);


                    //Concatenar dos arrays
                    //https://stackoverflow.com/questions/1547252/how-do-i-concatenate-two-arrays-in-c
                    data = temData.Concat(new string[] { especial.Name, municipio.Name, departamento.Name }).ToArray();
                }
                else
                {
                    data = temData.Concat(new string[] { "-", "-", "-" }).ToArray();
                }
                dt.Rows.Add(data);
            }
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

        private void LoadSpecial()
        {
            try
            {
                StreamReader reader = new StreamReader(Constants.store_escpecial);
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');
                    Especialidad especialidad = new Especialidad()
                    {
                        id = int.Parse(line[0]),
                        Name = line[1],
                    };
                    especialidades.Add(especialidad);
                }
                reader.Close();
            }
            catch
            {
                StreamWriter writer = new StreamWriter(Constants.store_escpecial);
                writer.WriteLine("");
                writer.Close();
            }
            foreach (var item in especialidades)
            {
                comboEspecial.Items.Add(item.Name);
            }
            comboEspecial.SelectedItem = -1;
        }

        private void LoadDoctor()
        {
            try
            {
                StreamReader reader = new StreamReader(Constants.store_doctors);
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');
                    Medico medico = new Medico()
                    {
                        id = int.Parse(line[0]),
                        Nombres = line[1],
                        Apellidos = line[2],
                        Direccion = line[3],
                        Telefono = line[4],
                        idEspecialidad = int.Parse(line[5]),
                        idMunicipio = int.Parse(line[6]),
                    };
                    medictos.Add(medico);
                }
                reader.Close();
            }
            catch
            {
                StreamWriter writer = new StreamWriter(Constants.store_doctors);
                writer.WriteLine("");
                writer.Close();
            }
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
            int indexEspecial = comboEspecial.SelectedIndex;

            bool test = boxName.Text != "" && boxLastName.Text != ""
                        && boxPhone.Text != "" && boxAddress.Text != ""
                        && (indexDeparment > -1 && indexDeparment < departamentos.Count)
                        && (indexMunicipio > -1 && indexMunicipio < currentMunic.Count)
                        && (indexEspecial > -1 && indexEspecial < especialidades.Count);

            return test;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (testInputs())
            {
                bool exists = false;
                foreach (Medico element in medictos)
                {
                    if (element.Nombres.Equals(boxName.Text) && element.Apellidos.Equals(boxLastName.Text))
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    int maxId = medictos.Count > 0 ? medictos.Max(element => element.id) + 1 : 1;

                    int indexMunicipio = comboMunic.SelectedIndex;
                    int indexEspecial = comboEspecial.SelectedIndex;

                    Municipio muni = currentMunic.ElementAt(indexMunicipio);
                    Especialidad especialidad = especialidades.ElementAt(indexEspecial);

                    Medico medico = new Medico()
                    {
                        id = maxId,
                        Nombres = boxName.Text,
                        Apellidos = boxLastName.Text,
                        Direccion = boxAddress.Text,
                        Telefono = boxPhone.Text,
                        idEspecialidad = especialidad.id,
                        idMunicipio = muni.id,
                    };
                    medictos.Add(medico);
                    storeAddItem(medico);
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

        private void storeAddItem(Medico data)
        {
            StreamWriter writer = new StreamWriter(Constants.store_doctors, true);
            writer.WriteLine(data.toLineCSV());
            writer.Close();
        }

        private void updateStore()
        {
            StreamWriter writer = new StreamWriter(Constants.store_doctors);
            foreach (var element in medictos)
            {
                writer.WriteLine(element.toLineCSV());
            }
            writer.Close();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (testInputs() && boxCode.Text != "")
            {
                int id = Convert.ToInt32(boxCode.Text);
                int index = medictos.FindIndex(v => v.id == id);
                if (index > -1)
                {

                    int indexMunicipio = comboMunic.SelectedIndex;
                    int indexEspecial = comboEspecial.SelectedIndex;

                    Municipio muni = currentMunic.ElementAt(indexMunicipio);
                    Especialidad especialidad = especialidades.ElementAt(indexEspecial);

                    medictos[index] = new Medico
                    {
                        id = id,
                        Nombres = boxName.Text,
                        Apellidos = boxLastName.Text,
                        Direccion = boxAddress.Text,
                        Telefono = boxPhone.Text,
                        idEspecialidad = especialidad.id,
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleanLabels();
            cleanLabels();
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
            boxAddress.Text = "";
            comboMunic.SelectedIndex = -1;
            comboMunic.Items.Clear();
            comboEspecial.SelectedIndex = -1;
            currentMunic.Clear();

            comboDepartment.SelectedIndexChanged -= comboDepartment_SelectedIndexChanged;
            comboDepartment.SelectedIndex = -1;
            comboDepartment.SelectedIndexChanged += comboDepartment_SelectedIndexChanged;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (boxCode.Text != "")
            {
                DialogResult resultQuestion = MessageBox.Show("Advertencia", "Esta a punto de eliminar el elemeto seleccionado.\nDesea continuar?", MessageBoxButtons.YesNo);
                int id = Convert.ToInt32(boxCode.Text);
                int index = medictos.FindIndex(v => v.id == id);
                if (index > -1 && resultQuestion == DialogResult.Yes)
                {
                    medictos.RemoveAt(index);
                    updateStore();
                    cleanLabels();
                    fillTable();
                    MessageBox.Show("Elemento eliminado con exito!");
                }
            }
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < medictos.Count)
            {
                var element = medictos[e.RowIndex];
                boxCode.Text = element.id.ToString();
                boxName.Text = element.Nombres;
                boxLastName.Text = element.Apellidos;
                boxPhone.Text = element.Telefono;
                boxAddress.Text = element.Direccion;

                Municipio muni = municipios.FirstOrDefault(v => v.id == element.idMunicipio);

                Departamento deparment = departamentos.FirstOrDefault(v => v.id == muni.idDepartamento);
                int indexDep = departamentos.FindIndex((v) => v.id == deparment.id);
                int indexEspecial = especialidades.FindIndex((v) => v.id == element.idEspecialidad);

                comboDepartment.SelectedIndex = indexDep;
                comboEspecial.SelectedIndex = indexEspecial;

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
