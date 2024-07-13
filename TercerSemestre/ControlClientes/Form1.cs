using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ControlClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private struct Cliente
        {
            public string Nit;
            public string FirstName;
            public string LastName;
            public int old;
            public string birthDate;
            public string address;
        }

        private StreamReader reader;
        private StreamWriter writer;
        private string file = "clientes.txt";
        DataTable tablaClientes = new DataTable();
        private List<Cliente> clientes = new List<Cliente>();
        private void Form1_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            tablaClientes.Columns.Add("Nit");
            tablaClientes.Columns.Add("Nombres");
            tablaClientes.Columns.Add("Apellidos");
            tablaClientes.Columns.Add("Fecha nacimiento");
            tablaClientes.Columns.Add("Edad");
            tablaClientes.Columns.Add("Direccion");
            load();

            dataTable.DataSource = tablaClientes;
        }

        public void load()
        {
            try
            {
                reader = new StreamReader(file);
                while (!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine().Split(',');
                    tablaClientes.Rows.Add(data);
                }
                reader.Close();
                reader = null;
            }
            catch (Exception ex)
            {
                writer = new StreamWriter(file);
                writer.Write("");
                writer.Close();
            }
        }

        void clean()
        {
            boxNit.Text = string.Empty;
            boxFirstName.Text = string.Empty;
            boxLasName.Text = string.Empty;
            boxOld.Text = string.Empty;
            boxAddress.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (boxNit.Text != "" && boxFirstName.Text != "" && boxLasName.Text != "" && boxOld.Text != "" && boxAddress.Text != "")
            {
                bool exists = false;
                foreach (Cliente c in clientes)
                {
                    if (c.Nit == boxNit.Text)
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    Cliente cliente = new Cliente
                    {
                        Nit = boxNit.Text,
                        FirstName = boxFirstName.Text,
                        LastName = boxLasName.Text,
                        old = Convert.ToInt32(boxOld.Text),
                        birthDate = datePicker.Text,
                        address = boxAddress.Text
                    };

                    saveLine(cliente);

                    clientes.Add(cliente);
                    tablaClientes.Rows.Add(boxNit.Text, boxFirstName.Text, boxLasName.Text, datePicker.Text, boxOld.Text, boxAddress.Text);

                    clean();

                    MessageBox.Show("Cliente agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El cliente ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = datePicker.Value;
            DateTime fechaActual = DateTime.Today;

            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaNacimiento > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            boxOld.Text = edad.ToString();
        }

        private void saveLine(Cliente cliente)
        {
            string line = cliente.Nit + "," + cliente.FirstName + "," + cliente.LastName + "," + cliente.birthDate + "," + cliente.old + "," + cliente.address;
            writer = new StreamWriter(file, true);
            writer.WriteLine(line);
            writer.Close();
            writer = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(file);
            foreach (DataRow row in tablaClientes.Rows)
            {
                if (row[0].ToString() == boxNit.Text)
                {
                    row[1] = boxFirstName.Text;
                    row[2] = boxLasName.Text;
                    row[3] = datePicker.Text;
                    row[4] = boxOld.Text;
                    row[5] = boxAddress.Text;

                    string nit = boxNit.Text;
                    Cliente cliente = clientes.Find(c => c.Nit == nit);
                    if (cliente.Nit != null)
                    {
                        cliente.FirstName = boxFirstName.Text;
                        cliente.LastName = boxLasName.Text;
                        cliente.old = Convert.ToInt32(boxOld.Text);
                        cliente.birthDate = datePicker.Text;
                        cliente.address = boxAddress.Text;
                    }
                }
                string lin = row[0].ToString() + "," + row[1].ToString() + "," + row[2].ToString() + "," + row[3].ToString() + "," + row[4].ToString() + "," + row[5].ToString();
                writer.WriteLine(lin);
            }
            writer.Close();

            MessageBox.Show("Cliente actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            clean();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Esta seguro de eliminar este elemento?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                int count = 0;
                foreach (DataRow element in tablaClientes.Rows)
                {
                    if (boxNit.Text == element[0].ToString())
                    {
                        tablaClientes.Rows.RemoveAt(count);
                        break;
                    }
                    count++;
                }
                updateFile("Producto eliminado correctamente.");
            }
        }

        private void updateFile(string message)
        {
            foreach (DataRow row in tablaClientes.Rows)
            {
                if (row[0].ToString() == boxNit.Text)
                {
                    row[1] = boxFirstName.Text;
                    row[2] = boxLasName.Text;
                    row[3] = datePicker.Text;
                    row[4] = boxOld.Text;
                    row[5] = boxAddress.Text;
                }

                string nit = boxNit.Text;
                Cliente cliente = clientes.Find(c => c.Nit == nit);
                if (cliente.Nit != null)
                {
                    cliente.FirstName = boxFirstName.Text;
                    cliente.LastName = boxLasName.Text;
                    cliente.old = Convert.ToInt32(boxOld.Text);
                    cliente.birthDate = datePicker.Text;
                    cliente.address = boxAddress.Text;
                }
            }
            StreamWriter writer = new StreamWriter(file);
            foreach (DataRow row in tablaClientes.Rows)
            {
                string lin = row[0].ToString() + "," + row[1].ToString() + "," + row[2].ToString() + "," + row[3].ToString() + "," + row[4].ToString() + "," + row[5].ToString();
                writer.WriteLine(lin);
            }
            writer.Close();
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void mayoresDeEdadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablaClientes.Clear();
            foreach (Cliente cliente in clientes)
            {
                if (cliente.old > 18)
                {
                    tablaClientes.Rows.Add(cliente.Nit, cliente.FirstName, cliente.LastName, cliente.birthDate, cliente.old, cliente.address);
                }
            }
        }

        private void menoresDeEdadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablaClientes.Clear();
            foreach (Cliente cliente in clientes)
            {
                if (cliente.old < 18)
                {
                    tablaClientes.Rows.Add(cliente.Nit, cliente.FirstName, cliente.LastName, cliente.birthDate, cliente.old, cliente.address);
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            tablaClientes.Clear();
            foreach (Cliente cliente in clientes)
            {
                tablaClientes.Rows.Add(cliente.Nit, cliente.FirstName, cliente.LastName, cliente.birthDate, cliente.old, cliente.address);

            }
        }
        private void nItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (boxSearch.Text != "")
            {
                tablaClientes.Clear();
                foreach (Cliente cliente in clientes)
                {
                    if (cliente.Nit == boxSearch.Text)
                    {
                        tablaClientes.Rows.Add(cliente.Nit, cliente.FirstName, cliente.LastName, cliente.birthDate, cliente.old, cliente.address);
                    }

                }
                boxSearch.Text = string.Empty;
            }
        }

        private void nombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (boxSearch.Text != "")
            {
                tablaClientes.Clear();
                foreach (Cliente cliente in clientes)
                {
                    if (cliente.FirstName == boxSearch.Text)
                    {
                        tablaClientes.Rows.Add(cliente.Nit, cliente.FirstName, cliente.LastName, cliente.birthDate, cliente.old, cliente.address);
                    }

                }
                boxSearch.Text = string.Empty;
            }
        }

        private void apellidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (boxSearch.Text != "")
            {
                tablaClientes.Clear();
                foreach (Cliente cliente in clientes)
                {
                    if (cliente.LastName == boxSearch.Text)
                    {
                        tablaClientes.Rows.Add(cliente.Nit, cliente.FirstName, cliente.LastName, cliente.birthDate, cliente.old, cliente.address);
                    }

                }
                boxSearch.Text = string.Empty;
            }
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (boxSearch.Text != "")
            {
                tablaClientes.Clear();
                foreach (Cliente cliente in clientes)
                {
                    if (cliente.address.Contains(boxSearch.Text))
                    {
                        tablaClientes.Rows.Add(cliente.Nit, cliente.FirstName, cliente.LastName, cliente.birthDate, cliente.old, cliente.address);
                    }

                }
                boxSearch.Text = string.Empty;
            }
        }

        private void dataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnEdit.Enabled = true;
                DataGridViewRow row =  dataTable.Rows[e.RowIndex];
                boxNit.Text = row.Cells["Nit"].Value.ToString();
                boxFirstName.Text = row.Cells["Nombres"].Value.ToString();
                boxLasName.Text = row.Cells["Apellidos"].Value.ToString();
                boxOld.Text = row.Cells["Edad"].Value.ToString();
                boxAddress.Text = row.Cells["Direccion"].Value.ToString();
            }
        }
    }
}
