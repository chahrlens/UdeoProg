using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace ControlVehiculos
{
    internal class Program
    {
        struct Vehiculo
        {
            public string matricula;
            public string marca;
            public string linea;
            public int modelo;
            public string color;
            public string peso;
            public string motor;
            public string tipoCaja;
            public string tipoCombustible;
        }

        static List<Vehiculo> vehiculos = new List<Vehiculo>();
        static List<string> marcas = new List<string>() { "Mazda", "Toyota", "Honda", "Mitsubishi", "Subaru", "Izusu" };
        static List<string> combustibles = new List<string>() { "Gasolina", "Diesel", "Gas LP", "Hibrido" };
        static List<string> cajas = new List<string>() { "Mecanica", "Automatica", "Trip Tonic" };
        static string fileUrl = "C:\\pruebas\\vehiculos.txt";

        static void Main(string[] args)
        {

/*            Vehiculo v1 = new Vehiculo() ;

            v1.matricula = "P-123ABA";
            v1.marca = "Mazda";
            v1.linea = "Protege";
            v1.modelo = 1995;
            v1.color = "Verde";
            v1.peso = "1.5";
            v1.motor =  "1.5";
            v1.tipoCaja = "Mecanica";
            v1.tipoCombustible = "Gasolina";
            vehiculos.Add(v1);

            Vehiculo v2 = new Vehiculo() ;
            v2.matricula = "P-321ABB";
            v2.marca = "Mazda";
            v2.linea = "3";
            v2.modelo = 2016;
            v2.color = "Gris";
            v2.peso = "0.5";
            v2.motor = "1.5";
            v2.tipoCaja = "Trip Tonic";
            v2.tipoCombustible = "Gasolina";
            vehiculos.Add (v2);

            Vehiculo v3 = new Vehiculo();

            v3.matricula = "P-432ABC";
            v3.marca = "Honda";
            v3.linea = "Element";
            v3.modelo = 2008;
            v3.color = "Gris";
            v3.peso = "1.5";
            v3.motor = "1.5";
            v3.tipoCaja = "Automatica";
            v3.tipoCombustible = "Gasolina";
            vehiculos.Add(v3 );

            Vehiculo v4 = new Vehiculo() ;

            v4.matricula = "P-765ABD";
            v4.marca = "Toyota";
            v4.linea = "Hilux";
            v4.modelo = 2022;
            v4.color = "Rojo";
            v4.peso = "1";
            v4.motor = "1.5";
            v4.tipoCaja = "Automatica";
            v4.tipoCombustible = "Diesel";
            vehiculos.Add(v4);*/

            leerArchivo();

            bool exit = false;
            do
            {
                Console.Clear();
                int op = showMenu();
                switch (op)
                {
                    case 1:
                        {
                            agregar();
                            break;
                        }
                    case 2:
                        {
                            editar();
                            break;
                        }
                    case 3:
                        {
                            eliminarVeiculo();
                            break;
                        }
                    case 4:
                        {
                            listaVechiulos();
                            break;
                        }
                    case 5:
                        {
                            ordernar();
                            break;
                        }
                    case 6:
                        {
                            mostrarMarcas();
                            break;
                        }
                    case 7:
                        {
                            mostrarCajas();
                            break;
                        }
                    case 8:
                        {
                            mostrarCombustible();
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Saliendo");
                            guardarArchivo();
                            exit = true;
                            break;
                        }
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadLine();
            } while (!exit);
        }

        static int showMenu()
        {
            
            int option;
            Console.WriteLine("Menu vehiculos");
            Console.WriteLine("1. Ingreso de Vehículo");
            Console.WriteLine("2. Editar datos Vehículo");
            Console.WriteLine("3. Eliminar Vehículo");
            Console.WriteLine("4. Listado de Vehículos.");
            Console.WriteLine("5. Ordenar Vehículos por.");
            Console.WriteLine("6. Cantidad de vehiculos por marca.");
            Console.WriteLine("7. Cantidad de vehiculos por tipo de caja.");
            Console.WriteLine("8. cantidad de vehiculos por tigo de combustible.");
            Console.WriteLine("9. Salir");

            option = validateInteger("Seleccione una opcion:");

            return option;

        }

        static int validateInteger(string message)
        {
            int result;
            Console.WriteLine(message);
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out result))
                {
                    break;
                }
                Console.WriteLine("Numero invalido intente de nuevo.");
                Console.WriteLine(message);
            }

            return result;
        }
        static string validateString(string message)
        {
            string result;
            Console.WriteLine(message);
            while (true)
            {
                result = Console.ReadLine();
                if (result != "")
                {
                    break;
                }
                Console.WriteLine("Ingreso invalido, intente de nuevo.");
                Console.WriteLine(message);
            }

            return result;
        }

        static void agregar()
        {
            Vehiculo vehiculo = new Vehiculo();

            vehiculo.matricula = validateString("Ingrese numero matricula:");
            vehiculo.marca = selecMarca();
            vehiculo.linea = validateString("Ingrese linea: ");
            vehiculo.modelo = validateInteger("Ingrese modelo: ");
            vehiculo.color = validateString("Ingrese color");
            vehiculo.peso = validateString("Ingrese peso");
            vehiculo.motor = validateString("Ingrese motor:");
            vehiculo.tipoCaja = selecCaja();
            vehiculo.tipoCombustible = selecGasolina();
            vehiculos.Add(vehiculo);
        }

        static void editar()
        {
            string matricula = validateString("Ingrese matricula");
            var pos = vehiculos.FindIndex(e => e.matricula.Equals(matricula));
            
           if (pos > -1)
            {
                Vehiculo v = vehiculos[pos];
                Console.WriteLine("Matricula: " + v.matricula);
                Console.WriteLine("Marca: " + v.marca);
                Console.WriteLine("Linea: " + v.linea);
                Console.WriteLine("Modelo: " + v.modelo);
                Console.WriteLine("Color: " + v.color);
                Console.WriteLine("Peso: " + v.peso);
                Console.WriteLine("Motor: " + v.motor);
                Console.WriteLine("Tipo de caja: " + v.tipoCaja);
                Console.WriteLine("Tipo de combustible: " + v.tipoCombustible);
                Console.WriteLine("\n\n");

                Vehiculo vehiculo = new Vehiculo();

                vehiculo.matricula = validateString("Ingrese numero matricula:");
                vehiculo.marca = selecMarca();
                vehiculo.linea = validateString("Ingrese linea: ");
                vehiculo.modelo = validateInteger("Ingrese modelo: ");
                vehiculo.color = validateString("Ingrese color");
                vehiculo.peso = validateString("Ingrese peso");
                vehiculo.motor = validateString("Ingrese motor:");
                vehiculo.tipoCaja = selecCaja();
                vehiculo.tipoCombustible = selecGasolina();
                vehiculos[pos] = vehiculo;
            } else
            {
                Console.WriteLine("Elemento no encontrado");
            }
        }

        static void eliminarVeiculo()
        {
            string matricula = validateString("Ingrese matricula");
            var pos = vehiculos.FindIndex(e => e.matricula.Equals(matricula));

            if (pos > -1)
            {
                Vehiculo v = vehiculos[pos];
                Console.WriteLine("Matricula: " + v.matricula);
                Console.WriteLine("Marca: " + v.marca);
                Console.WriteLine("Linea: " + v.linea);
                Console.WriteLine("Modelo: " + v.modelo);
                Console.WriteLine("Color: " + v.color);
                Console.WriteLine("Peso: " + v.peso);
                Console.WriteLine("Motor: " + v.motor);
                Console.WriteLine("Tipo de caja: " + v.tipoCaja);
                Console.WriteLine("Tipo de combustible: " + v.tipoCombustible);
                Console.WriteLine("\n\n");

                vehiculos.RemoveAt(pos);
                Console.WriteLine("Vehiculo eliminado");
            }
            else
            {
                Console.WriteLine("Elemento no encontrado");
            }
        }
        static void listaVechiulos()
        {
            int cout = 1;
            foreach (var v in  vehiculos)
            {
                Console.WriteLine("\n\n" + cout);
                Console.WriteLine("Matricula: " + v.matricula);
                Console.WriteLine("Marca: " + v.marca);
                Console.WriteLine("Linea: " + v.linea);
                Console.WriteLine("Modelo: " + v.modelo);
                Console.WriteLine("Color: " + v.color);
                Console.WriteLine("Peso: " + v.peso);
                Console.WriteLine("Motor: " + v.motor);
                Console.WriteLine("Tipo de caja: " + v.tipoCaja);
                Console.WriteLine("Tipo de combustible: " + v.tipoCombustible);
                Console.WriteLine("\n\n");
                cout++;

            }
        }

        static void ordernar()
        {
            Console.WriteLine("Ordernar por:");
            Console.WriteLine("1 - Mdelo");
            Console.WriteLine("2 - Peso");
            int op = validateInteger("Ingrese una opcion: ");
            if (op > 0 && op < 3)
            {
                switch (op)
                {
                    case 1:
                        {
                            var order = vehiculos.OrderBy(e => e.modelo);
                            vehiculos.Clear();
                            vehiculos.AddRange(order);
                            break;
                        }
                    case 2:
                        {
                            var order = vehiculos.OrderBy(e => e.peso);
                            vehiculos.Clear();
                            vehiculos.AddRange(order);
                            break;
                        }
                }
            } else
            {
                Console.WriteLine("Opcion invalida");
            }
        }

        static string selecMarca()
        {
            string marca = "";
            int cout = 0;
            Console.WriteLine("\nMarca del vehiculo:\n");
            Console.WriteLine("0 - Agregar nueva marca: ");
            foreach (var m in marcas)
            {
                Console.WriteLine((cout + 1) + " - " + m);
                cout++;
            }
            int op;
            bool exit = false;
            do
            {
                op = validateInteger("Seleccione marca:");
                if (op > 0 && op <= marcas.Count)
                {
                    marca = marcas[op-1];
                    exit = true;
                } else if (op == 0)
                {
                    string nuevaMarca = validateString("Ingrese nueva marca");
                    marcas.Add(nuevaMarca);
                    marca = nuevaMarca;
                    exit = true;
                } 
                else
                {
                    Console.WriteLine("Opcion invalida");
                }

            } while (!exit);
            return marca;
        }

        static string selecGasolina()
        {
            string tipo = "";
            int cout = 0;
            Console.WriteLine("\nCombustible del vehiculo:\n");
            foreach (var m in combustibles)
            {
                Console.WriteLine((cout + 1) + " - " + m);
                cout++;
            }
            int op;
            bool exit = false;
            do
            {
                op = validateInteger("Seleccione combustible:");
                if (op > 0 && op <= combustibles.Count)
                {
                    tipo = combustibles[op - 1];
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Opcion invalida");
                }

            } while (!exit);
            return tipo;
        }

        static string selecCaja()
        {
            string tipo = "";
            int cout = 0;
            Console.WriteLine("\nTipo de caja del vehiculo:\n");
            foreach (var m in cajas)
            {
                Console.WriteLine((cout + 1) + " - " + m);
                cout++;
            }
            int op;
            bool exit = false;
            do
            {
                op = validateInteger("Seleccione tipo caja:");
                if (op > 0 && op <= cajas.Count)
                {
                    tipo = cajas[op - 1];
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Opcion invalida");
                }

            } while (!exit);
            return tipo;
        }
        
        static void mostrarMarcas()
        {
            Console.WriteLine("Cantidad de Vehículos por Marca");
            List<string> result = new List<string>();
            foreach (var item in marcas)
            {
                var values = vehiculos.Where(e => e.marca.Equals(item));

                int count = values.Count();
                if (count > 0)
                {
                    result.Add(item + " -- " + count);

                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static void mostrarCajas()
        {
            Console.WriteLine("Cantidad de Vehículos por Tipo de caja");
            List<string> result = new List<string>();
            foreach (var item in cajas)
            {
                var values = vehiculos.Where(e => e.tipoCaja.Equals(item));

                int count = values.Count();
                if (count > 0)
                {
                    result.Add(item + " -- " + count);

                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static void mostrarCombustible()
        {
            Console.WriteLine("Cantidad de Vehículos por tipo de Combustible");
            List<string> result = new List<string>();
            foreach (var item in combustibles)
            {
                var values = vehiculos.Where(e => e.tipoCombustible.Equals(item));

                int count = values.Count();
                if (count > 0)
                {
                    result.Add(item + " -- " + count);

                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        static void guardarArchivo()
        {
            try
            {
                StreamWriter writer = new StreamWriter(fileUrl);
                foreach (var v in vehiculos)
                {
                    string linea = v.matricula + "," + v.marca + "," + v.linea + "," + v.modelo + "," + v.color + "," + v.peso + "," + v.motor + "," + v.tipoCaja + "," + v.tipoCombustible;
                    writer.WriteLine(linea);

                }


                writer.Close();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static void leerArchivo()
        {
            try
            {
                StreamReader reader = new StreamReader(fileUrl);

                var linea = reader.ReadLine();
                while (linea != null)
                {
                    Console.WriteLine(linea);
                    linea = reader.ReadLine();
                    Console.WriteLine( "-" + linea);
                    if (linea != null)
                    {
                        string[] element = linea.Split(',');
                        Vehiculo vehiculo = new Vehiculo();

                        vehiculo.matricula = element[0];
                        vehiculo.marca = element[1];
                        vehiculo.linea = element[2];
                        vehiculo.modelo = Convert.ToInt32(element[3]);
                        vehiculo.color = element[4];
                        vehiculo.peso = element[5];
                        vehiculo.motor = element[6];
                        vehiculo.tipoCaja = element[7];
                        vehiculo.tipoCombustible = element[8];
                        vehiculos.Add(vehiculo);
                    }

                }
                reader.Close();
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
