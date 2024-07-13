using System;
using System.Data;
using System.IO;

using System.Windows.Forms;

namespace GestionDeClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        const string fileName = "Client.txt";
        const string divider = ";";
        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Nit");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("Edad");
            dt.Columns.Add("Nacimiento");

            dataGridView1.DataSource = dt;
            loadFile();
            buttonEdit.Enabled = false;
            buttonRemove.Enabled = false;

        }

        public void loadFile()
        {
            try
            {
                StreamReader reader = new StreamReader(fileName);
                while (!reader.EndOfStream)
                {
                    string l = reader.ReadLine();
                    string[] temp = l.Split(divider.ToCharArray());
                    dt.Rows.Add(temp);
                }
                reader.Close();
            } catch (Exception ex) {
                StreamWriter w = new StreamWriter(fileName);
                w.Write("");
                w.Close();
            }
        }
        public void cleanInputs()
        {
            boxNit.Text = "";
            boxName.Text = "";
            boxLastName.Text = "";
            boxOld.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            boxNit.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            boxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            boxLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            boxOld.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            buttonEdit.Enabled = true;
            buttonRemove.Enabled = true;
            buttonSave.Enabled = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (boxNit.Text != "" && boxName.Text != "" && boxLastName.Text != "" && boxOld.Text != "")
            {
                    string temNit = boxNit.Text;
                    bool existsNit = false;
                    foreach (DataRow fila in dt.Rows)
                    {
                        int a = Convert.ToInt32(fila[0].ToString());
                        int b = Convert.ToInt32(temNit);
                        if (a == b)
                        {
                            existsNit = true;
                        }
                    }
                    if (!existsNit)
                    {
                        string line = boxNit.Text + divider + boxName.Text + divider + boxLastName.Text +
                            divider + boxOld.Text + divider + dateTimePicker.Text;
                        StreamWriter escribir = new StreamWriter(fileName, true);
                        escribir.WriteLine(line);
                        escribir.Close();
                        dt.Rows.Add(boxNit.Text, boxName.Text, boxLastName.Text,
                            boxOld.Text, dateTimePicker.Text);

                        MessageBox.Show("Elemento ingresado, exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleanInputs();
                    }
                    else
                    {
                        MessageBox.Show("El nit ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
             }
             else
             {
                    MessageBox.Show("No puede guardar campos vacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanInputs();
             }

 
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == boxNit.Text)
                {
                    row[1] = boxNit.Text;
                    row[2] = boxName.Text;
                    row[3] = boxLastName.Text;
                    row[4] = boxOld.Text;
                }
            }
            StreamWriter writer = new StreamWriter(fileName);
            foreach (DataRow row in dt.Rows)
            {
                string lin = row[0].ToString() + divider + row[1].ToString() + divider + row[2].ToString() + divider + row[3].ToString() + divider + row[4].ToString();
                writer.WriteLine(lin);
            }
            writer.Close();
            MessageBox.Show("Elemento actulizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonEdit.Enabled = false;
            buttonRemove.Enabled = false;
            buttonSave.Enabled = true;
            cleanInputs();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Esta seguro de eliminar este elemento?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                int count = 0;
                foreach (DataRow element in dt.Rows)
                {
                    if (boxNit.Text == element[0].ToString())
                    {
                        dt.Rows.RemoveAt(count);
                        break;
                    }
                    count++;
                }
                updateFile("Elemento eliminado correctamente.");
            }
        }

        private void updateFile(string message)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == boxNit.Text)
                {
                    row[1] = boxNit.Text;
                    row[2] = boxName.Text;
                    row[3] = boxLastName.Text;
                    row[4] = boxOld.Text;
                }
            }
            StreamWriter escribir = new StreamWriter(fileName);
            foreach (DataRow fila in dt.Rows)
            {
                string lin = fila[0].ToString() + divider + fila[1].ToString() + divider + fila[2].ToString() + divider + fila[3].ToString() + divider + fila[4].ToString();
                escribir.WriteLine(lin);
            }
            escribir.Close();
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonEdit.Enabled = false;
            buttonRemove.Enabled = false;
            buttonSave.Enabled = true;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Today;
            int old = now.Year - dateTimePicker.Value.Year;
            boxOld.Text = old.ToString();      

        }
    }
}
