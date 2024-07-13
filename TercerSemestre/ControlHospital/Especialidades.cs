using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ControlHospital
{
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
        }
        private List<Especialidad> especialidades = new List<Especialidad>();
        private DataTable dt = new DataTable();

        private void Especialidades_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnCancel.Enabled = false;
            LoadData();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombre");
            foreach (var item in especialidades)
            {
                dt.Rows.Add(item.toList());
            }
            dataGrid.DataSource = dt;
            dataGrid.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadData()
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (boxName.Text != "")
            {
                bool exists = false;
                foreach (Especialidad item in especialidades)
                {
                    if (item.Equals(boxName.Text))
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    int maxId = especialidades.Count > 0 ? especialidades.Max(element => element.id) + 1 : 1;
                    Especialidad especialidad = new Especialidad()
                    {
                        id = maxId,
                        Name = boxName.Text,
                    };
                    especialidades.Add(especialidad);
                    storeAddItem(especialidad);
                    dt.Rows.Add(especialidad.toList());
                    boxCode.Text = "";
                    boxName.Text = "";

                }
            }
        }
        private void storeAddItem(Especialidad data)
        {
            StreamWriter writer = new StreamWriter(Constants.store_escpecial, true);
            writer.WriteLine(data.toLineCSV());
            writer.Close();
        }
        private void updateStore()
        {
            StreamWriter writer = new StreamWriter(Constants.store_escpecial);
            foreach (var element in especialidades)
            {
                writer.WriteLine(element.toLineCSV());
            }
            writer.Close();
            dt.Rows.Clear();
            foreach (var item in especialidades)
            {
                dt.Rows.Add(item.toList());
            }

        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < especialidades.Count)
            {
                var element = especialidades[e.RowIndex];
                boxCode.Text = element.id.ToString();
                boxName.Text = element.Name;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnCancel.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = true;
            boxCode.Text = "";
            boxName.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (boxName.Text != "")
            {
                int id = Convert.ToInt32(boxCode.Text);

                int index = especialidades.FindIndex(c => c.id == id);

                if (index > -1)
                {
                    especialidades[index] = new Especialidad { id = id, Name = boxName.Text };
                    updateStore();
                    btnCancel.PerformClick();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (boxCode.Text != "")
            {
                int id = Convert.ToInt32(boxCode.Text);
                int index = especialidades.FindIndex(c => c.id == id);
                if (index > -1)
                {
                    especialidades.RemoveAt(index);
                    updateStore();
                    btnCancel.PerformClick();
                }
            }
        }
    }
}
