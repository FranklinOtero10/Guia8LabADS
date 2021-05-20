using ADSProject.Models;
using ADSProject.Services;
using ADSProject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace ADSProject.Controllers
{
    public class EstudiantesController : Controller
    {
        // instancia del servicio encargado de proveer los metodos
        public ServiceEstudiantes servicio = new ServiceEstudiantes();

        public EstudiantesController() { }


        [HttpGet]
        public ActionResult Index()
        {
            var estudiante = servicio.obtenerTodos();
            return View(estudiante);
        }

        [HttpGet]
        public ActionResult Form(int? id, Operacion operacion)
        {
            var estudiante = new Estudiante();
            // Si el id tiene un valor; entonces se procede  a buscar un estudiante
            if (id.HasValue)
            {
                estudiante = servicio.obtenerPorID(id.Value);
            }
            // Indica la operacion que estamos realizando en el formulario
            ViewData["Operacion"] = operacion;
            return View(estudiante);
        }

        [HttpPost]
        public ActionResult Form(Estudiante estudiante)
        {
            try
            {
                // Validamos que el modelo carrera sea valido
                // segun las validaciones que le agregamos anteriormente
                if (ModelState.IsValid)
                {
                    //Esta variable nos sirve para sabaer si una carrera ha sido insertada correctamente
                    int id = 0;
                    // Si el ID es 0; entonces se esta insertando
                    if (estudiante.id == 0)
                    {
                        id = servicio.insertar(estudiante);
                    }
                    else
                    {
                        // Si el ID es distinto de cero entonces estamos modificando
                        id = servicio.modificar(estudiante.id, estudiante);
                    }

                    //Si el id es mayor que 0 la operación es correcta
                    if (id > 0)
                    {
                        //Si la operación fue exitosa entonces devolvemos el codigo 200(success)
                        return new JsonHttpStatusResult(estudiante, HttpStatusCode.OK);
                    }
                    else
                    {
                        //Si la operación no fue exitosa entonces devolvemos un codigo 202(accepted)
                        return new JsonHttpStatusResult(estudiante, HttpStatusCode.Accepted);
                    }
                }
                else
                {
                    //Si hubo error en la validación, entonces devolvemos todos los errores del modelo con un codigo 
                    // 400 (BadRequest)
                    IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(Temp => Temp.Errors);
                    return new JsonHttpStatusResult(allErrors, HttpStatusCode.BadRequest);
                }
                //return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return new JsonHttpStatusResult(estudiante, HttpStatusCode.InternalServerError);
                //throw;
            }
        }

        [HttpPost]
        public JsonResult Delete(int id, string operacion)
        {
            try
            {
                //variable que permite controlar si fue eliminado correctamente
                bool correcto = false;
                // Eliminar un estudiante
                correcto = servicio.eliminar(id);

                if (correcto)
                {
                    //Se devuelve el id del elemento eliminado y se retorna un código 200 (success)
                    return new JsonHttpStatusResult(new { id }, HttpStatusCode.OK);
                }
                else
                {
                    //si no se puede eliminar entonces se retorna un código 202 (Acceptes)
                    return new JsonHttpStatusResult(new { id }, HttpStatusCode.Accepted);
                }

                //return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return new JsonHttpStatusResult(new { id }, HttpStatusCode.InternalServerError);
                //throw;
            }
        }
    }
}