using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        public static void Add()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingrese el Nombre de Usuario");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingrese el Nombre ");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el Apellido Paterno ");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingrese el Apellido Materno ");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingrese el Email ");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingrese su Sexo ");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingrese el Teléfono ");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingrese el número de Celular ");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Ingrese fecha de nacimiento");
            usuario.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Ingrese su CURP ");
            usuario.Curp = Console.ReadLine();



            //ML.Result result = BL.Usuario.SPAdd(usuario);
            //ML.Result result = BL.Usuario.AddEF(usuario);
            ML.Result result = BL.Usuario.AddLINQ(usuario);


            if (result.Correct)
            {
                Console.WriteLine("El usuario se ha agregado");
            }
            else
            {
                Console.WriteLine("El usuario no se pudo agregar " + result.ErrorMessage);
            }
        }

        public static void Update()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingrese el Id de Usuario para actualizar");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Nombre de Usuario");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingrese el Nombre ");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el Apellido Paterno ");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingrese el Apellido Materno ");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingrese el Email ");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingrese su Sexo ");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingrese el Teléfono ");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingrese el número de Celular ");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Ingrese fecha de nacimiento");
            usuario.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Ingrese su CURP ");
            usuario.Curp = Console.ReadLine();


            //ML.Result result = BL.Usuario.SPUpdate(usuario);
            //ML.Result result = BL.Usuario.UpdateEF(usuario);
            ML.Result result = BL.Usuario.UpdateLINQ(usuario);

            if (result.Correct)
            {
                Console.WriteLine("El usuario se ha actualizado");
            }
            else
            {
                Console.WriteLine("La información del usuario no se pudo actualizar " + result.ErrorMessage);
            }
        }

        public static void Delete()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingrese el Id de Usuario a eliminar");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            //ML.Result result = BL.Usuario.SPDelete(usuario);
            //ML.Result result = BL.Usuario.DeleteEF(usuario);
            ML.Result result = BL.Usuario.DeleteLINQ(usuario);

            if (result.Correct)
            {
                Console.WriteLine("El usuario se ha eliminado");
            }
            else
            {
                Console.WriteLine("El usuario no se pudo eliminar " + result.ErrorMessage);
            }
        }

        public static void GetAll()
        {
            //ML.Result result = BL.Usuario.SPGetAll();
            //ML.Result result = BL.Usuario.GetAll();
            //ML.Result result = BL.Usuario.GetAllEF();
            ML.Result result = BL.Usuario.GetAllLINQ();

            if (result.Correct)
            {
                foreach (ML.Usuario usuario in result.Objects)
                {
                    Console.WriteLine("\t");
                    Console.WriteLine("***************************************************");
                    Console.WriteLine("\tIdUsuario: " + usuario.IdUsuario);
                    Console.WriteLine("\tUserName: " + usuario.UserName);
                    Console.WriteLine("\tNombre: " + usuario.Nombre);
                    Console.WriteLine("\tApellidoPaterno :" + usuario.ApellidoPaterno);
                    Console.WriteLine("\tApellidoMaterno :" + usuario.ApellidoMaterno);
                    Console.WriteLine("\tEmail :" + usuario.Email);
                    Console.WriteLine("\tSexo :" + usuario.Sexo);
                    Console.WriteLine("\tTelefono :" + usuario.Telefono);
                    Console.WriteLine("\tCelular :" + usuario.Celular);
                    Console.WriteLine("\tFechaNacimiento :" + usuario.FechaNacimiento);
                    Console.WriteLine("\tCURP :" + usuario.Curp);
                    Console.WriteLine("***************************************************");
                    Console.WriteLine("\n\n");
                }
                //Console.WriteLine(result.Objects);
            }
            else
            {
                Console.WriteLine("No se pudo traer la información de los Usuarios " + result.ErrorMessage);
            }
        }

        public static void GetById()
        {

            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingrese el Id de Usuario a mostrar");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            //ML.Result result = BL.Usuario.SPGetId(usuario);
            //ML.Result result = BL.Usuario.GetById(usuario.IdUsuario);
            //ML.Result result = BL.Usuario.GetByIdEF(usuario.IdUsuario);
            ML.Result result = BL.Usuario.GetByIdLINQ(usuario.IdUsuario);

            if (result.Correct)
            {
                Console.WriteLine("IdUsuario:" + ((ML.Usuario)result.Object).IdUsuario);
                Console.WriteLine("UserName :" + ((ML.Usuario) result.Object).UserName);
                Console.WriteLine("Nombre :" + ((ML.Usuario) result.Object).Nombre);
                Console.WriteLine("ApellidoPaterno :" + ((ML.Usuario)result.Object).ApellidoPaterno);
                Console.WriteLine("Apellido Materno :" + ((ML.Usuario)result.Object).ApellidoMaterno);
                Console.WriteLine("Email :" + ((ML.Usuario)result.Object).Email);
                Console.WriteLine("Sexo :" + ((ML.Usuario)result.Object).Sexo);
                Console.WriteLine("Telefono :" + ((ML.Usuario)result.Object).Telefono);
                Console.WriteLine("Celular :" + ((ML.Usuario)result.Object).Celular);
                Console.WriteLine("FechaNacimiento :" + ((ML.Usuario)result.Object).FechaNacimiento);
                Console.WriteLine("CURP :" + ((ML.Usuario)result.Object).Curp);

            }
            else
            {
                Console.WriteLine("No se pudo traer la información del usuario " + result.ErrorMessage);
            }
        }
    }
}
