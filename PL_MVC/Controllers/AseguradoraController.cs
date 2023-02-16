using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class AseguradoraController : Controller
    {
        // GET: Aseguradora
        public ActionResult GetAll()
        {
            //llamamos al get all de aseguradora
            ML.Result result = BL.Aseguradora.GetAllEF();
            //creo una instancia de aseguradora
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            //paso de mi lista result.objects a mi list de aseguradoras
            aseguradora.Aseguradoras = result.Objects;

            return View(aseguradora);
        }
        
        public ActionResult Form(int? IdAseguradora)
        {

            ML.Aseguradora aseguradora = new ML.Aseguradora();
            ML.Result resultUsuario = BL.Aseguradora.GetAllEF();

            aseguradora.Usuario = new ML.Usuario();
            //aseguradora.Usuario.Usuarios = resultUsuario.Objects.ToList();

            if (IdAseguradora != null)
            {
                ML.Result result = BL.Aseguradora.GetByIdEF(IdAseguradora.Value);
                if (result.Correct)
                {

                    aseguradora = (ML.Aseguradora)result.Object;
                    aseguradora.Usuario.Usuarios = resultUsuario.Objects.ToList();
                    return View(aseguradora);

                }
                else
                {
                    ViewBag.Message("Eror al realizar la consulta" + result.ErrorMessage);
                    return PartialView("Modal");
                }
            }
            else
            {
                aseguradora.Usuario.Usuarios = resultUsuario.Objects.ToList();
                return View(aseguradora);
            }
        }

        [HttpPost]
        
        public ActionResult Form(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();

            if(aseguradora.IdAseguradora != 0)
            {
               result = BL.Aseguradora.UpdateEF(aseguradora);

                if (result.Correct)
                {
                    ViewBag.Message = "Se ha actualizado la Aseguradora correctamente";
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
                result = BL.Aseguradora.AddEF(aseguradora);

                if (result.Correct)
                {
                    ViewBag.Message = "Se ha registrado la Aseguradora correctamente";
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
        public ActionResult Delete(ML.Aseguradora aseguradora)
        {
            ML.Result result = BL.Aseguradora.DeleteEF(aseguradora);

            if (result.Correct)
            {
                ViewBag.Message = "Se eliminó la Aseguradora";
                return PartialView("Modal");
            }
            else
            {
                ViewBag.Message = "No se pudo eliminar la Aseguradora" + result.ErrorMessage;
                return PartialView("Modal");
            }

        }

    }
}