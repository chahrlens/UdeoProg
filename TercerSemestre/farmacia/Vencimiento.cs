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

namespace farmacia
{
    public partial class Vencimiento : Form
    {
        public Vencimiento()
        {
            InitializeComponent();
        }


        private StreamReader reader;
        private StreamWriter writer;
        private string file = "Farmacia.txt";
        private List<Producto> productos = new List<Producto>();

        DataTable tablaProducto = new DataTable();

        private void Vencimiento_Load(object sender, EventArgs e)
        {
            tablaProducto.Columns.Add("Código");
            tablaProducto.Columns.Add("Producto");
            tablaProducto.Columns.Add("Precio Costo");
            tablaProducto.Columns.Add("Precio Venta");
            tablaProducto.Columns.Add("Fecha Produc");
            tablaProducto.Columns.Add("Fecha Venci");
            tablaProducto.Columns.Add("Existencia");
            tablaProducto.Columns.Add("Estado");
            dataGridView.DataSource = tablaProducto;
            load();
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

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (fechaVencimiento.Text != "")
            {
                DateTime fechaDeVencimiento = DateTime.Parse(fechaVencimiento.Text);

                tablaProducto.Clear();

                foreach (Producto producto in productos)
                {
                    DateTime fechaCaducidad = DateTime.Parse(producto.fechaCaducidad);
                    if (fechaCaducidad == fechaDeVencimiento)
                    {
                        tablaProducto.Rows.Add(producto.codigo, producto.descripcion, producto.precioCosto, producto.precioVenta, producto.fechaProduccion, producto.fechaCaducidad, producto.existencia, producto.estado);
                    }
                }
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            tablaProducto.Clear();
            foreach (Producto producto in productos)
            {
                tablaProducto.Rows.Add(producto.codigo, producto.descripcion, producto.precioCosto, producto.precioVenta, producto.fechaProduccion, producto.fechaCaducidad, producto.existencia, producto.estado);
            }
        }
    }
}
