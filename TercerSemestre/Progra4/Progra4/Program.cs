using System;

namespace Progra4
{
    internal class Program
    {
        struct Enfermedad
        {
            public int codigoEnfermedad;
            public string nombreEnfermedad;
        }
        struct Doctor
        {
            public int codigoDoctor;
            public string nombreDoctor, apellidoDoctor, direccionDoctor, especialidad;
            public DateTime fechaNac;
        }
        struct Paciente
        {
            public int codigoPaciente;
            public string dpiPaciente, nombrePaciente, apellidoPaciente, direccionPaciente,
                enfermedadPaciente;
            public DateTime fechaNac;
        }
        struct Especialidad
        {
            public int codigoEspecialidad;
            public string nombreEspecialidad;
        }
        static Enfermedad[] enfermedades = new Enfermedad[50];
        static Especialidad[] especialidades = new Especialidad[50];
        static Paciente[] pacientes = new Paciente[50];
        static Doctor[] doctores = new Doctor[50];

        static int enfermedadesCount = 0;
        static int especialidadesCount = 0;
        static int pacientesCount = 0;
        static int pacienteCode = 1;
        static int doctoresCount = 0;
        static void llenaEnfermedades()
        {
            enfermedades[0] = new Enfermedad { codigoEnfermedad = 1, nombreEnfermedad = "Hepatitis" };
            enfermedades[1] = new Enfermedad { codigoEnfermedad = 2, nombreEnfermedad = "Tuberculosis" };
            enfermedades[2] = new Enfermedad { codigoEnfermedad = 3, nombreEnfermedad = "Parasitos" };
            enfermedades[3] = new Enfermedad { codigoEnfermedad = 4, nombreEnfermedad = "Neumonia" };
            enfermedades[4] = new Enfermedad { codigoEnfermedad = 5, nombreEnfermedad = "Bronquitis" };
            enfermedades[5] = new Enfermedad { codigoEnfermedad = 6, nombreEnfermedad = "Artritis" };
            enfermedades[6] = new Enfermedad { codigoEnfermedad = 7, nombreEnfermedad = "Asma" };
            enfermedades[7] = new Enfermedad { codigoEnfermedad = 8, nombreEnfermedad = "Rotavirus" };
            enfermedades[8] = new Enfermedad { codigoEnfermedad = 9, nombreEnfermedad = "Coronavirus" };
            enfermedades[9] = new Enfermedad { codigoEnfermedad = 10, nombreEnfermedad = "Diabetes" };
            enfermedadesCount = 10;
        }
        static void llenaEspecialidades()
        {
            especialidades[0] = new Especialidad { codigoEspecialidad = 1, nombreEspecialidad = "Pediatría" };
            especialidades[1] = new Especialidad { codigoEspecialidad = 2, nombreEspecialidad = "Cardiología" };
            especialidades[2] = new Especialidad { codigoEspecialidad = 3, nombreEspecialidad = "Dermatología" };
            especialidades[3] = new Especialidad { codigoEspecialidad = 4, nombreEspecialidad = "Gastroenterología" };
            especialidades[4] = new Especialidad { codigoEspecialidad = 5, nombreEspecialidad = "Hematología" };
            especialidades[5] = new Especialidad { codigoEspecialidad = 6, nombreEspecialidad = "Neumología" };
            especialidades[6] = new Especialidad { codigoEspecialidad = 7, nombreEspecialidad = "Oftalmología" };
            especialidades[7] = new Especialidad { codigoEspecialidad = 8, nombreEspecialidad = "Urología" };
            especialidadesCount = 8;
        }
        static void showMenu()
        {
            //Menu Principal
            /*
                1. Menu de Pacientes
                2. Menu de Doctores
                3. Ingreso de Enfermedad
                4. Listados de Enfermedades
                5. Ingreso de Especialid
                6. Listado de Especialidades
            */

            /*Menu de Pacientes
                1. Nuevo Paciente
                2. Listado de Pacientes
                3. Editar un Paciente
                4. Eliminar un Paciente
                5. Regresar al Menu Principal
            */

            /*Menu de Doctores
                1. Nuevo Doctor
                2. Listado de Doctores
                3. Editar un Doctor
                4. Eliminar un Doctro
                5. Regresar al Menu Principal
            */
            int opcion = 0;

            bool exit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Opciones disponibles:");
                Console.WriteLine("MenuPrincipal.\n1. Menu de Pacientes\n2.Menu de Doctores\n3.Ingreso de Enfermedad\n4.Listados de Enfermedades\n5.Ingreso de Especial\n6.Listado de Especialidades");
                Console.WriteLine("Seleccione una opción");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Seleccione una opción");
                            Console.WriteLine("1. Nuevo Paciente\n2. Listado de Pacientes\n3. Editar un Paciente\n4. Eliminar un Paciente\n5. Regresar al Menu Principal");
                            opcion = Convert.ToInt32(Console.ReadLine());
                            pacientesMenu(opcion);
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("1. Nuevo Doctor\n2.Listado de Doctores\n3.Editar un Doctor\n4.Eliminar un Doctor\n5.Regresar al Menu Principal");
                            Console.WriteLine("Seleccione una opción");
                            opcion = Convert.ToInt32(Console.ReadLine());
                            doctoresMenu(opcion);
                            break;
                        }
                    case 3:
                        {
                            agregarEnfermedad();
                            break;
                        }
                    case 4:
                        {
                            listEnfermedades();
                            break;
                        }
                    case 5:
                        {
                            agregarEspecialidad();
                            break;
                        }
                    case 6:
                        {
                            listEspecialidad();
                            break;
                        }
                }
                Console.WriteLine("Presione para una tecla para continuar:");
                Console.ReadLine();

            } while (!exit);

        }

        static void pacientesMenu(int opcion)
        {
            switch (opcion)
            {
                case 1: nuevoPaciente(); break;
                case 2: listaPacientes(); break;
                case 3: editarPaciente(); break;
                case 4: eliminarPaciente(); break;
                case 5: break;

            }
        }

        static void doctoresMenu(int opcion)
        {
            switch (opcion)
            {
                case 1: nuevoDoctor(); break;
                case 2: listaDoctores(); break;
                case 3: editarDoctor(); break;
                case 4: eliminarDoctor(); break;
                case 5: break;
            }
        }

        static void agregarEnfermedad()
        {
            string _enfermedad;

            bool isValid = true;

            do
            {
                Console.WriteLine("Ingrese nueva enfermedad");
                _enfermedad = Console.ReadLine() ?? "";
                if (_enfermedad == "")
                {
                    Console.WriteLine("Nombre invalido intente de nuevo");
                }
                else
                {
                    bool exists = false;
                    for (int i = 0; i < enfermedadesCount; i++)
                    {
                        var val = enfermedades[i];
                        if (val.nombreEnfermedad == _enfermedad)
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (!exists)
                    {
                        var val = enfermedades[enfermedadesCount];
                        val.nombreEnfermedad = _enfermedad;
                        val.codigoEnfermedad = enfermedadesCount;
                        enfermedadesCount++;
                    }
                    isValid = false;
                }


            } while (isValid);
        }

        static void listEnfermedades()
        {
            Console.WriteLine("Lista de enfermedades:");
            for (int i = 0; i < enfermedadesCount; i++)
            {
                Console.WriteLine("Código: " + enfermedades[i].codigoEnfermedad + "; Nombre:" + enfermedades[i].nombreEnfermedad);
            }
        }
        static void agregarEspecialidad()
        {
            string _especialidad;

            bool isValid = true;

            do
            {
                Console.WriteLine("Ingrese nueva especialidad");
                _especialidad = Console.ReadLine() ?? "";
                if (_especialidad == "")
                {
                    Console.WriteLine("Nombre invalido intente de nuevo");
                }
                else
                {
                    bool exists = false;
                    for (int i = 0; i < especialidadesCount; i++)
                    {
                        var val = especialidades[i];
                        if (val.nombreEspecialidad == _especialidad)
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (!exists)
                    {
                        var val = especialidades[especialidadesCount];
                        val.nombreEspecialidad = _especialidad;
                        val.codigoEspecialidad = especialidadesCount;
                        especialidadesCount++;
                    }
                    isValid = false;
                }


            } while (isValid);
        }

        static void listEspecialidad()
        {
            Console.WriteLine("Lista de especialidades:");
            for (int i = 0; i < especialidadesCount; i++)
            {
                Console.WriteLine("Código: " + especialidades[i].codigoEspecialidad + "; Nombre:" + especialidades[i].nombreEspecialidad);
            }
        }

        static void nuevoPaciente()
        {

            string dpiPaciente = strInput("Ingrese numero de DPI");
            string nombrePaciente = strInput("Ingrese nombre de paciente");
            string apellidoPaciente = strInput("Ingrese apellido de paciente");
            string direccionPaciente = strInput("Ingrese dirección de paciente");
            string enfermedad = validateEnfermedad();
            DateTime fecha = inputDate("Ingrese fecha nacimiento del paciente");

            Paciente paciente = new Paciente();

            paciente.dpiPaciente = dpiPaciente;
            paciente.nombrePaciente = nombrePaciente;
            paciente.apellidoPaciente = apellidoPaciente;
            paciente.direccionPaciente = direccionPaciente;
            paciente.enfermedadPaciente = enfermedad;
            paciente.fechaNac = fecha;
            paciente.codigoPaciente = pacienteCode;

            pacientes[pacientesCount] = paciente;
            pacienteCode++;
            pacientesCount++;


        }
        static void listaPacientes()
        {
            Console.WriteLine("Lista de pacientes:");
            for (int i = 0; i < pacientesCount; i++)
            {
                Console.WriteLine("Código: " + pacientes[i].codigoPaciente + "; Nombre:" + pacientes[i].nombrePaciente);
            }

        }

        static void editarPaciente()
        {
            Console.Write("Ingrese el código del paciente que desea editar: ");
            int codigoBuscado;
            if (int.TryParse(Console.ReadLine(), out codigoBuscado))
            {
                for (int i = 0; i < pacientesCount; i++)
                {
                    if (pacientes[i].codigoPaciente == codigoBuscado)
                    {
                        Console.WriteLine("Datos actuales del paciente:");
                        Console.WriteLine($"Código: {pacientes[i].codigoPaciente}");
                        Console.WriteLine($"DPI: {pacientes[i].dpiPaciente}");
                        Console.WriteLine($"Nombre: {pacientes[i].nombrePaciente} {pacientes[i].apellidoPaciente}");
                        Console.WriteLine($"Fecha de Nacimiento: {pacientes[i].fechaNac.ToShortDateString()}");
                        Console.WriteLine($"Dirección: {pacientes[i].direccionPaciente}");
                        Console.WriteLine($"Enfermedad: {pacientes[i].enfermedadPaciente}");
                        Console.WriteLine("--------------------------");

                        Console.Write("Nuevo DPI: ");
                        pacientes[i].dpiPaciente = Console.ReadLine();

                        Console.Write("Nuevo Nombre: ");
                        pacientes[i].nombrePaciente = Console.ReadLine();

                        Console.Write("Nuevo Apellido: ");
                        pacientes[i].apellidoPaciente = Console.ReadLine();

                        Console.Write("Nueva Fecha de Nacimiento (yyyy-MM-dd): ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime nuevaFechaNac))
                        {
                            pacientes[i].fechaNac = nuevaFechaNac;
                        }

                        Console.Write("Nueva Dirección: ");
                        pacientes[i].direccionPaciente = Console.ReadLine();

                        Console.Write("Nueva Enfermedad: ");
                        pacientes[i].enfermedadPaciente = Console.ReadLine();

                        Console.WriteLine("Paciente editado exitosamente.");
                        return;
                    }
                }

                Console.WriteLine($"Paciente con código {codigoBuscado} no encontrado.");
            }
            else
            {
                Console.WriteLine("Código no válido. No se pudo editar el paciente.");
            }
        }

        static void eliminarPaciente()
        {
            Console.Write("Ingrese el código del paciente que desea eliminar: ");
            int codigoBuscado;
            if (int.TryParse(Console.ReadLine(), out codigoBuscado))
            {
                for (int i = 0; i < pacientesCount; i++)
                {
                    if (pacientes[i].codigoPaciente == codigoBuscado)
                    {
                        pacientes[i] = new Paciente();
                        Console.WriteLine($"Paciente con código {codigoBuscado} eliminado.");
                        return;
                    }
                }

                Console.WriteLine($"Paciente con código {codigoBuscado} no encontrado.");
            }
            else
            {
                Console.WriteLine("Código no válido. No se pudo eliminar el paciente.");
            }
        }

        static void nuevoDoctor()
        {
            // public int codigoDoctor;
            string nombreDoctor, apellidoDoctor, direccionDoctor, especialidad;
            DateTime fechaNac;

            int codigoDoctor = doctoresCount;
            nombreDoctor = strInput("Ingrese nombre de doctor:");
            apellidoDoctor = strInput("Ingrese apellido del doctor");
            direccionDoctor = strInput("Ingrese direccion del doctor");
            especialidad = strInput("Ingrese especialidad del doctor");
            fechaNac = inputDate("Ingrese fecha de nacimiento");

            var doctor = doctores[doctoresCount];
            doctor.codigoDoctor = codigoDoctor;
            doctor.nombreDoctor = nombreDoctor;
            doctor.apellidoDoctor = apellidoDoctor;
            doctor.direccionDoctor = direccionDoctor;
            doctor.especialidad = especialidad;
            doctor.fechaNac = fechaNac;
            doctoresCount++;
        }

        static void listaDoctores()
        {
            Console.WriteLine("Lista de doctores:");
            for (int i = 0; i < doctoresCount; i++)
            {
                Console.WriteLine("Código: " + doctores[i].codigoDoctor + "; Nombre:" + doctores[i].nombreDoctor + "\nApellido: " + doctores[i].apellidoDoctor + " Especialidad: " + doctores[i].especialidad);
            }
        }

        static void editarDoctor()
        {
            Console.Write("Ingrese el código del doctor que desea editar: ");
            int codigoBuscado;
            if (int.TryParse(Console.ReadLine(), out codigoBuscado))
            {
                for (int i = 0; i < doctoresCount; i++)
                {
                    if (doctores[i].codigoDoctor == codigoBuscado)
                    {
                        Console.WriteLine("Datos actuales del doctor:");
                        Console.WriteLine($"Código: {doctores[i].codigoDoctor}");
                        Console.WriteLine($"Nombre: {doctores[i].nombreDoctor} {doctores[i].apellidoDoctor}");
                        Console.WriteLine($"Fecha de Nacimiento: {doctores[i].fechaNac.ToShortDateString()}");
                        Console.WriteLine($"Dirección: {doctores[i].direccionDoctor}");
                        Console.WriteLine($"Especialidad: {doctores[i].especialidad}");
                        Console.WriteLine("--------------------------");

                        Console.Write("Nuevo Nombre: ");
                        doctores[i].nombreDoctor = Console.ReadLine();

                        Console.Write("Nuevo Apellido: ");
                        doctores[i].apellidoDoctor = Console.ReadLine();

                        Console.Write("Nueva Fecha de Nacimiento (yyyy-MM-dd): ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime nuevaFechaNac))
                        {
                            doctores[i].fechaNac = nuevaFechaNac;
                        }

                        Console.Write("Nueva Dirección: ");
                        doctores[i].direccionDoctor = Console.ReadLine();

                        Console.Write("Nueva Especialidad: ");
                        doctores[i].especialidad = Console.ReadLine();

                        Console.WriteLine("Doctor editado exitosamente.");
                        return;
                    }
                }

                Console.WriteLine($"Doctor con código {codigoBuscado} no encontrado.");
            }
            else
            {
                Console.WriteLine("Código no válido. No se pudo editar el doctor.");
            }
        }

        static void eliminarDoctor()
        {
            Console.Write("Ingrese el código del doctor que desea eliminar: ");
            int codigoBuscado;
            if (int.TryParse(Console.ReadLine(), out codigoBuscado))
            {
                for (int i = 0; i < doctoresCount; i++)
                {
                    if (doctores[i].codigoDoctor == codigoBuscado)
                    {
                        doctores[i] = new Doctor();
                        Console.WriteLine($"Doctor con código {codigoBuscado} eliminado.");
                        return;
                    }
                }

                Console.WriteLine($"Doctor con código {codigoBuscado} no encontrado.");
            }
            else
            {
                Console.WriteLine("Código no válido. No se pudo eliminar el doctor.");
            }
        }

        static string strInput(string message)
        {
            string value = "";
            bool isValid = false;
            do
            {
                Console.WriteLine(message);
                value = Console.ReadLine() ?? "";
                if (value != "")
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Valor invalido.\nIntente de nuevo");
                }

            } while (!isValid);
            return value;
        }

        static int integerInput(string message)
        {
            int value;
            bool isValid = false;
            do
            {
                Console.WriteLine(message);
                value = Convert.ToInt32(Console.ReadLine());
                if (value > 0)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Valor invalido.\nIntente de nuevo");
                }

            } while (!isValid);
            return value;
        }

        static string validateEnfermedad()
        {
            string _enfermedad = "";

            bool exists = false;

            while (!exists)
            {
                _enfermedad = strInput("Ingrese nombre de enfermedad");
                for (int i = 0; i < enfermedadesCount; i++)
                {
                    exists = enfermedades[i].nombreEnfermedad == _enfermedad;
                    if (exists)
                    {
                        break;
                    }
                }
                if (!exists)
                {
                    Console.WriteLine("Nombre de enfermedad invalida intente de nuevo.");
                    listEnfermedades();
                    Console.ReadLine();
                }
            }



            return _enfermedad;
        }

        static DateTime inputDate(String message)
        {
            DateTime fecha;
            bool isValid = false;
            do
            {
            string strFecha = strInput(message);
            isValid = DateTime.TryParse(strFecha, out fecha);
            if (!isValid)
            {
                Console.WriteLine("Fecha invalida. Intente de nuevo");
            }

            } while(!isValid);
            return fecha;
        }
        static void Main(string[] args)
        {
            llenaEnfermedades();
            llenaEspecialidades();
            showMenu();

        }
    }
}
