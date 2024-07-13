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

namespace ControlEducativo
{
    public partial class Reporte2 : Form
    {
        public Reporte2()
        {
            InitializeComponent();
        }
        private string file = "Farmacia.txt";
        private string fileMarcas = "Marcas.txt";
        private List<Producto> productos = new List<Producto>();
        private List<Producto> productTable = new List<Producto>();
        private List<Marca> marcas = new List<Marca>();

        private DataTable dt = new DataTable();

        private void Reporte2_Load(object sender, EventArgs e)
        {
            LoadData();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Precio Costo");
            dt.Columns.Add("Precio Venta");
            dt.Columns.Add("Fecha Produccion");
            dt.Columns.Add("Fecha Vencimiento");
            dt.Columns.Add("Existencia");
            dt.Columns.Add("Estado");
            dt.Columns.Add("Marca");

            FillTable();


            dataGrid.DataSource = dt;
        }

        private void LoadData()
        {
            StreamReader reader;
            reader = new StreamReader(fileMarcas);
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(',');
                Marca element = new Marca
                {
                    id = line[0],
                    Name = line[1],
                };
                marcas.Add(element);

            }
            reader.Close();

            reader = new StreamReader(file);
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(',');
                Producto element = new Producto()
                {
                    id = Convert.ToInt32(line[0]),
                    Name = line[1],
                    PrecioC = Convert.ToInt32(line[2]),
                    PrecioV = Convert.ToInt32(line[3]),
                    FechaProdu = line[4],
                    FechaVen = line[5],
                    Existencia = Convert.ToInt32(line[6]),
                    Estado = Convert.ToInt32(line[7]),
                    CodigoMarc = line[8],

                };
                productos.Add(element);
            }
            productTable.AddRange(productos);

            reader.Close();

        }
        private void FillTable()
        {
            dt.Rows.Clear();
            foreach (Producto a in productTable)
            {
                Marca m = marcas.FirstOrDefault((e) => e.id == a.CodigoMarc);
                string stado = a.Estado == 1 ? "Activo" : "Inactivo";
                string[] line = { a.id.ToString(), a.Name, a.PrecioC.ToString(), a.PrecioV.ToString(), a.FechaProdu, a.FechaVen, a.Existencia.ToString(), stado, m.Name };

                dt.Rows.Add(line);
            }
            dataGrid.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime fInicial = date1.Value.Date;
            DateTime fFinal = date2.Value.Date;

            var result = productos.Where(v =>
            {
                DateTime fechaProdu;
                if (DateTime.TryParse(v.FechaProdu, out fechaProdu))
                {
                    return fechaProdu >= fInicial && fechaProdu <= fFinal;
                }
                return false;
            }).ToList();

            productTable.Clear();
            productTable.AddRange(result);

            FillTable();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            date1.Text = now.ToShortDateString();
            date2.Text = now.ToShortDateString();
            productTable.Clear();
            productTable.AddRange(productos);
            FillTable();
        }
    }
}
