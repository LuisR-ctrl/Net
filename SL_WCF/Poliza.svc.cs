using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Poliza" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Poliza.svc o Poliza.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Poliza : IPoliza
    {
        public SL_WCF.Result Add(ML.Poliza poliza)
        {
            ML.Result result = BL.Poliza.Add(poliza);

            return new Result { 
                Correct = result.Correct,
                ErrorMessage = result.ErrorMessage,
                Ex = result.Ex, 
                Object = result.Object, 
                Objects = result.Objects
            };
        }

        public SL_WCF.Result Update(ML.Poliza poliza)
        {
            ML.Result result = BL.Poliza.Update(poliza);

            return new Result
            {
                Correct = result.Correct,
                ErrorMessage = result.ErrorMessage,
                Ex = result.Ex,
                Object = result.Object,
                Objects = result.Objects
            };
        }

        public SL_WCF.Result Delete(ML.Poliza poliza)
        {
            ML.Result result = BL.Poliza.Delete(poliza);

            return new Result
            {
                Correct = result.Correct,
                ErrorMessage = result.ErrorMessage,
                Ex = result.Ex,
                Object = result.Object,
                Objects = result.Objects
            };
        }

        public SL_WCF.Result GetAll()
        {
            ML.Result result = BL.Poliza.GetAll();

            return new Result
            {
                Correct = result.Correct,
                ErrorMessage = result.ErrorMessage,
                Object = result.Object,
                Objects = result.Objects,
                Ex = result.Ex
            };
        }

        public SL_WCF.Result GetById(int IdPoliza)
        {
            ML.Result result = BL.Poliza.GetById(IdPoliza);

            return new Result
            {
                Correct = result.Correct,
                ErrorMessage = result.ErrorMessage,
                Object = result.Object,
                Objects = result.Objects,
                Ex = result.Ex
            };
        }
    }
}
