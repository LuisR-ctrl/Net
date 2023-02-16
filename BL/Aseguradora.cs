using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace BL
{
    public class Aseguradora
    {
        public static ML.Result SPAdd(ML.Aseguradora aseguradora)
        {
                ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "AseguradoraAdd";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] parameter = new SqlParameter[2];

                        parameter[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                        parameter[0].Value = aseguradora.Nombre;

                        parameter[1] = new SqlParameter("@IdUsuario", SqlDbType.VarChar);
                        parameter[1].Value = aseguradora.Usuario;

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
                    string query = "AseguradoraGetAll";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection.Open();

                        DataTable aseguradoraTable = new DataTable();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        da.Fill(aseguradoraTable);

                        if (aseguradoraTable.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();
                            foreach (DataRow row in aseguradoraTable.Rows)
                            {
                                ML.Aseguradora aseguradora = new ML.Aseguradora();
                                aseguradora.IdAseguradora = int.Parse(row[0].ToString());
                                aseguradora.Nombre = row[1].ToString();
                                aseguradora.FechaCreacion = row[2].ToString();
                                aseguradora.FechaModificacion = row[3].ToString();
                                aseguradora.Usuario.IdUsuario = int.Parse(row[4].ToString());
                                result.Objects.Add(aseguradora);

                            }
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "Ocurrió un error al momento de traer los datos de las Aseguradoras";
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result SPGetById(int IdAseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "AseguradoraById";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] parameter = new SqlParameter[1];

                        parameter[0] = new SqlParameter("IdAseguradora", SqlDbType.Int);
                        parameter[0].Value = IdAseguradora;

                        cmd.Parameters.AddRange(parameter);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable tableAseguradora = new DataTable();
                            da.Fill(tableAseguradora);
                            cmd.Connection.Open();
                            if(tableAseguradora.Rows.Count > 0)
                            {
                                result.Objects = new List<object>();

                                DataRow row = tableAseguradora.Rows[0];

                                ML.Aseguradora aseguradora = new ML.Aseguradora();
                                aseguradora.IdAseguradora = int.Parse(row[0].ToString());
                                aseguradora.Nombre = row[1].ToString();
                                aseguradora.FechaCreacion = row[2].ToString();
                                aseguradora.FechaModificacion = row[3].ToString();
                                aseguradora.Usuario.IdUsuario = int.Parse(row[4].ToString());

                                result.Object = aseguradora;
                                result.Correct = true;
                            }
                            else
                            {
                                result.Correct = false;
                                result.ErrorMessage = "Ocurrió un error al momento de traer los datos de las Aseguradoras";
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

        public static ML.Result SPUpdate(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "AseguradoraUpdate";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] parameter = new SqlParameter[3];

                        parameter[0] = new SqlParameter("@IdAseguradora", SqlDbType.Int);
                        parameter[0].Value = aseguradora.IdAseguradora;
                        
                        parameter[1] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                        parameter[1].Value = aseguradora.Nombre;

                        parameter[2] = new SqlParameter("@IdUsuario", SqlDbType.Int);
                        parameter[2].Value = aseguradora.Usuario;

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
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result SPDelete(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "AseguradoraDelete";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] parameter = new SqlParameter[1];

                        parameter[0] = new SqlParameter("@IdAseguradora", SqlDbType.Int);
                        parameter[0].Value = aseguradora.IdAseguradora;

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

        public static ML.Result AddEF(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {

                    var query = context.AseguradoraAdd(aseguradora.Nombre, aseguradora.Usuario.IdUsuario, aseguradora.Imagen);

                    if(query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo registrar la Aseguradora";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct= false;
                result.ErrorMessage= ex.Message;
            }

            return result;
        }

        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = context.AseguradoraGetAll().ToList();

                    result.Objects = new List<object>();

                    if(query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Aseguradora aseguradora = new ML.Aseguradora();
                            aseguradora.IdAseguradora = obj.IdAseguradora;
                            aseguradora.Nombre = obj.Nombre;
                            aseguradora.FechaCreacion = obj.FechaCreacion.ToString();
                            aseguradora.FechaModificacion = obj.FechaModificacion.ToString();
                            aseguradora.Imagen = obj.Imagen;

                            aseguradora.Usuario = new ML.Usuario();
                            aseguradora.Usuario.IdUsuario = obj.IdUsuario;
                            aseguradora.Usuario.UserName = obj.UserName;

                            result.Objects.Add(aseguradora);

                            result.Correct = true;
                        }
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encuentra la Aseguradora";
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

        public static ML.Result GetByIdEF(int IdAseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = context.AseguradoraGetById(IdAseguradora).FirstOrDefault();

                    if (query != null)
                    {
                        ML.Aseguradora aseguradora = new ML.Aseguradora();
                        aseguradora.IdAseguradora = query.IdAseguradora;
                        aseguradora.Nombre = query.Nombre;
                        aseguradora.FechaCreacion = query.FechaCreacion.ToString();
                        aseguradora.FechaModificacion = query.FechaModificacion.ToString();
                        aseguradora.Imagen = query.Imagen;

                        aseguradora.Usuario = new ML.Usuario();
                        aseguradora.Usuario.IdUsuario = query.IdUsuario;
                        aseguradora.Usuario.UserName = query.UserName;

                        result.Object = aseguradora;
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrió un error al obtener las Aseguradoras";

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

        public static ML.Result UpdateEF(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = context.AseguradoraUpdate(aseguradora.IdAseguradora, aseguradora.Nombre, aseguradora.Usuario.IdUsuario, aseguradora.Imagen);
                    
                    if(query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo actualizar la aseguradora";
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

        public static ML.Result DeleteEF(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = context.AseguradoraDelete(aseguradora.IdAseguradora);

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se eliminó el registro";
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

        public static ML.Result AddLINQ(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    DL_EF.Aseguradora aseguradoraDL = new DL_EF.Aseguradora();

                    aseguradoraDL.Nombre = aseguradora.Nombre;
                    DateTime dt = DateTime.Now;
                    //Console.WriteLine(dt.ToString("dd/MM/yyyy HH:mm:ff:fff"));
                    aseguradoraDL.FechaCreacion = Convert.ToDateTime(dt, CultureInfo.InvariantCulture);
                    aseguradoraDL.FechaModificacion = Convert.ToDateTime(dt, CultureInfo.InvariantCulture);
                    aseguradoraDL.IdUsuario = aseguradora.Usuario.IdUsuario;

                    context.Aseguradoras.Add(aseguradoraDL);
                    context.SaveChanges();

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

        public static ML.Result UpdateLINQ(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = (from Aseguradora in context.Aseguradoras
                                 where Aseguradora.IdAseguradora == aseguradora.IdAseguradora
                                 select Aseguradora).SingleOrDefault();

                    if (query != null)
                    {
                        query.Nombre = aseguradora.Nombre;
                        DateTime dt = DateTime.Now;
                        query.FechaModificacion = Convert.ToDateTime(dt.ToString("dd/MM/yyyy"), CultureInfo.InvariantCulture);
                        query.IdUsuario = aseguradora.Usuario.IdUsuario;

                        context.SaveChanges();

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontró la Aseguradora" + aseguradora.IdAseguradora;
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

        public static ML.Result DeleteLINQ(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = (from Aseguradora in context.Aseguradoras
                             where Aseguradora.IdAseguradora == aseguradora.IdAseguradora
                             select Aseguradora).First();

                    context.Aseguradoras.Remove(query);
                    context.SaveChanges();

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

        public static ML.Result GetAllLINQ()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = (from Aseguradora in context.Aseguradoras
                                 select new { IdAseguradora = Aseguradora.IdAseguradora, Nombre = Aseguradora.Nombre, FechaCreacion = Aseguradora.FechaCreacion, FechaModificacion = Aseguradora.FechaModificacion, IdUsuario = Aseguradora.IdUsuario}).ToList();

                    result.Objects = new List<object>();

                    if(query != null && query.ToList().Count > 0)
                    {
                        foreach(var obj in query)
                        {
                            ML.Aseguradora aseguradora = new ML.Aseguradora();
                            aseguradora.IdAseguradora = obj.IdAseguradora;
                            aseguradora.Nombre = obj.Nombre;
                            aseguradora.FechaCreacion = obj.FechaCreacion.ToString();
                            aseguradora.FechaModificacion = obj.FechaModificacion.ToString();
                            aseguradora.Usuario.IdUsuario = (int)obj.IdUsuario;

                            result.Objects.Add(aseguradora);
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
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public static ML.Result GetByIdLINQ(int IdAseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = (from Aseguradora in context.Aseguradoras
                                 where Aseguradora.IdAseguradora == IdAseguradora
                                 select new {IdAseguradora = Aseguradora.IdAseguradora, Nombre = Aseguradora.Nombre, FechaCreacion = Aseguradora.FechaCreacion, FechaModificacion = Aseguradora.FechaModificacion, IdUsuario = Aseguradora.IdUsuario}).SingleOrDefault();

                    result.Objects = new List<object>();

                    if(query != null )
                    {
                        ML.Aseguradora aseguradora = new ML.Aseguradora();
                        aseguradora.IdAseguradora = query.IdAseguradora;
                        aseguradora.Nombre = query.Nombre;
                        aseguradora.FechaCreacion = query.FechaCreacion.ToString();
                        aseguradora.FechaModificacion = query.FechaModificacion.ToString();
                        aseguradora.Usuario.IdUsuario = (int)query.IdUsuario;

                        result.Object = aseguradora;
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
