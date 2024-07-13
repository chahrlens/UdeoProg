using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace farmacia
{
    public partial class AltaProductos : Form
    {
        public AltaProductos()
        {
            InitializeComponent();
        }
        private StreamReader reader;
        private StreamWriter writer;
        private string file = "Farmacia.txt";
        private List<Producto> productos = new List<Producto>();

        DataTable tablaProducto = new DataTable();
        private void AltaProductos_Load(object sender, EventArgs e)
        {
            tablaProducto.Columns.Add("Código");
            tablaProducto.Columns.Add("Producto");
            tablaProducto.Columns.Add("Precio Costo");
            tablaProducto.Columns.Add("Precio Venta");
            tablaProducto.Columns.Add("Fecha Produc");
            tablaProducto.Columns.Add("Fecha Venci");
            tablaProducto.Columns.Add("Existencia");
            tablaProducto.Columns.Add("Estado");
            dataGridViewproductos.DataSource = tablaProducto;
            load();
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
        }
        public void load()
        {
            try
            {
                reader = new StreamReader(file);
                while (!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine().Split(',');
                    Producto p = new Producto();
                    p.codigo = Convert.ToInt32(data[0]);
                    p.descripcion = data[1];
                    p.precioVenta = Convert.ToDouble(data[2]);
                    p.precioCosto = Convert.ToDouble(data[3]);
                    p.fechaProduccion = data[4];
                    p.fechaCaducidad = data[5];
                    p.existencia = Convert.ToInt32(data[6]);
                    p.estado = Convert.ToInt32(data[7]);

                   productos.Add(p);
                   tablaProducto.Rows.Add(data);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                writer = new StreamWriter(file);
                writer.Write("");
                writer.Close();
            }
        }
        private void clean()
        {
            textBoxCod.Text = "";
            textBoxNom.Text = "";
            textBoxprec_Cost.Text = "";
            textBoxprecio_Ven.Text = "";
            boxActive.Text = "";
            textBoxExis.Text = "";
            textBoxCod.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxCod.Text != "" && textBoxNom.Text != "" && textBoxprec_Cost.Text != "" &&
                textBoxprecio_Ven.Text != "" && textBoxExis.Text != "")
            {
                if (Convert.ToDouble(textBoxprec_Cost.Text) < Convert.ToDouble(textBoxprecio_Ven.Text))
                {
                    string tempCode = textBoxCod.Text;
                    bool exists = false;
                    foreach (DataRow row in tablaProducto.Rows)
                    {
                        int a = Convert.ToInt32(row[0].ToString());
                        int b = Convert.ToInt32(tempCode);
                        if (a == b)
                        {
                            exists = true;
                        }
                    }
                    if (!exists)
                    {
                        string line = textBoxCod.Text + "," + textBoxNom.Text + "," + textBoxprec_Cost.Text +
                            "," + textBoxprecio_Ven.Text +  "," +  datePickProduccion.Text + "," + datePickVencimiento.Text + "," + textBoxExis.Text + "," + boxActive.Text;
                        
                        StreamWriter writer = new StreamWriter(file, true);
                        writer.WriteLine(line);
                        writer.Close();

                        tablaProducto.Rows.Add(textBoxCod.Text, textBoxNom.Text, textBoxprec_Cost.Text,
                            textBoxprecio_Ven.Text, datePickProduccion.Text, datePickVencimiento.Text, textBoxExis.Text, boxActive.Text);
                        MessageBox.Show("Producto ingresado, exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clean();
                    }
                    else
                    {
                        MessageBox.Show("El código ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("El precio de costo no puede ser menor al de venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clean();
                }

            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clean();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            foreach (DataRow column in tablaProducto.Rows)
            {
                if (column[0].ToString() == textBoxCod.Text)
                {
                    column[1] = textBoxNom.Text;
                    column[2] = textBoxprec_Cost.Text;
                    column[3] = textBoxprecio_Ven.Text;
                    column[4] = textBoxExis.Text;
                }
            }
            StreamWriter writer = new StreamWriter(file);
            foreach (DataRow row in tablaProducto.Rows)
            {
                string lin = row[0].ToString() + "," + row[1].ToString() + "," + row[2].ToString() + "," + row[3].ToString() + "," + row[4].ToString() + "," + row[5].ToString() + "," + row[6].ToString() + "," + row[7].ToString();
                writer.WriteLine(lin);
            }
            writer.Close();
            MessageBox.Show("Producto actulizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            buttonSave.Enabled = true;
            textBoxCod.Enabled = true;
            clean();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Esta seguro de eliminar este elemento?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                int count = 0;
                foreach (DataRow element in tablaProducto.Rows)
                {
                    if (textBoxCod.Text == element[0].ToString())
                    {
                        tablaProducto.Rows.RemoveAt(count);
                        break;
                    }
                    count++;
                }
                updateFile("Producto eliminado correctamente.");
            }
        }

        private void updateFile(string message)
        {
            foreach (DataRow column in tablaProducto.Rows)
            {
                if (column[0].ToString() == textBoxCod.Text)
                {
                    column[1] = textBoxNom.Text;
                    column[2] = textBoxprec_Cost.Text;
                    column[3] = textBoxprecio_Ven.Text;
                    column[4] = textBoxExis.Text;
                }
            }
            StreamWriter writer = new StreamWriter(file);
            foreach (DataRow row in tablaProducto.Rows)
            {
                string lin = row[0].ToString() + "," + row[1].ToString() + "," + row[2].ToString() + "," + row[3].ToString() + "," + row[4].ToString() + "," + row[5].ToString() + "," + row[6].ToString() + "," + row[7].ToString();
                writer.WriteLine(lin);
            }
            writer.Close();
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            buttonSave.Enabled = true;
            textBoxCod.Enabled = true;
        }
    }
}
