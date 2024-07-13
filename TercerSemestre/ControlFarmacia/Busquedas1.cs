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
    public partial class Busquedas1 : Form
    {
        public Busquedas1()
        {
            InitializeComponent();
        }
        private string file = "Alumno.txt";

        private List<Alumno> alumnosBase = new List<Alumno>();
        private List<Alumno> alumnos = new List<Alumno>();
        private List<Municipio> municipios = new List<Municipio>();
        private List<Municipio> currentMunic = new List<Municipio>();
        private List<Departamento> departamentos = new List<Departamento>();
        private List<Grado> grados = new List<Grado>();
        private List<Carrera> carreras = new List<Carrera>();
        private DataTable dt = new DataTable();
        private void Busquedas1_Load(object sender, EventArgs e)
        {
            LoadData();
            dt.Columns.Add("Carne");
            dt.Columns.Add("Nombre 1");
            dt.Columns.Add("Nombre 2");
            dt.Columns.Add("Apellido 1");
            dt.Columns.Add("Apellido 2");
            dt.Columns.Add("Grado");
            dt.Columns.Add("Carrera");
            dt.Columns.Add("Municipio");
            dt.Columns.Add("Departamento");
            dt.Columns.Add("Genero");
            dt.Columns.Add("Fecha Nacimiento");
            dataGrid.DataSource = dt;

            FillTable();

        }

        private void LoadData()
        {
            StreamReader reader = new StreamReader("Departamento.txt");
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(',');
                Departamento dep = new Departamento()
                {
                    id = int.Parse(line[0]),
                    Name = line[1]
                };
                departamentos.Add(dep);
            }
            reader.Close();
            reader = new StreamReader("Municipio.txt");

            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(',');
                Municipio municipio = new Municipio()
                {
                    idDepartamento = int.Parse(line[0]),
                    id = int.Parse(line[1]),
                    Name = line[2],
                };
                municipios.Add(municipio);
            }
            reader.Close();

            reader = new StreamReader("Grado.txt");
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(',');
                Grado g = new Grado()
                {
                    id = int.Parse(line[0]),
                    Name = line[1],
                };
                grados.Add(g);

            }
            reader.Close();

            reader = new StreamReader("Carrera.txt");
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(',');
                Carrera c = new Carrera()
                {
                    id = int.Parse(line[0]),
                    Name = line[1],
                };
                carreras.Add(c);

            }

            reader.Close();
            reader = new StreamReader("Alumno.txt");
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(',');
                Alumno a = new Alumno()
                {
                    Carne = int.Parse(line[0]),
                    Nombre1 = line[1],
                    Nombre2 = line[2],
                    Apellido1 = line[3],
                    Apellido2 = line[4],
                    CodigoGrado = int.Parse(line[5]),
                    CodigoCarrera = int.Parse(line[6]),
                    CodigoMunicipio = int.Parse(line[7]),
                    GeneroAlumno = line[8],
                    FechaN = line[9],
                };
                
                alumnosBase.Add(a);
            }
            alumnos.AddRange(alumnosBase);
            reader.Close();
        }
        private void FillTable()
        {
            dt.Rows.Clear();
            foreach (Alumno a in alumnos)
            {
                Grado g = grados.FirstOrDefault((e) => e.id == a.CodigoGrado);
                Carrera c = carreras.FirstOrDefault((e) => e.id == a.CodigoCarrera);
                Municipio m = municipios.FirstOrDefault((e) => e.id == a.CodigoMunicipio);
                Departamento d = departamentos.FirstOrDefault((e) => e.id == m.idDepartamento);
                string[] line = { a.Carne.ToString(), a.Nombre1, a.Nombre2, a.Apellido1, a.Apellido2, g.Name, c.Name, m.Name, d.Name, a.GeneroAlumno, a.FechaN };

                dt.Rows.Add(line);
            }
        }

        private void carne_Click(object sender, EventArgs e)
        {
            if (texBox.Text != "")
            {
                string s  = texBox.Text;    
                alumnos.Clear();
                alumnos = alumnosBase.FindAll((v) => v.Carne.ToString().Contains(s)).ToList();
                FillTable();
            }
        }

        private void nombre_Click(object sender, EventArgs e)
        {
            if (texBox.Text != "")
            {
                string a = texBox.Text;
                string aL = a.ToLower();
                string aC = cleanString(aL);
                alumnos.Clear();
                alumnos = alumnosBase.FindAll((v) => cleanString(v.Nombre1.ToLower()).Contains(aC) || cleanString(v.Nombre2.ToLower()).Contains(aC)).ToList();
                FillTable();
            }
        }

        private void apellido_Click(object sender, EventArgs e)
        {
            if (texBox.Text != "")
            {
                string a = texBox.Text;
                string aL = a.ToLower();
                string aC = cleanString(aL);
                alumnos.Clear();
                alumnos = alumnosBase.FindAll((v) => cleanString(v.Apellido1.ToLower()).Contains(aC) || cleanString(v.Apellido2.ToLower()).Contains(aC)).ToList();
                FillTable();
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            texBox.Text = string.Empty;
            alumnos.Clear();
            alumnos.AddRange(alumnosBase);
            FillTable();
        }

        private string cleanString(string a)
        {
            string replaceWord (char s)
            {
                switch (s)
                {
                    case 'á': return "a";
                    case 'é': return "e";
                    case 'í': return "i";
                    case 'ó': return "o";
                    case 'ú': return "u";
                    default: return s.ToString();
                }
            }
            string result = "";
            foreach (char c in a)
            {
                result += replaceWord(c);
            }
            return result;
        }


    }
}
