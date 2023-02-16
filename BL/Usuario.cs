using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;

namespace BL
{
    public class Usuario
    {
        /*public static ML.Result Add(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "INSERT INTO Usuario ([Nombre], [Edad] ,[FechaNacimiento] ,[Domicilio]) VALUES (@Nombre, @Edad, CONVERT(DATE, @Fecha,105), @Domicilio )";
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        cmd.CommandText = query;
                        cmd.Connection = context;

                        SqlParameter[] parameter = new SqlParameter[4];

                        parameter[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                        parameter[0].Value = usuario.Nombre;

                        parameter[1] = new SqlParameter("@Edad", SqlDbType.TinyInt);
                        parameter[1].Value = usuario.Edad;

                        parameter[2] = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
                        parameter[2].Value = usuario.FechaNacimiento;

                        parameter[3] = new SqlParameter("@Domicilio", SqlDbType.VarChar);
                        parameter[3].Value = usuario.Domicilio;
                        SqlCommand command = new SqlCommand(query, context);
                        cmd.Parameters.AddRange(parameter);
                        cmd.Connection.Open();

                        int RowsAffected = cmd.ExecuteNonQuery();

                        if (RowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }*/
        public static ML.Result SPAdd(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context  = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "UsuarioAdd";
                    using (SqlCommand cmd = new SqlCommand()) 
                    {

                     cmd.CommandText = query;
                     cmd.Connection = context;
                     cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] parameter = new SqlParameter[10];

                        parameter[0] = new SqlParameter("@UserName", SqlDbType.VarChar);
                        parameter[0].Value = usuario.UserName;

                        parameter[1] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                        parameter[1].Value = usuario.Nombre;

                        parameter[2] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
                        parameter[2].Value = usuario.ApellidoPaterno;

                        parameter[3] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
                        parameter[3].Value = usuario.ApellidoMaterno;

                        parameter[4] = new SqlParameter("@Email", SqlDbType.VarChar);
                        parameter[4].Value = usuario.Email;

                        parameter[5] = new SqlParameter("@Sexo", SqlDbType.Char);
                        parameter[5].Value = usuario.Sexo;

                        parameter[6] = new SqlParameter("@Telefono", SqlDbType.VarChar);
                        parameter[6].Value = usuario.Telefono;

                        parameter[7] = new SqlParameter("@Celular", SqlDbType.VarChar);
                        parameter[7].Value = usuario.Celular;

                        parameter[8] = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
                        parameter[8].Value = usuario.FechaNacimiento;

                        parameter[9] = new SqlParameter("@Curp", SqlDbType.VarChar);
                        parameter[9].Value = usuario.Curp;

                        SqlCommand command = new SqlCommand(query, context);
                        cmd.Parameters.AddRange(parameter);
                        cmd.Connection.Open();

                        int RowsAffected = cmd.ExecuteNonQuery();

                        if (RowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result SPUpdate(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "UsuarioUpdate";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] parameter = new SqlParameter[11];

                        parameter[0] = new SqlParameter("@idUsuario", SqlDbType.Int);
                        parameter[0].Value = usuario.IdUsuario;

                        parameter[1] = new SqlParameter("@UserName", SqlDbType.VarChar);
                        parameter[1].Value = usuario.UserName;

                        parameter[2] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                        parameter[2].Value = usuario.Nombre;

                        parameter[3] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
                        parameter[3].Value = usuario.ApellidoPaterno;

                        parameter[4] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
                        parameter[4].Value = usuario.ApellidoMaterno;

                        parameter[5] = new SqlParameter("@Email", SqlDbType.VarChar);
                        parameter[5].Value = usuario.Email;

                        parameter[6] = new SqlParameter("@Sexo", SqlDbType.Char);
                        parameter[6].Value = usuario.Sexo;

                        parameter[7] = new SqlParameter("@Telefono", SqlDbType.VarChar);
                        parameter[7].Value = usuario.Telefono;

                        parameter[8] = new SqlParameter("@Celular", SqlDbType.VarChar);
                        parameter[8].Value = usuario.Celular;

                        parameter[9] = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
                        parameter[9].Value = usuario.FechaNacimiento;

                        parameter[10] = new SqlParameter("@Curp", SqlDbType.VarChar);
                        parameter[10].Value = usuario.Curp;

                        SqlCommand command = new SqlCommand(query, context);
                        cmd.Parameters.AddRange(parameter);
                        cmd.Connection.Open();

                        int RowsAffected = cmd.ExecuteNonQuery();

                        if (RowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }


                    }
                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }
            return result;
        }

        public static ML.Result Update(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "UPDATE Usuario SET [Nombre]= @Nombre ,[Edad] = @Edad ,[FechaNacimiento] = CONVERT(DATE, @Fecha,105) ,[Domicilio] = @Domicilio WHERE [IdUsuario] =  @idUsuario";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;

                        SqlParameter[] parameter = new SqlParameter[5];

                        parameter[0] = new SqlParameter("@idUsuario", SqlDbType.Int);
                        parameter[0].Value = usuario.IdUsuario;

                        parameter[1] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                        parameter[1].Value = usuario.Nombre;

                       /* parameter[2] = new SqlParameter("@Edad", SqlDbType.TinyInt);
                        parameter[2].Value = usuario.Edad;*/

                        parameter[3] = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
                        parameter[3].Value = usuario.FechaNacimiento;

                        /*parameter[4] = new SqlParameter("@Domicilio", SqlDbType.VarChar);
                        parameter[4].Value = usuario.Domicilio;*/
                        SqlCommand command = new SqlCommand(query, context);
                        cmd.Parameters.AddRange(parameter);
                        cmd.Connection.Open();

                        int RowsAffected = cmd.ExecuteNonQuery();

                        if (RowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }


                    }
                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }
            return result;
        }

        public static ML.Result SPDelete(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "UsuarioDelete";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] parameter = new SqlParameter[1];

                        parameter[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
                        parameter[0].Value = usuario.IdUsuario;
                        SqlCommand command = new SqlCommand(query, context);
                        cmd.Parameters.AddRange(parameter);
                        cmd.Connection.Open();

                        int RowsAffected = cmd.ExecuteNonQuery();

                        if (RowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result Delete(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "DELETE FROM [Usuario] WHERE IdUsuario = @idUsuario";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;

                        SqlParameter[] parameter = new SqlParameter[1];

                        parameter[0] = new SqlParameter("@idUsuario", SqlDbType.Int);
                        parameter[0].Value = usuario.IdUsuario;
                        SqlCommand command = new SqlCommand(query, context);
                        cmd.Parameters.AddRange(parameter);
                        cmd.Connection.Open();

                        int RowsAffected = cmd.ExecuteNonQuery();

                        if (RowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result SPGetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "MostrarUsuarios";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlCommand command = new SqlCommand(query, context);
                        cmd.Connection.Open();
                        int RowsAffected = cmd.ExecuteNonQuery();

                        if (RowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine("\t{0}\t{1}\t{2}",
                                reader[0], reader[1], reader[2]);
                        }
                        reader.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result SPGetId(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "MostrarUsuario";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] parameter = new SqlParameter[1];

                        parameter[0] = new SqlParameter("@idUsuario", SqlDbType.Int);
                        parameter[0].Value = usuario.IdUsuario;

                        cmd.Parameters.AddRange(parameter);
                        cmd.Connection.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        

                        while (reader.Read())
                        {
                            Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}",
                                reader[0], reader[1], reader[2], reader[3], reader[4]);
                        }
                        reader.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "SELECT * FROM Usuario";
                    //string query = "UsuarioGetAll";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        //cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection.Open();

                        DataTable usuarioTable = new DataTable();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        da.Fill(usuarioTable);

                        if (usuarioTable.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();

                            foreach (DataRow row in usuarioTable.Rows)
                            {
                                ML.Usuario usuario = new ML.Usuario();
                                usuario.IdUsuario = int.Parse(row[0].ToString());
                                usuario.UserName = row[1].ToString();
                                usuario.Nombre = row[2].ToString();
                                usuario.ApellidoPaterno = row[3].ToString();
                                usuario.ApellidoMaterno = row[4].ToString();
                                usuario.Email = row[5].ToString();
                                usuario.Sexo = row[6].ToString();
                                usuario.Telefono = row[7].ToString();
                                usuario.Celular = row[8].ToString();
                                usuario.FechaNacimiento = row[9].ToString();
                                usuario.Curp = row[10].ToString();
                                result.Objects.Add(usuario);
                            }
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "Ocurrió un error al momento de traer los datos de los Usuarios";

                        }
                        cmd.Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetById(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "UsuarioGetById";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] parameter = new SqlParameter[1];

                        parameter[0] = new SqlParameter("IdUsuario", SqlDbType.Int);
                        parameter[0].Value = IdUsuario;

                        cmd.Parameters.AddRange(parameter);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable tableUsuario = new DataTable();
                            da.Fill(tableUsuario);
                            cmd.Connection.Open();

                            if (tableUsuario.Rows.Count > 0)
                            {
                                result.Objects = new List<object>();
                                DataRow row = tableUsuario.Rows[0];

                                ML.Usuario usuario = new ML.Usuario();

                                usuario.IdUsuario = int.Parse(row[0].ToString());
                                usuario.UserName = row[1].ToString();
                                usuario.Nombre = row[2].ToString();
                                usuario.ApellidoPaterno = row[3].ToString();
                                usuario.ApellidoMaterno = row[4].ToString();
                                usuario.Email = row[5].ToString();
                                usuario.Sexo = row[6].ToString();
                                usuario.Telefono = row[7].ToString();
                                usuario.Celular = row[8].ToString();
                                usuario.FechaNacimiento = row[9].ToString();
                                usuario.Curp = row[10].ToString();

                                result.Object = usuario;
                                result.Correct = true;
                            }
                            else
                            {
                                result.Correct = false;
                                result.ErrorMessage = "No se encontró al Usuario";

                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result AddEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = context.UsuarioAdd(usuario.UserName, usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Email, usuario.Sexo, usuario.Telefono, usuario.Celular, DateTime.Parse(usuario.FechaNacimiento), usuario.Curp, usuario.Imagen, usuario.Rol.IdRol, usuario.Password, usuario.Direccion.Calle, usuario.Direccion.NumeroInterior, usuario.Direccion.NumeroExterior, 1);

                    if(query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo registrar al Usuario";
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public static ML.Result UpdateEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = context.UsuarioUpdate(usuario.IdUsuario,usuario.UserName, usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Email, usuario.Sexo, usuario.Telefono, usuario.Celular, DateTime.Parse(usuario.FechaNacimiento), usuario.Curp,usuario.Imagen, usuario.Rol.IdRol, usuario.Estatus, usuario.Password, usuario.Direccion.Calle, usuario.Direccion.NumeroInterior, usuario.Direccion.NumeroExterior, 1);

                    if(query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo actualizar el Usuario";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;

            }
            return result;
        }

        public static ML.Result DeleteEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = context.UsuarioDelete(usuario.IdUsuario, usuario.Direccion.IdDireccion);

                    if(query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se eliminó al Usuario";
                    }
                    result.Correct = true;
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result GetAllEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = context.UsuarioGetAll(usuario.Nombre, usuario.ApellidoPaterno, usuario.UserName).ToList();

                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach(var obj in query)
                        {
                            usuario = new ML.Usuario();
                            usuario.IdUsuario = obj.IdUsuario;
                            usuario.UserName = obj.UserName;
                            usuario.Nombre = obj.Nombre;
                            usuario.ApellidoPaterno = obj.ApellidoPaterno;
                            usuario.ApellidoMaterno = obj.ApellidoMaterno;
                            usuario.Email = obj.Email;
                            usuario.Sexo = obj.Sexo;
                            usuario.Telefono = obj.Telefono;
                            usuario.Celular = obj.Celular;
                            usuario.FechaNacimiento = obj.FechaNacimiento?.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                            usuario.Curp = obj.Curp;
                            usuario.Imagen = obj.Imagen;
                            usuario.Estatus = (bool)obj.Estatus;
                            usuario.Password = obj.Password;

                            usuario.Rol = new ML.Rol();
                            usuario.Rol.IdRol = obj.IdRol;
                            usuario.Rol.Nombre = obj.RolNombre;

                            result.Objects.Add(usuario);

                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct=false;
                        result.ErrorMessage = "No se encontraron registros";
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;

            }
            return result ;
        }

        public static ML.Result GetByIdEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {

                    var query = context.UsuarioGetById(IdUsuario).FirstOrDefault();

                    result.Objects = new List<object>();
                    if (query != null)
                    {
                        ML.Usuario usuario = new ML.Usuario();
                        usuario.IdUsuario = query.IdUsuario;
                        usuario.UserName = query.UserName;
                        usuario.Nombre = query.Nombre;
                        usuario.ApellidoPaterno = query.ApellidoPaterno;
                        usuario.ApellidoMaterno = query.ApellidoMaterno;
                        usuario.Email = query.Email;
                        usuario.Sexo = query.Sexo;
                        usuario.Telefono = query.Telefono;
                        usuario.Celular = query.Celular;
                        usuario.FechaNacimiento = query.FechaNacimiento?.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                        usuario.Curp = query.Curp;
                        usuario.Imagen = query.Imagen;
                        usuario.Estatus = (bool)query.Estatus;
                        usuario.Password = query.Password;
                        usuario.Rol = new ML.Rol();
                        usuario.Rol.IdRol = query.IdRol;

                        result.Object = usuario;
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrió un error al consultar al Usuario";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result ;
        }

        public static ML.Result AddLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    DL_EF.Usuario usuarioDL = new DL_EF.Usuario();

                    usuarioDL.UserName = usuario.UserName;
                    usuarioDL.Nombre = usuario.Nombre;
                    usuarioDL.ApellidoPaterno = usuario.ApellidoPaterno;
                    usuarioDL.ApellidoMaterno = usuario.ApellidoMaterno;
                    usuarioDL.Email = usuario.Email;
                    usuarioDL.Sexo = usuario.Sexo;
                    usuarioDL.Telefono = usuario.Telefono;
                    usuarioDL.Celular = usuario.Celular;
                    usuarioDL.FechaNacimiento = DateTime.Parse(usuario.FechaNacimiento);
                    usuarioDL.CURP = usuario.Curp;

                    context.Usuarios.Add(usuarioDL);
                    context.SaveChanges();

                    result.Correct = true;

                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result ;
        }

        public static ML.Result UpdateLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = (from Usuario in context.Usuarios
                                 where Usuario.IdUsuario == usuario.IdUsuario
                                 select Usuario).SingleOrDefault();

                    if (query != null)
                    {
                        query.UserName = usuario.UserName;
                        query.Nombre = usuario.Nombre;
                        query.ApellidoPaterno = usuario.ApellidoPaterno;
                        query.ApellidoMaterno = usuario.ApellidoMaterno;
                        query.Email = usuario.Email;
                        query.Sexo = usuario.Sexo;
                        query.Telefono = usuario.Telefono;
                        query.Celular = usuario.Celular;
                        query.FechaNacimiento = DateTime.Parse(usuario.FechaNacimiento);
                        query.CURP = usuario.Curp;

                        context.SaveChanges();

                        result.Correct = true;
                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontró al Usuario" + usuario.IdUsuario;
                    }

                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result DeleteLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = (from Usuario in context.Usuarios
                                 where Usuario.IdUsuario == usuario.IdUsuario
                                 select Usuario).First();

                    context.Usuarios.Remove(query);
                    context.SaveChanges();

                    result.Correct = true;
                }
            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public static ML.Result GetAllLINQ()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = (from Usuario in context.Usuarios
                                 select Usuario);

                    result.Objects = new List<object>();

                    if(query != null && query.ToList().Count > 0)
                    {
                        foreach (var obj in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.IdUsuario = obj.IdUsuario;
                            usuario.UserName = obj.UserName;
                            usuario.Nombre = obj.Nombre;
                            usuario.ApellidoPaterno = obj.ApellidoPaterno;
                            usuario.ApellidoMaterno = obj.ApellidoMaterno;
                            usuario.Email = obj.Email;
                            usuario.Sexo = obj.Sexo;
                            usuario.Telefono = obj.Telefono;
                            usuario.Celular = obj.Celular;
                            usuario.FechaNacimiento = obj.FechaNacimiento.ToString();
                            usuario.Curp = obj.CURP;

                            result.Objects.Add(usuario);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontraron registros";
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public static ML.Result GetByIdLINQ(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = (from Usuario in context.Usuarios
                                 where Usuario.IdUsuario == IdUsuario
                                 select Usuario).SingleOrDefault();
                    result.Objects = new List<object>();
                    if (query != null)
                    {
                        ML.Usuario usuario = new ML.Usuario();
                        usuario.IdUsuario = query.IdUsuario;
                        usuario.UserName = query.UserName;
                        usuario.Nombre = query.Nombre;
                        usuario.ApellidoPaterno = query.ApellidoPaterno;
                        usuario.ApellidoMaterno = query.ApellidoMaterno;
                        usuario.Email = query.Email;
                        usuario.Sexo = query.Sexo;
                        usuario.Telefono = query.Telefono;
                        usuario.Celular = query.Celular;
                        usuario.FechaNacimiento = query.FechaNacimiento.ToString();
                        usuario.Curp = query.CURP;

                        result.Object = usuario;
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontró al Usuario";
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }


    }
}
