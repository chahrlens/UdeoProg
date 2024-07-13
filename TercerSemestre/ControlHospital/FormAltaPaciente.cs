using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlHospital
{
    public partial class FormAltaPaciente : Form
    {
        public FormAltaPaciente()
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
        private void FormAltaPaciente_Load(object sender, EventArgs e)
        {
            LoadMedicos();
            LoadPacientes();
            LoadCamas();
            LoadHabitaciones();
            LoadIngreso();

            dt.Columns.Add("");
            dt.Columns.Add("");
            dt.Columns.Add("");
            dt.Columns.Add("");
            dt.Columns.Add("");
            dt.Columns.Add("");

            dataGrid.DataSource = dt;

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
    }
}
