using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult GetAll()
        {
            ML.Usuario usuario = new ML.Usuario();

            usuario.Nombre = (usuario.Nombre == null) ? "" : usuario.Nombre;
            usuario.ApellidoPaterno = (usuario.ApellidoPaterno == null) ? "" : usuario.ApellidoPaterno;
            usuario.UserName = (usuario.UserName == null) ? "" : usuario.UserName;

            ML.Result result = BL.Usuario.GetAllEF(usuario);

            usuario.Usuarios = result.Objects;

            return View(usuario);
        }

        [HttpPost]
        public ActionResult GetAll(ML.Usuario usuario)
        {
            ML.Result result = BL.Usuario.GetAllEF(usuario);

            usuario = new ML.Usuario();

            usuario.Usuarios = result.Objects;

            return View(usuario);
        }
        [HttpGet]
        public ActionResult Form(int? IdUsuario)
        {
            ML.Usuario usuario = new ML.Usuario();
            ML.Result resultRoles = BL.Rol.GetAllEF();

            usuario.Rol = new ML.Rol();

            if (IdUsuario != null)
            {
                ML.Result result = BL.Usuario.GetByIdEF(IdUsuario.Value);
                if (result.Correct)
                {
                    usuario = (ML.Usuario)result.Object;
                    usuario.Rol.Roles = resultRoles.Objects.ToList();
                    return View(usuario);
                }
                else
                {
                    ViewBag.Message("Error al realizar la consulta" + result.ErrorMessage);
                    return PartialView("Modal");
                }
            }   
            else
            {
                usuario.Rol.Roles = resultRoles.Objects.ToList();
                return View(usuario);
            }
        }
        [HttpPost]
        public ActionResult Form(ML.Usuario usuario) 
        { 
            ML.Result result = new ML.Result();

            if(usuario.IdUsuario != 0)
            {
                result = BL.Usuario.UpdateEF(usuario);

                if (result.Correct)
                {
                    ViewBag.Message = "Se ha actualizado el Usuario correctamente";
                    return PartialView("Modal");
                }
                else
                {
                    ViewBag.Message = "Error al actualizar el Usuario" + result.ErrorMessage;
                    return PartialView("Modal");
                }
            }
            else
            {
                result = BL.Usuario.AddEF(usuario);

                if (result.Correct)
                {
                    ViewBag.Message = "Se ha registrado el Usuario correctamente";
                    return PartialView("Modal");
                }
                else
                {
                    ViewBag.Message = "Error al registrar al Usuario" + result.ErrorMessage;
                    return PartialView("Modal");
                }
            }
            
        }
        [HttpGet]
        public ActionResult Delete(ML.Usuario usuario)
        {
            ML.Result result = BL.Usuario.DeleteEF(usuario);

            if (result.Correct)
            {
                ViewBag.Message = "Se eliminó el Usuario correctamente";
                return PartialView("Modal");
            }
            else
            {
                ViewBag.Message = "No se pudo eliminar el Usuario" + result.ErrorMessage;
                return PartialView("Modal");
            }
        }
    }
}