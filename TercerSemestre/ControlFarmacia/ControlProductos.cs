using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.DesignerServices;
using System.Windows.Forms;

namespace ControlEducativo
{
    public partial class ControlProductos : Form
    {
        public ControlProductos()
        {
            InitializeComponent();
        }

        private string file = "Farmacia.txt";
        private string fileMarcas = "Marcas.txt";
        private List<Producto> productos = new List<Producto>();
        private List<Marca> marcas = new List<Marca>(); 

        private DataTable dt = new DataTable();
        private void ControlEducativo_Load(object sender, EventArgs e)
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
            comboMarca.DataSource = marcas;
            comboMarca.ValueMember = "id";
            comboMarca.DisplayMember = "name";           
            comboMarca.SelectedIndex = 0;

            comboEstado.Items.Add("Activo");
            comboEstado.Items.Add("Inactivo");
            comboEstado.SelectedIndex = 0;



            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnCancel.Enabled = false;


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
                    Name   = line[1],
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
            reader.Close();

        }
        private void FillTable()
        {
            dt.Rows.Clear();
            foreach (Producto a in productos)
            {
                Marca m = marcas.FirstOrDefault((e) => e.id == a.CodigoMarc);
                string stado = a.Estado == 1 ? "Activo" : "Inactivo";
                string[] line = { a.id.ToString(), a.Name, a.PrecioC.ToString(), a.PrecioV.ToString(), a.FechaProdu, a.FechaVen, a.Existencia.ToString(), stado, m.Name };

                dt.Rows.Add(line);
            }
            dataGrid.Refresh();
        }

        private void updateStore()
        {
            StreamWriter writer = new StreamWriter(file);
            foreach (var e in productos)
            {
                
                string line = e.id.ToString() + "," + e.Name + "," + e.PrecioC + "," + e.PrecioV + "," + e.FechaProdu + "," + e.FechaVen + "," + e.Existencia + "," + e.Estado + "," + e.CodigoMarc ;
                writer.WriteLine(line);
            }
            writer.Close();

        }

        private void cleanLabels()
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = true;
            boxCode.Text = "";
            boxName1.Text = "";
            boxPrecioC.Text = "";
            boxPrecioV.Text = "";
            boxExistencia.Text = "";
            dateProduct.Text = DateTime.Now.ToString();
            comboEstado.SelectedIndex = -1;
            comboMarca.SelectedIndex = -1;

        }

        private bool testInputs()
        {
            int indexGrado = comboMarca.SelectedIndex;
            int idnexCarrera = comboEstado.SelectedIndex;
            DateTime selecteDate = Convert.ToDateTime(dateProduct.Text);
            DateTime now = DateTime.Now;


            bool test = boxName1.Text != "" 
                        && boxPrecioV.Text != "" && (selecteDate <= now);

            return test;
        }

        private void storeAddItem(Producto e)
        {
            StreamWriter writer = new StreamWriter(file, true);
            string line = e.id.ToString() + "," + e.Name + "," + e.PrecioC + "," + e.PrecioV + "," + e.FechaProdu + "," + e.FechaVen + "," + e.Existencia + "," + e.Estado + "," + e.CodigoMarc;
            writer.WriteLine(line);
            writer.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (testInputs())
            {
                bool exists = false;
                foreach (Producto element in productos)
                {
                    if (element.Name.Equals(boxPrecioV.Text))
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    int maxId = productos.Count > 0 ? productos.Max(element => element.id) + 1 : 1;

                    string marca = comboMarca.SelectedValue?.ToString();


                    Producto a = new Producto()
                    {
                        id = maxId,
                        Name = boxName1.Text,
                        PrecioC = Convert.ToInt32(boxPrecioC.Text),
                        PrecioV = Convert.ToInt32(boxPrecioV.Text),
                        FechaProdu = dateProduct.Text,
                        FechaVen = dateProduct.Text,
                        Existencia = Convert.ToInt32(boxExistencia.Text),
                        Estado = 1,
                        CodigoMarc = marca,

                    };
                    productos.Add(a);
                    storeAddItem(a);
                    cleanLabels();
                    FillTable();
                    MessageBox.Show("Elemento creado con exito!");
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos");
            }
        }

        private void setFieldsData(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < productos.Count)
            {
                var element = productos[e.RowIndex];
                boxCode.Text = element.id.ToString();
                boxName1.Text = element.Name;
                boxPrecioC.Text = element.PrecioC.ToString();
                boxPrecioV.Text = element.PrecioV.ToString();
                dateProduct.Text = element.FechaVen;
                dateVenci.Text = element.FechaVen;
                boxExistencia.Text = element.Existencia.ToString();
                comboEstado.SelectedItem = element.Estado == 1 ? "Activo" : "Inactivo";

                int indexMarca = marcas.FindIndex((v) => v.id == element.CodigoMarc);
                comboMarca.SelectedIndex = indexMarca;

                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnCancel.Enabled = true;
                btnSave.Enabled = false;
            }
        }
        private void dataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            setFieldsData(e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (testInputs())
            {
                int maxId = int.Parse(boxCode.Text);
                string marca = comboMarca.SelectedValue?.ToString();
                string estado = comboEstado.SelectedValue?.ToString();


                Producto a = new Producto()
                {
                    id = maxId,
                    Name = boxName1.Text,
                    PrecioC = Convert.ToInt32(boxPrecioC.Text),
                    PrecioV = Convert.ToInt32(boxPrecioV.Text),
                    FechaProdu = dateProduct.Text,
                    FechaVen = dateProduct.Text,
                    Existencia = Convert.ToInt32(boxExistencia.Text),
                    Estado = estado == "Activo" ? 1 : 0,
                    CodigoMarc = marca,
                };

                int index = productos.FindIndex(element => element.id == maxId);
                if (index > -1)
                {
                    productos[index] = a;
                    updateStore();
                    cleanLabels();
                    FillTable();
                    MessageBox.Show("Elemento actualizado con exito!");
                }

            }
        }


        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setFieldsData(e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool test = boxCode.Text != "";
            int code;
            if (test  && int.TryParse(boxCode.Text, out code))
            {
                int index = productos.FindIndex((v) => v.id == code);
                if (index > -1)
                {
                    productos.RemoveAt(index);
                    updateStore();
                    FillTable();
                    MessageBox.Show("Elemento borrado con exito!");
                    return;
                }
            }

            MessageBox.Show("Elemento no se encontro el elemento a borrar!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleanLabels();
        }


    }
}
