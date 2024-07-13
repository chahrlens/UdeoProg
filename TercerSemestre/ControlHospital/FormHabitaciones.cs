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
    public partial class FormHabitaciones : Form
    {
        public FormHabitaciones()
        {
            InitializeComponent();
        }
        private List<Habitacion> habitacions = new List<Habitacion>();
        private DataTable dt = new DataTable();
        private void Habitaciones_Load(object sender, EventArgs e)
        {
            LoadData();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombre");


            FillTable();
            dataGrid.DataSource = dt;

        }

        private void FillTable()
        {
            dt.Rows.Clear();
            foreach (var element in habitacions)
            {
                dt.Rows.Add(element.toList());
            }
        }


        private void LoadData()
        {
            StreamReader reader = new StreamReader(Constants.store_room);
            reader = new StreamReader(Constants.store_room);

            while (!reader.EndOfStream)
            {
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
