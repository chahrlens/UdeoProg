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
    public partial class FormCamas : Form
    {
        public FormCamas()
        {
            InitializeComponent();
        }
        private List<Cama> camas = new List<Cama>();
        private List<Habitacion> habitacions = new List<Habitacion>();
        private DataTable dt = new DataTable(); 

        private void FormCamas_Load(object sender, EventArgs e)
        {
            LoadData();

            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Estado");
            dt.Columns.Add("Habitacion");


            FillTable();
            dataGrid.DataSource = dt;

            
        }

        private void FillTable()
        {
            dt.Rows.Clear();
            foreach(var element in camas)
            {
                var h = habitacions.FirstOrDefault(v => v.id == element.idHabitacion);
                string state = element.state ? "Libre" : "Ocupada";
                string[] row = new string[] { element.id.ToString(), element.Name, element.Description, state, h.Name };
                dt.Rows.Add(row);
            }
        }

        private void LoadData()
        {
            StreamReader reader = new StreamReader(Constants.store_beds);
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(',');

                Cama cama  = new Cama()
                {
                    id = int.Parse(line[0]),
                    Name = line[1],
                    Description = line[2],
                    state = Convert.ToBoolean(line[3]),
                    idHabitacion = int.Parse(line[4]),
                };
                camas.Add(cama);
            }

            reader.Close();

            reader = new StreamReader(Constants.store_room);

            while (!reader.EndOfStream) {
                    string[] line = reader.ReadLine().Split(',');
                Habitacion habitacion = new Habitacion()
                {
                    id = int.Parse(line[0]),
                    Name = line[1],
                };
                habitacions.Add(habitacion);
            }
            reader.Close();
        }
    }
}
