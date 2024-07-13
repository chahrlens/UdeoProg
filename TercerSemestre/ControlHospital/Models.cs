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

struct Departamento
{
    public int id;
    public string Name;
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
    public int id;
    public string Name;
    public int idDepartamento;

    public string[] toList()
    {
        return new string[] { id.ToString(), Name, idDepartamento.ToString() };
    }

    public string toLineCSV()
    {
        return string.Join(",", toList());
    }
}


struct Habitacion
{
    public int id { get; set; }
    public string Name { get; set; }

    public string[] toList()
    {
        return new string[] { id.ToString(), Name };
    }

    public string toLineCSV()
    {
        return string.Join(",", toList());
    }
}

struct Cama
{
    public int id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool state { get; set; }
    public int idHabitacion { get; set; }

    public string[] toList()
    {
        return new string[] { id.ToString(), Name, Description, state.ToString(), idHabitacion.ToString() };
    }

    public string toLineCSV()
    {
        return string.Join(",", toList());
    }
}

struct Enfemedad
{
    public int id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public string[] toList()
    {
        return new string[] { id.ToString(), Name, Description };
    }

    public string toLineCSV()
    {
        return string.Join(",", toList());
    }
}



struct DetalleEnfermedades
{
    public int id;
    public string Diagnostico;
    public string tratamiento;
    public int idEnfermedad;
    public int idIngreso;

    public string[] toList()
    {
        return new string[] { id.ToString(), Diagnostico, tratamiento, idEnfermedad.ToString(), idIngreso.ToString() };
    }

    public string toLineCSV()
    {
        return string.Join(",", toList());
    }
}


struct Especialidad
{
    public int id;
    public string Name;
    public string[] toList()
    {
        return new string[] { id.ToString(), Name };
    }
    public string toLineCSV()
    {
        return string.Join(",", toList());
    }
}

struct Medico
{
    public int id { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public int idEspecialidad { get; set; }
    public int idMunicipio { get; set; }
    public string FullName
    {
        get
        {
            return Nombres + ", " + Apellidos;
        }
    }

    public string[] toList()
    {
        return new string[]
        {
            id.ToString(),
            Nombres,
            Apellidos,
            Direccion,
            Telefono,
            idEspecialidad.ToString(),
            idMunicipio.ToString()
        };
    }

    public string toLineCSV()
    {
        return string.Join(",", toList());
    }
}


struct Paciente
{
    public int id { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string FechaNacimiento { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }

    public string FullName
    {
        get
        {
            return Nombres + ", " + Apellidos;
        }
    }
    public int idMunicipio { get; set; }

    public string[] toList()
    {
        return new string[]
        {
            id.ToString(),
            Nombres,
            Apellidos,
            FechaNacimiento,
            Direccion,
            Telefono,
            idMunicipio.ToString()
        };
    }

    public string toLineCSV()
    {
        return string.Join(",", toList());
    }
}

//¿Como asignar un valor a cada opcion de combobox
//https://www.codeproject.com/Questions/1210807/Como-asignar-un-valor-a-cada-opcion-de-combobox-en
struct Ingreso
{
    public int id { get; set; }
    public string FechaIngreso { get; set; }
    public string FechaEgreso { get; set; }
    public int idCama { get; set; }
    public int idPaciente { get; set; }
    public int idMedico { get; set; }

    public string[] toList()
    {
        return new string[]
        {
            id.ToString(),
            FechaIngreso,
            FechaEgreso,
            idCama.ToString(),
            idPaciente.ToString(),
            idMedico.ToString()
        };
    }

    public string toLineCSV()
    {
        return string.Join(",", toList());
    }
}