using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Program
    {
        static void Main(string[] args)
        {
            ML.Result result = new ML.Result();
            do
            {
                Console.WriteLine("\n\tElije una opción: ");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("1. Usuario");
                Console.WriteLine("2. Aseguradora");
                Console.WriteLine("3. Usuario EntityFramework");
                Console.WriteLine("4. Aseguradora EntityFramework");
                Console.WriteLine("5. Usuario LINQ");
                Console.WriteLine("6. Aseguradora LINQ");
                Console.WriteLine("*****************************************************");
                result.entidad = int.Parse(Console.ReadLine());
                Console.Clear();
                if (result.entidad == 1)
                {
                    Console.WriteLine("*****************************************************");
                    Console.WriteLine("\n\t1. Agregar Usuario: ");
                    Console.WriteLine("\n\t2. Actualizar Usuario: ");
                    Console.WriteLine("\n\t3. Eliminar Usuario: ");
                    Console.WriteLine("\n\t4. Consultar Usuarios: ");
                    Console.WriteLine("\n\t5. Consultar Usuario por Id: ");
                    Console.WriteLine("*****************************************************");
                    result.opcion = int.Parse(Console.ReadLine());
                    switch (result.opcion)
                    {
                        case 1:
                            Usuario.Add();
                            Console.ReadKey();
                            break;
                        case 2:
                            Usuario.Update();
                            Console.ReadKey();
                            break;
                        case 3:
                            Usuario.Delete();
                            Console.ReadKey();
                            break;
                        case 4:
                            Usuario.GetAll();
                            Console.ReadKey();
                            break;
                        case 5:
                            Usuario.GetById();
                            Console.ReadKey();
                            break;

                        default:
                            Console.WriteLine("No existe");
                            break;
                    }
                }
                else if (result.entidad == 2)
                {
                    Console.WriteLine("*****************************************************");
                    Console.WriteLine("\n\t1. Agregar Aseguradora: ");
                    Console.WriteLine("\n\t2. Actualizar Aseguradora: ");
                    Console.WriteLine("\n\t3. Eliminar Aseguradora: ");
                    Console.WriteLine("\n\t4. Consultar Aseguradora: ");
                    Console.WriteLine("\n\t5. Consultar Aseguradora por Id: ");
                    Console.WriteLine("*****************************************************");
                    result.opcion = int.Parse(Console.ReadLine());
                    switch (result.opcion)
                    {

                        case 1:
                            Aseguradora.Add();
                            Console.ReadKey();
                            break;
                        case 2:
                            Aseguradora.Update();
                            Console.ReadKey();
                            break;
                        case 3:
                            Aseguradora.Delete();
                            Console.ReadKey();
                            break;
                        case 4:
                            Aseguradora.GetAll();
                            Console.ReadKey();
                            break;
                        case 5:
                            Aseguradora.GetById();
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("No existe");
                            break;
                    }
                }
                else if (result.entidad == 3)
                {
                    Console.WriteLine("*****************************************************");
                    Console.WriteLine("\n\t1. Agregar Usuario: ");
                    Console.WriteLine("\n\t2. Actualizar Usuario: ");
                    Console.WriteLine("\n\t3. Eliminar Usuario: ");
                    Console.WriteLine("\n\t4. Consultar Usuarios: ");
                    Console.WriteLine("\n\t5. Consultar Usuario por Id: ");
                    Console.WriteLine("*****************************************************");
                    result.opcion = int.Parse(Console.ReadLine());
                    switch (result.opcion)
                    {
                        case 1:
                            Usuario.Add();
                            Console.ReadKey();
                            break;
                        case 2:
                            Usuario.Update();
                            Console.ReadKey();
                            break;
                        case 3:
                            Usuario.Delete();
                            Console.ReadKey ();
                            break;
                        case 4:
                            Usuario.GetAll();
                            Console.ReadKey();
                            break;
                        case 5:
                            Usuario.GetById();
                            Console.ReadKey();
                            break;
                    }
                }
                else if (result.entidad == 4)
                {
                    Console.WriteLine("*****************************************************");
                    Console.WriteLine("\n\t1. Agregar Aseguradora: ");
                    Console.WriteLine("\n\t2. Actualizar Aseguradora: ");
                    Console.WriteLine("\n\t3. Eliminar Aseguradora: ");
                    Console.WriteLine("\n\t4. Consultar Aseguradora: ");
                    Console.WriteLine("\n\t5. Consultar Aseguradora por Id: ");
                    Console.WriteLine("*****************************************************");
                    result.opcion = int.Parse(Console.ReadLine());
                    switch (result.opcion)
                    {
                        case 1:
                            Aseguradora.Add();
                            Console.ReadKey();
                            break;
                        case 2:
                            Aseguradora.Update();
                            Console.ReadKey();
                            break;
                        case 3:
                            Aseguradora.Delete();
                            Console.ReadKey();
                            break;
                        case 4:
                            Aseguradora.GetAll();
                            Console.ReadKey();
                            break;
                        case 5:
                            Aseguradora.GetById();
                            Console.ReadKey();
                            break;
                    }
                }
                else if (result.entidad == 5)
                {
                    Console.WriteLine("*****************************************************");
                    Console.WriteLine("\n\t1. Agregar Usuario: ");
                    Console.WriteLine("\n\t2. Actualizar Usuario: ");
                    Console.WriteLine("\n\t3. Eliminar Usuario: ");
                    Console.WriteLine("\n\t4. Consultar Usuario: ");
                    Console.WriteLine("\n\t5. Consultar Usuario por Id: ");
                    Console.WriteLine("*****************************************************");
                    result.opcion = int.Parse(Console.ReadLine());
                    switch (result.opcion)
                    {
                        case 1:
                            Usuario.Add();
                            Console.ReadKey();
                            break;
                        case 2:
                            Usuario.Update();
                            Console.ReadKey();
                            break;
                        case 3:
                            Usuario.Delete();
                            Console.ReadKey();
                            break;
                        case 4:
                            Usuario.GetAll();
                            Console.ReadKey();
                            break;
                        case 5:
                            Usuario.GetById();
                            Console.ReadKey();
                            break;
                    }
                }
                else if (result.entidad == 6)
                {
                    Console.WriteLine("*****************************************************");
                    Console.WriteLine("\n\t1. Agregar Aseguradora: ");
                    Console.WriteLine("\n\t2. Actualizar Aseguradora: ");
                    Console.WriteLine("\n\t3. Eliminar Aseguradora: ");
                    Console.WriteLine("\n\t4. Consultar Aseguradora: ");
                    Console.WriteLine("\n\t5. Consultar Aseguradora por Id: ");
                    Console.WriteLine("*****************************************************");
                    result.opcion = int.Parse(Console.ReadLine());
                    switch (result.opcion)
                    {
                        case 1:
                            Aseguradora.Add();
                            Console.ReadKey();
                            break;
                        case 2:
                            Aseguradora.Update();
                            Console.ReadKey();
                            break;
                        case 3:
                            Aseguradora.Delete();
                            Console.ReadKey();
                            break;
                        case 4:
                            Aseguradora.GetAll();
                            Console.ReadKey();
                            break;
                        case 5:
                            Aseguradora.GetById();
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto!");

                }
                Console.WriteLine("¿Desea continuar? S/N");
                result.pregunta = Console.ReadLine().ToUpper();
                Console.Clear();
            } while (result.pregunta == "S");   
        }
    }
}
