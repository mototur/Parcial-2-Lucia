using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
El siguiente programa lleva un control de empleados y los carga en memoria utilizando un List
el metodo cargar datos debe leer de un archivo llamado empleados.txt
el metodo guardar datos debe tomar los objetos del arreglo y guardarlos en el archivo.txt
la clase Empleado es base para EmpleadoPorHoras y EmpleadoTiempoCompleto
*/
namespace P2.Empleados
{
    internal class Program
    {
        static List<Empleado> empleados = new List<Empleado>();
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n1. Agregar empleado");
                Console.WriteLine("2. Listar empleados");
                Console.WriteLine("3. Calcular salario total");
                Console.WriteLine("4. Guardar datos");
                Console.WriteLine("5. Cargar datos");
                Console.WriteLine("6. Salir");
                Console.Write("Selecciona una opción: ");
                string Opcion = Console.ReadLine();

                switch (Opcion)
                {
                    case "1":
                        AgregarEmpleado();
                        break;
                    case "2":
                        ListarEmpleados();
                        break;
                    case "3":
                        CalcularSalarioTotal();
                        break;
                    case "4":
                        GuardarDatos();
                        break;
                    case "5":
                        CargarDatos();
                        break;
                    case "6":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
            }
        }

        static void AgregarEmpleado()
        {
            Console.WriteLine("\nAgregar empleado:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Tipo de empleado (1: Tiempo Completo, 2: Por Horas): ");
            string tipoEmpleado = Console.ReadLine();
            Console.Write("Salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            if (tipoEmpleado == "1")

            {
                empleados.Add(new EmpleadoTiempoCompleto(nombre, salario));
                
            }
            else if (tipoEmpleado == "2")
            {
                Console.Write("Horas trabajadas: ");
                int horasTrabajadas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Salario por hora: ");
                double salarioPorHora = Convert.ToDouble(Console.ReadLine());
                empleados.Add(new EmpleadoPorHoras(nombre, salarioPorHora, horasTrabajadas));
            }
            else
            {
                Console.WriteLine("Tipo de empleado no válido.");
            }
        }

        static void ListarEmpleados()
        {
            Console.WriteLine("\nLista de empleados:");
            foreach (var empleado in empleados)
            {
                Console.WriteLine(empleado);
            }
        }

        static void CalcularSalarioTotal()
        {
            double salarioTotal = 0;
            foreach (var empleado in empleados)
            {
                salarioTotal += empleado.CalcularSalario();
            }
            Console.WriteLine($"\nSalario total pagado a todos los empleados: {salarioTotal:C}");
        }

        static void GuardarDatos()
        {
            using (StreamWriter sw = new StreamWriter("empleados.txt"))
            {
                //implementar logica para guardar en un archivo
            }
            Console.WriteLine("\nDatos guardados en empleados.txt");
        }

        static void CargarDatos()
        {
            empleados.Clear(); // Limpiar la lista actual antes de cargar nuevos datos
            try
            {
                //implementar logica para leer los datos de un archivo
                Console.WriteLine("\nDatos cargados correctamente.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("\nEl archivo de datos no existe.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError al cargar datos: " + ex.Message);
            }
        }
    }

    // Clase base para representar un empleado
    class Empleado
    {
        public string Nombre { get; set; }
        public double Salario { get; set; }

        public Empleado(string nombre, double salario)
        {
            Nombre = nombre;
            Salario = salario;
        }

        public double CalcularSalario()
        {
            return Salario;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Salario: {Salario:C}";
        }
    }

    // Clase para representar un empleado a tiempo completo
    class EmpleadoTiempoCompleto : Empleado
    {
        public EmpleadoTiempoCompleto(string nombre, double salario) : base (nombre, salario)
        {
        }
    }

    // Clase para representar un empleado por horas
    class EmpleadoPorHoras : Empleado
    {
        public int HorasTrabajadas { get; set; }
        public double SalarioPorHora { get; set; }

        public EmpleadoPorHoras(string nombre, double salarioPorHora, int horasTrabajadas) : base(nombre, 0)
        {
            SalarioPorHora = salarioPorHora;
            HorasTrabajadas = horasTrabajadas;
        }

        public virtual double CalcularSalario()
        {
            return SalarioPorHora * HorasTrabajadas;
        }

        public override string ToString()
        {
            return base.ToString() + $", Horas trabajadas: {HorasTrabajadas}, Salario por hora: {SalarioPorHora:C}";
        }
    }

}
    

