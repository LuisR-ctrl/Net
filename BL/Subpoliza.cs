using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Subpoliza
    {
        public static ML.Result SubPolizaGetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.LRomanProgramacionNCapasEntities context = new DL_EF.LRomanProgramacionNCapasEntities())
                {
                    var query = context.SubPolizaGetAll().ToList();

                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.SubPoliza subpoliza = new ML.SubPoliza();

                            subpoliza.IdSubPoliza = obj.IdSubPoliza;
                            subpoliza.Nombre = obj.Nombre;

                            result.Objects.Add(subpoliza);
                            result.Correct = true;
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
    }
}
