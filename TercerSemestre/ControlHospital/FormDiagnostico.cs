using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ControlHospital
{
    public partial class FormDiagnostico : Form
    {
        public FormDiagnostico()
        {
            InitializeComponent();
        }
        private DataTable dt = new DataTable();
        private List<Ingreso> ingresos = new List<Ingreso>();
        private List<DetalleEnfermedades> detalles = new List<DetalleEnfermedades>();
        private List<Medico> medicos = new List<Medico>();
        private List<Cama> camas = new List<Cama>();
        private List<Paciente> pacientes = new List<Paciente>();
        private List<Enfemedad> enferdades = new List<Enfemedad>();



        private void FormDiagnostico_Load(object sender, EventArgs e)
        {
            LoadMedico();
            LoadCamas();
            LoadPacientes();
            LoadIngresos();
            LoadDetalles();
            LoadEnfermedades();


            dt.Columns.Add("Codigo Ingreso");
            dt.Columns.Add("Fecha Ingreso");
            dt.Columns.Add("Cama");
            dt.Columns.Add("Paciente");
            dt.Columns.Add("Enfermedad");
            dt.Columns.Add("Diagnostico");
            dt.Columns.Add("Tratamiento");
            dt.Columns.Add("Codigo diagnostico");

            FillTable();
            dataGrid.DataSource = dt;

            comboEnfermedad.DataSource = enferdades;
            comboEnfermedad.DisplayMember = "Name";
            comboEnfermedad.ValueMember = "id";
            comboEnfermedad.SelectedIndex = -1;
        }

        private void FillTable()
        {
            dt.Rows.Clear();
            foreach (var element in ingresos)
            {
                Cama cama = camas.FirstOrDefault((v) => v.id == element.idCama);
                Paciente paciente = pacientes.FirstOrDefault(v => v.id == element.idPaciente);
                Medico medico = medicos.FirstOrDefault(v => v.id == element.idMedico);
                DetalleEnfermedades detalle = detalles.FirstOrDefault(v => v.idIngreso == element.id);
                Enfemedad enfemedad = enferdades.FirstOrDefault(v => v.id == detalle.idEnfermedad);

                string[] row = new string[] { element.id.ToString(), element.FechaIngreso, cama.Name, paciente.Nombres + paciente.Apellidos, enfemedad.Name, detalle.Diagnostico, detalle.tratamiento, detalle.id.ToString() };

                dt.Rows.Add(row);
            }
        }
        private void LoadIngresos()
        {
            try
            {
                StreamReader reader = new StreamReader(Constants.store_income);
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');
                    Ingreso element = new Ingreso()
                    {
                        id = Convert.ToInt32(line[0]),
                        FechaIngreso = line[1],
                        FechaEgreso = line[2],
                        idCama = Convert.ToInt32(line[3]),
                        idPaciente = Convert.ToInt32(line[4]),
                        idMedico = Convert.ToInt32(line[5]),
                    };
                    ingresos.Add(element);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
        }
        private void LoadDetalles()
        {
            try
            {
                StreamReader reader = new StreamReader(Constants.store_detail_disease);
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');
                    DetalleEnfermedades element = new DetalleEnfermedades()
                    {
                        id = Convert.ToInt32(line[0]),
                        Diagnostico = line[1],
                        tratamiento = line[2],
                        idEnfermedad = Convert.ToInt32(line[3]),
                        idIngreso = Convert.ToInt32(line[4]),
                    };
                    detalles.Add(element);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
        }
        private void LoadMedico()
        {
            try
            {
                StreamReader reader = new StreamReader(Constants.store_doctors);
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');
                    Medico element = new Medico()
                    {
                        id = Convert.ToInt32(line[0]),
                        Nombres = line[1],
                        Apellidos = line[2],
                        Direccion = line[3],
                        Telefono = line[4],
                        idEspecialidad = Convert.ToInt32(line[5]),
                        idMunicipio = Convert.ToInt32(line[6]),
                    };
                    medicos.Add(element);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
        }
        private void LoadCamas()
        {
            try
            {
                StreamReader reader = new StreamReader(Constants.store_beds);
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');
                    Cama element = new Cama()
                    {
                        id = Convert.ToInt32(line[0]),
                        Name = line[1],
                        Description = line[2],
                        state = Convert.ToBoolean(line[3]),
                        idHabitacion = Convert.ToInt32(line[4]),
                    };
                    camas.Add(element);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
        }
        private void LoadPacientes()
        {
            try
            {
                StreamReader reader = new StreamReader(Constants.store_patient);
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');
                    Paciente element = new Paciente()
                    {
                        id = Convert.ToInt32(line[0]),
                        Nombres = line[1],
                        Apellidos = line[2],
                        FechaNacimiento = line[3],
                        Direccion = line[4],
                        Telefono = line[5],

                    };
                    pacientes.Add(element);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void LoadEnfermedades()
        {
            try
            {
                StreamReader reader = new StreamReader(Constants.store_disease);
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');
                    Enfemedad enfemedad = new Enfemedad()
                    {
                        id = int.Parse(line[0]),
                        Name = line[1],
                        Description = line[2],

                    };
                    enferdades.Add(enfemedad);
                }
                reader.Close();

            }
            catch (Exception ex)
            {

            }
        }
        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= ingresos.Count)
            {
                Ingreso ingreso = ingresos.ElementAt(e.RowIndex);
                Paciente paciente = pacientes.FirstOrDefault(v => v.id == ingreso.idPaciente);
                Medico medico = medicos.FirstOrDefault(v => v.id == ingreso.idMedico);
                DetalleEnfermedades detalle = detalles.FirstOrDefault(v => v.idIngreso == ingreso.id);

                boxCodigo.Text = ingreso.id.ToString();
                boxPaciente.Text = paciente.Nombres + paciente.Apellidos;
                boxMedico.Text = medico.Nombres + medico.Apellidos;
                boxDiagnostico.Text = detalle.Diagnostico;
                boxTratamiento.Text = detalle.tratamiento;
            }
        }
        private bool validateInputs()
        {
            bool isValid = comboEnfermedad.SelectedIndex > -1 && boxDiagnostico.Text != "" && boxTratamiento.Text != "";
            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (boxCodigo.Text != "" && validateInputs())
            {
                int idIngreso = int.Parse(boxCodigo.Text);
                int selectedItem = detalles.FindIndex(v => v.idIngreso == idIngreso);
                Enfemedad enfermedad = enferdades.ElementAt(comboEnfermedad.SelectedIndex);

                if (selectedItem > -1)
                {
                    int idDetalle = detalles[selectedItem].id;
                    detalles[selectedItem] = new DetalleEnfermedades()
                    {
                        id = idDetalle,
                        Diagnostico = boxDiagnostico.Text,
                        tratamiento = boxTratamiento.Text,
                        idEnfermedad = enfermedad.id,
                        idIngreso = idIngreso
                    };
                } else
                {
                    int id = detalles.Count > 0 ? detalles.Max(v  => v.id) + 1 : 1;
                    DetalleEnfermedades detalle = new DetalleEnfermedades()
                    {
                        id = id,
                        Diagnostico = boxDiagnostico.Text,
                        tratamiento = boxTratamiento.Text,
                        idEnfermedad = enfermedad.id,
                        idIngreso = idIngreso
                    };

                    detalles.Add(detalle);  
                }
                updateFiles();
                FillTable();
            }
        }

        private void updateFiles()
        {
            StreamWriter writer = new StreamWriter(Constants.store_detail_disease);
            foreach(var element in detalles)
            {
                writer.WriteLine(element.toLineCSV());
            }
            writer.Close();
        }
    }
}
