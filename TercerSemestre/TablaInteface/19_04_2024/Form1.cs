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

namespace _19_04_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable tablaProducto = new DataTable();
        public void cargarPorducto()
        {
            StreamReader leer = new StreamReader("Producto.txt");
            while (!leer.EndOfStream)
            {
                string linea = leer.ReadLine();
                string[] aux = linea.Split(',');
                tablaProducto.Rows.Add(aux);
            }
            leer.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tablaProducto.Columns.Add("Código");
            tablaProducto.Columns.Add("Producto");
            tablaProducto.Columns.Add("precio_Cost");
            tablaProducto.Columns.Add("precio_Vent");
            tablaProducto.Columns.Add("Existencia");
            dataGridViewproductos.DataSource = tablaProducto;
            cargarPorducto();
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
        }
        public void limpiar()
        {
            textBoxCod.Text = "";
            textBoxNom.Text = "";
            textBoxprec_Cost.Text = "";
            textBoxprecio_Ven.Text = "";
            textBoxExis.Text = "";
            textBoxCod.Focus();
        }
        private void buttongua_Click(object sender, EventArgs e)
        {
            if (textBoxCod.Text != "" && textBoxNom.Text != "" && textBoxprec_Cost.Text != "" &&
                textBoxprecio_Ven.Text != "" && textBoxExis.Text != "")
            {
                if(Convert.ToInt32(textBoxprec_Cost.Text)< Convert.ToInt32(textBoxprecio_Ven.Text))
                {
                    string auxCod = textBoxCod.Text;
                    bool bandera = false;
                    foreach (DataRow fila in tablaProducto.Rows)
                    {
                        int a = Convert.ToInt32(fila[0].ToString());
                        int b = Convert.ToInt32(auxCod);
                        if (a == b)
                        {
                            bandera = true;
                        }    
                    }
                    if (!bandera)
                    {
                        //Guardar en el archivo de texto
                        string linea = textBoxCod.Text + "," + textBoxNom.Text + "," + textBoxprec_Cost.Text +
                            "," + textBoxprecio_Ven.Text + "," + textBoxExis.Text;
                        StreamWriter escribir = new StreamWriter("Producto.txt", true);
                        escribir.WriteLine(linea);
                        escribir.Close();
                        //Guardar en la tablaproductos
                        tablaProducto.Rows.Add(textBoxCod.Text, textBoxNom.Text, textBoxprec_Cost.Text,
                            textBoxprecio_Ven.Text, textBoxExis.Text);
                        MessageBox.Show("Producto ingresado, exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("El código ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("El precio de costo no puede ser menor al de venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }

            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiar();
            }


        }

        private void dataGridViewproductos_DoubleClick(object sender, EventArgs e)
        {
            textBoxCod.Text = dataGridViewproductos.CurrentRow.Cells[0].Value.ToString();
            textBoxNom.Text = dataGridViewproductos.CurrentRow.Cells[1].Value.ToString();
            textBoxprec_Cost.Text = dataGridViewproductos.CurrentRow.Cells[2].Value.ToString();
            textBoxprecio_Ven.Text = dataGridViewproductos.CurrentRow.Cells[3].Value.ToString();
            textBoxExis.Text = dataGridViewproductos.CurrentRow.Cells[4].Value.ToString();
            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;
            buttonSave.Enabled = false;
            textBoxCod.Enabled = false;
        }

        private void buttonedi_Click(object sender, EventArgs e)
        {
            foreach(DataRow fila in tablaProducto.Rows)
            {
                if (fila[0].ToString() == textBoxCod.Text)
                {
                    fila[1] = textBoxNom.Text;
                    fila[2] = textBoxprec_Cost.Text;
                    fila[3] = textBoxprecio_Ven.Text;
                    fila[4] = textBoxExis.Text;
                }
            }
            //actualizar el archivo de txt
            StreamWriter escribir = new StreamWriter("Producto.txt");
            foreach(DataRow fila in tablaProducto.Rows)
            {
                string lin =fila[0].ToString()+","+fila[1].ToString()+"," + fila[2].ToString() + "," + fila[3].ToString() + "," + fila[4].ToString();
                escribir.WriteLine(lin);
            }
            escribir.Close();
            MessageBox.Show("Producto actulizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonEdit.Enabled = false;//desactivar boton 
            buttonDelete.Enabled = false;
            buttonSave.Enabled = true;
            textBoxCod.Enabled = true;
            limpiar();
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
            foreach (DataRow fila in tablaProducto.Rows)
            {
                if (fila[0].ToString() == textBoxCod.Text)
                {
                    fila[1] = textBoxNom.Text;
                    fila[2] = textBoxprec_Cost.Text;
                    fila[3] = textBoxprecio_Ven.Text;
                    fila[4] = textBoxExis.Text;
                }
            }
            StreamWriter escribir = new StreamWriter("Producto.txt");
            foreach (DataRow fila in tablaProducto.Rows)
            {
                string lin = fila[0].ToString() + "," + fila[1].ToString() + "," + fila[2].ToString() + "," + fila[3].ToString() + "," + fila[4].ToString();
                escribir.WriteLine(lin);
            }
            escribir.Close();
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonEdit.Enabled = false;//desactivar boton 
            buttonDelete.Enabled = false;
            buttonSave.Enabled = true;
            textBoxCod.Enabled = true;
        }
    }


}
