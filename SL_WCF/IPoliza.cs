using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPoliza" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPoliza
    {
        [OperationContract]
        SL_WCF.Result Add(ML.Poliza poliza);
        [OperationContract]
        SL_WCF.Result Update(ML.Poliza poliza);
        [OperationContract]
        SL_WCF.Result Delete(ML.Poliza poliza);
        [OperationContract]
        //Serializa todo el modelo a un formato XML
        //serializa->convertir un tipo de dato a otro
        [ServiceKnownType(typeof(ML.Poliza))]
        SL_WCF.Result GetAll();
        [OperationContract]
        [ServiceKnownType(typeof(ML.Poliza))]
        SL_WCF.Result GetById(int IdPoliza);
    }
}
