using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class PolizaController : Controller
    {
        // GET: Poliza
        public ActionResult GetAll()
        {
            //referencia de servicio
            ServicePoliza.PolizaClient polizaClient = new ServicePoliza.PolizaClient();

            var resultService = polizaClient.GetAll();
            //ML.Result result = BL.Poliza.GetAll();

            ML.Poliza poliza = new ML.Poliza();

            poliza.Polizas = resultService.Objects.ToList();

            return View(poliza);
        }

        public ActionResult Form(int? IdPoliza)
        {

            ML.Poliza poliza = new ML.Poliza();
            ML.Result resultPoliza = BL.Subpoliza.SubPolizaGetAll();
            ML.Result resultUsuario = BL.Usuario.GetAll();

            poliza.SubPoliza = new ML.SubPoliza();
            poliza.Usuario = new ML.Usuario();

            if (IdPoliza != null)
            {
                ServicePoliza.PolizaClient polizaClient = new ServicePoliza.PolizaClient();

                var resultService = polizaClient.GetById(IdPoliza.Value);

                //ML.Result result = BL.Poliza.GetById(IdPoliza.Value);
                if (resultService.Correct)
                {


                    poliza = (ML.Poliza)resultService.Object;
                    poliza.Usuario.Usuarios = resultUsuario.Objects.ToList();
                    poliza.SubPoliza.SubPolizas = resultPoliza.Objects.ToList();
                    return View(poliza);

                }
                else
                {
                    ViewBag.Message("Eror al realizar la consulta" + resultService.ErrorMessage);
                    return PartialView("Modal");
                }
            }
            else
            {
                poliza.Usuario.Usuarios = resultUsuario.Objects.ToList();
                poliza.SubPoliza.SubPolizas = resultPoliza.Objects.ToList();
                return View(poliza);
            }
        }

        [HttpPost]

        public ActionResult Form(ML.Poliza poliza)
        {
            ML.Result result = new ML.Result();

            if (poliza.IdPoliza != 0)
            {
                //referencia de servicio
                ServicePoliza.PolizaClient polizaClient = new ServicePoliza.PolizaClient();

                var resultService = polizaClient.Update(poliza);
                //result = BL.Poliza.Update(poliza);

                if (resultService.Correct)
                {
                    ViewBag.Message = "Se ha actualizado la Poliza correctamente";
                    return PartialView("Modal");
                }
                else
                {
                    ViewBag.Message = "Error al actualizar" + result.ErrorMessage;
                    return PartialView("Modal");
                }
            }
            else
            {
                //referencia de servicio
                ServicePoliza.PolizaClient polizaClient = new ServicePoliza.PolizaClient();

                var resultService = polizaClient.Add(poliza);
                //result = BL.Poliza.Add(poliza);

                if (resultService.Correct)
                {
                    ViewBag.Message = "Se ha registrado la Poliza correctamente";
                    return PartialView("Modal");
                }
                else
                {
                    ViewBag.Message = "Error al registrar" + result.ErrorMessage;
                    return PartialView("Modal");
                }
            }
        }

        [HttpGet]
        public ActionResult Delete(ML.Poliza poliza)
        {
            ServicePoliza.PolizaClient polizaClient = new ServicePoliza.PolizaClient();
            var resultService=polizaClient.Delete(poliza);
            //ML.Result result = BL.Poliza.Delete(poliza);

            if (resultService.Correct)
            {
                ViewBag.Message = "Se eliminó la Poliza";
                return PartialView("Modal");
            }
            else
            {
                ViewBag.Message = "No se pudo eliminar la Poliza" + resultService.ErrorMessage;
                return PartialView("Modal");
            }

        }
    }
}