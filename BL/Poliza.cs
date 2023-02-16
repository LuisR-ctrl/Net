using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Poliza
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = context.PolizaGetAll().ToList();

                    result.Objects = new List<object>();

                    if(query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Poliza poliza = new ML.Poliza();

                            poliza.IdPoliza = obj.IdPoliza;
                            poliza.Nombre = obj.Nombre;

                            poliza.SubPoliza = new ML.SubPoliza();
                            poliza.SubPoliza.IdSubPoliza = obj.SubPolizaId;
                            poliza.SubPoliza.Nombre = obj.SubPolizaNombre;

                            poliza.NumeroPoliza = obj.NumeroPoliza;
                            poliza.FechaCreacion = obj.FechaCreacion?.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                            poliza.FechaModificacion = obj?.FechaModificacion?.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

                            poliza.Usuario = new ML.Usuario();
                            poliza.Usuario.IdUsuario = obj.UsuarioId;
                            poliza.Usuario.UserName = obj.UsuarioUserName;

                            result.Objects.Add(poliza);
                            result.Correct = true;
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

        public static ML.Result GetById(int IdPoliza)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = context.PolizaGetById(IdPoliza).FirstOrDefault();

                    if(query != null)
                    {
                        ML.Poliza poliza = new ML.Poliza();

                        poliza.IdPoliza = query.IdPoliza;
                        poliza.Nombre = query.Nombre;

                        poliza.SubPoliza = new ML.SubPoliza();
                        poliza.SubPoliza.IdSubPoliza = query.SubPolizaId;
                        poliza.SubPoliza.Nombre = query.SubPolizaNombre;

                        poliza.NumeroPoliza = query.NumeroPoliza;
                        poliza.FechaCreacion = query.FechaCreacion?.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                        poliza.FechaModificacion = query?.FechaModificacion?.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

                        poliza.Usuario = new ML.Usuario();
                        poliza.Usuario.IdUsuario = query.UsuarioId;
                        poliza.Usuario.UserName = query.UsuarioUserName;

                        result.Object = poliza;
                        result.Correct = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct= false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }

        public static ML.Result Add(ML.Poliza poliza)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = context.PolizaAdd(poliza.Nombre, poliza.SubPoliza.IdSubPoliza, poliza.NumeroPoliza, poliza.Usuario.IdUsuario);

                    if(query > 0)
                    {
                        result.Correct = true;
                        result.ErrorMessage = "Se registro la Poliza";
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo registrar la Poliza";
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = true;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }

        public static ML.Result Update(ML.Poliza poliza)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = context.PolizaUpdate(poliza.IdPoliza, poliza.Nombre, poliza.SubPoliza.IdSubPoliza, poliza.NumeroPoliza, poliza.Usuario.IdUsuario);

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo actualizar la Poliza";
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

        public static ML.Result Delete(ML.Poliza poliza)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = context.PolizaDelete(poliza.IdPoliza);

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
                result.Ex = ex;
            }
            return result;
        }
    }
}
