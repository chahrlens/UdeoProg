using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ControlHospital
{
    public partial class FormIngresos : Form
    {
        public FormIngresos()
        {
            InitializeComponent();
        }
        private List<Medico> medicos = new List<Medico>();
        private List<Paciente> pacientes = new List<Paciente>();
        private List<Habitacion> habitaciones = new List<Habitacion>();
        private List<Ingreso> ingresos = new List<Ingreso>();
        private List<Cama> camas = new List<Cama>();
        private List<Cama> actualCamas = new List<Cama>();
        private DataTable dt = new DataTable();

        private void FormIngresos_Load(object sender, EventArgs e)
        {
            LoadMedicos();
            LoadHabitaciones();
            LoadCamas();
            LoadPacientes();
            LoadIngreso();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Fecha Ingreso");
            dt.Columns.Add("Fecha Egreso");
            dt.Columns.Add("Cama");
            dt.Columns.Add("Paciente");
            dt.Columns.Add("Medico");

            FillTable();
            FillCombos();
            dataGrid.DataSource = dt;

        }
        private void FillTable()
        {
            dt.Rows.Clear();
            foreach (Ingreso element in ingresos)
            {
                string[] data = element.toList();
                string[] tempData = data.Take(data.Length - 3).ToArray();
                int idCama = Convert.ToInt32(data[3]);
                int idPaciente = Convert.ToInt32(data[4]);
                int idDoctor = Convert.ToInt32(data[5]);

                Cama cama = camas.FirstOrDefault(v => v.id == idCama);
                Paciente paciente = pacientes.FirstOrDefault(v => v.id == idPaciente);
                Medico medico = medicos.FirstOrDefault(v => v.id == idDoctor);

                string[] newData = tempData.Concat(new string[] { cama.Name, paciente.Nombres, medico.Nombres }).ToArray();
                dt.Rows.Add(newData);
            }
        }
        private void FillCombos()
        {
            //¿Como asignar un valor a cada opcion de combobox?
            //https://www.codeproject.com/Questions/1210807/Como-asignar-un-valor-a-cada-opcion-de-combobox-en
            comboPaciente.DataSource = pacientes;
            comboPaciente.DisplayMember = "FullName";
            comboPaciente.ValueMember = "id";
            comboPaciente.SelectedIndex = -1;

            comboHabitacion.SelectedValueChanged -= comboHabitacion_SelectedValueChanged;

            comboHabitacion.DataSource = habitaciones;
            comboHabitacion.DisplayMember = "Name";
            comboHabitacion.ValueMember = "id";
            comboHabitacion.SelectedIndex = -1;

            comboHabitacion.SelectedValueChanged += comboHabitacion_SelectedValueChanged;

            comboDoctor.DataSource = medicos;
            comboDoctor.DisplayMember = "FullName";
            comboDoctor.ValueMember = "id";
            comboDoctor.SelectedIndex = -1;
        }
        private void LoadMedicos()
        {
            try
            {
                StreamReader reader = new StreamReader(Constants.store_doctors);
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');
                    Medico medico = new Medico()
                    {
                        id = Convert.ToInt32(line[0]),
                        Nombres = line[1],
                        Apellidos = line[2],
                        Direccion = line[3],
                        Telefono = line[4],
                        idEspecialidad = Convert.ToInt32(line[5]),
                        idMunicipio = Convert.ToInt32(line[6]),
                    };
                    medicos.Add(medico);
                }
                reader.Close();

            }
            catch { }
        }
        private void LoadHabitaciones()
        {
            try
            {
                StreamReader reader = new StreamReader(Constants.store_room);
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');
                    Habitacion habitacion = new Habitacion()
                    {
                        id = Convert.ToInt32(line[0]),
                        Name = line[1],
                    };
                    habitaciones.Add(habitacion);
                }
                reader.Close();

            }
            catch { }
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
                        state = bool.Parse(line[3]),
                        idHabitacion = Convert.ToInt32(line[4]),
                    };
                    camas.Add(element);
                }
                reader.Close();

            }
            catch { }
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
                        idMunicipio = Convert.ToInt32(line[6]),
                    };
                    pacientes.Add(element);
                }
                reader.Close();

            }
            catch { }
        }

        private void LoadIngreso()
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
            catch { }
        }

        private void comboHabitacion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboHabitacion.SelectedValue != null)
            {
                int valueSelected = Convert.ToInt32(comboHabitacion.SelectedValue);
                actualCamas.Clear();
                actualCamas = camas.Where(v => v.idHabitacion == valueSelected).ToList();
                comboCama.DataSource = actualCamas;
                comboCama.ValueMember = "id";
                comboCama.DisplayMember = "Name";
                comboCama.SelectedIndex = -1;
            }
        }

        bool validateInputs()
        {
            bool isValid = comboPaciente.SelectedIndex > -1
                && comboCama.SelectedIndex > -1
                && comboDoctor.SelectedIndex > -1;
            return isValid;
        }

        void saveData(Ingreso data)
        {
            StreamWriter writer = new StreamWriter(Constants.store_income, true);
            writer.WriteLine(data.toLineCSV());
            writer.Close();
        }

        void updateCamas(int id)
        {
            int index = camas.FindIndex(e => e.id == id);
            if (index > -1)
            {
                Cama temp = camas[index];
                camas[index] = new Cama()
                {
                    id = temp.id,
                    Name = temp.Name,
                    Description = temp.Description,
                    idHabitacion = temp.idHabitacion,
                    state = false
                };
                StreamWriter writer = new StreamWriter(Constants.store_beds);
                foreach(var item in camas)
                {
                    writer.WriteLine(item.toLineCSV());
                }
                writer.Close();
            }
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                DateTime datetime = DateTime.Now;
                string date = datetime.ToShortDateString();
                int id = ingresos.Count > 0 ? ingresos.Max(v => v.id) + 1 : 1;
                int idCama = Convert.ToInt32(comboCama.SelectedValue);
                Ingreso ingreso = new Ingreso()
                {
                    id = id,
                    FechaIngreso = date,
                    FechaEgreso = "-",
                    idCama = idCama,
                    idPaciente = Convert.ToInt32(comboPaciente.SelectedValue),
                    idMedico = Convert.ToInt32(comboDoctor.SelectedValue),
                };
                ingresos.Add(ingreso);
                saveData(ingreso);
                updateCamas(idCama);
                FillTable();
            }
        }
    }
}
