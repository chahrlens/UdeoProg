using System.Linq;
using System.Security.Policy;

struct User
{
    public int id;
    public string Name;
    public string Password;
    public string[] toList()
    {
        return new string[] { id.ToString(), Name, Password };
    }

    public string toLineCSV()
    {
        return string.Join(",", toList());
    }
}

    struct Marca
    {
        public string id { get; set; }
        public string Name { get; set; }
    }

struct Producto
{
    public int id { get; set; }
    public string Name { get; set; }
    public int PrecioC {  get; set; }
    public int PrecioV { get; set; }

    public string FechaProdu {  get; set; }

    public string FechaVen {  get; set; }
    public int Existencia { get; set; }
    public int Estado {  get; set; }
    public string CodigoMarc {  get; set; }
}


struct Departamento
{
    public int id { get; set; }
    public string Name { get; set; }
    public string[] toList()
    {
        return new string[]
        {
            id.ToString(),
            Name,
        };
    }

    public string toLineCSV()
    {
        return string.Join(",", toList());
    }
}
struct Municipio
{
    public int id { get; set; }
    public string Name { get; set; }
    public int idDepartamento { get; set; }

    public string[] toList()
    {
        return new string[] { id.ToString(), Name, idDepartamento.ToString() };
    }

    public string toLineCSV()
    {
        return string.Join(",", toList());
    }
}

struct Grado
{
    public int id { get; set; }
    public string Name { get; set; }
}

struct Carrera
{
    public int id { get; set; }
    public string Name { get; set; }
}

struct Alumno
{
    public int Carne;
    public string Nombre1;
    public string Nombre2;
    public string Apellido1;
    public string Apellido2;
    public int CodigoGrado;
    public int CodigoCarrera;
    public int CodigoMunicipio;
    public string GeneroAlumno;
    public string FechaN;
}