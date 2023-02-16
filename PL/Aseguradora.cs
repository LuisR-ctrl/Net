using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Aseguradora
    {
        public static void Add()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            Console.WriteLine("Ingrese el Nombre de la Aseguradora");
            aseguradora.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el Id de Usuario");
            aseguradora.Usuario.IdUsuario = int.Parse(Console.ReadLine());

            //ML.Result result = BL.Aseguradora.SPAdd(aseguradora);
            //ML.Result result = BL.Aseguradora.AddEF(aseguradora);
            ML.Result result = BL.Aseguradora.AddLINQ(aseguradora);

            if (result.Correct)
            {
                Console.WriteLine("La aseguradora se ha agregado");
            }
            else
            {
                Console.WriteLine("La información de la aseguradora no se pudo agregar " + result.ErrorMessage);
            }

        }

        public static void GetAll()
        {
            //ML.Result result= BL.Aseguradora.SPGetAll();
            ML.Result result = BL.Aseguradora.GetAllEF();
            //ML.Result result = BL.Aseguradora.GetAllLINQ();
            if (result.Correct)
            {
                foreach (ML.Aseguradora aseguradora in result.Objects)
                {
                    Console.WriteLine("\t");
                    Console.WriteLine("***************************************************");
                    Console.WriteLine("\tIdAseguradora :" + aseguradora.IdAseguradora);
                    Console.WriteLine("\tNombre :" + aseguradora.Nombre);
                    Console.WriteLine("\tFechaCreacion :" + aseguradora.FechaCreacion);
                    Console.WriteLine("\tFechaModificacion :" + aseguradora.FechaModificacion);
                    Console.WriteLine("\tIdUsuario :" + aseguradora.Usuario.IdUsuario);
                    Console.WriteLine("***************************************************");
                    Console.WriteLine("\n\n");
                }
            }
            else
            {
                Console.WriteLine("La información de las aseguradoras no se pudo mostrar " + result.ErrorMessage);
            }
        }

        public static void GetById()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            Console.WriteLine("Ingrese el Id de la Aseguradora a consultar");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());

            //ML.Result result = BL.Aseguradora.SPGetById(aseguradora.IdAseguradora);
            //ML.Result result = BL.Aseguradora.GetByIdEF(aseguradora.IdAseguradora);
            ML.Result result = BL.Aseguradora.GetByIdLINQ(aseguradora.IdAseguradora);

            if (result.Correct)
            {
                Console.WriteLine("IdAseguradora :" + ((ML.Aseguradora)result.Object).IdAseguradora);
                Console.WriteLine("Nombre :" + ((ML.Aseguradora)result.Object).Nombre);
                Console.WriteLine("FechaCreación :" + ((ML.Aseguradora)result.Object).FechaCreacion);
                Console.WriteLine("FechaModificación :" + ((ML.Aseguradora)result.Object).FechaModificacion);
                Console.WriteLine("IdUsuario :" + ((ML.Aseguradora)result.Object).Usuario.IdUsuario);

            }
            else
            {
                Console.WriteLine("No se pudo traer la información de la aseguradora " + result.ErrorMessage);
            }
        }

        public static void Update()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            Console.WriteLine("Ingrese el Id de la aseguradora que desea actualizar");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre de la aseguradora para actualizar");
            aseguradora.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el Id de Usuario");
            aseguradora.Usuario.IdUsuario = int.Parse(Console.ReadLine());

            //ML.Result result = BL.Aseguradora.SPUpdate(aseguradora);
            //ML.Result result = BL.Aseguradora.UpdateEF(aseguradora);
            ML.Result result = BL.Aseguradora.UpdateLINQ(aseguradora);

            if (result.Correct)
            {
                Console.WriteLine("La aseguradora se ha actualizado");
            }
            else
            {
                Console.WriteLine("La información de la aseguradora no se pudo actualizar " + result.ErrorMessage);
            }
        }

        public static void Delete()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            Console.WriteLine("Escriba el Id de la Aseguradora que desea eliminar");
            aseguradora.IdAseguradora=int.Parse(Console.ReadLine());

            //ML.Result result = BL.Aseguradora.SPDelete(aseguradora);
            //ML.Result result = BL.Aseguradora.DeleteEF(aseguradora);
            ML.Result result = BL.Aseguradora.DeleteLINQ(aseguradora);

            if (result.Correct)
            {
                Console.WriteLine("La aseguradora se ha eliminado");
            }
            else
            {
                Console.WriteLine("La información de la aseguradora no se pudo eliminar " + result.ErrorMessage);
            }
        }
    }
}
