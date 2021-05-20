using ADSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ADSProject.Models.Context;

namespace ADSProject.DAL
{
    public class CarreraDAL
    {
        //Declaramos una lista de la clase carrera para guardar en memoria
        //public static List<Carrera> lstCarreras = new List<Carrera>();

        //Instancia del contexto que nos permite conectarnos a la BD
        private MyDbContext _context;

        //En este constructor se recibe el contexto que se manda del servicio
        //Constructor de la clase
        public CarreraDAL(MyDbContext context){ _context = context; }

        public int insertarCarrera(Carrera carrera)
        {
            try
            {
                //Se agregega la carrera que se insertar
                _context.Carrera.Add(carrera);
                //Se guardan los cambios en la bd
                _context.SaveChanges();
                //se retorno el id de la carrera insertada
                return carrera.id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificarCarrera(int id, Carrera carrera)
        {
            try
            {
                // Se consulta la carrera
                var currentItem = _context.Carrera.SingleOrDefault(temp => temp.id == id);
                //trasladar los valores de la carrera que queremos modificar al registro que acabamos de consultar
                _context.Entry(currentItem).CurrentValues.SetValues(carrera);
                //guardamos los cambios
                _context.SaveChanges();
                //retornamos el id de la carrera recien modificada
                return carrera.id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool eliminarCarrera(int id)
        {
            try
            {
                //se consulta la carrera que se quiere eliminar por el id
                var item = _context.Carrera.SingleOrDefault(x => x.id == id);
                //remover la carrera recien consultada
                _context.Carrera.Remove(item);
                //se guardan los cambios 
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Carrera> obtenerTodos()
        {
            try
            {
                //Se consultan todos los registros de carrera
                var listado = _context.Carrera.ToList();
                //retorno el listado de registros
                return listado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        // para encontrar una carrera por ID
        public Carrera obtenerPorID(int id)
        {
            try
            {
                //Se obtiene el registro usando el id
                var elementos = _context.Carrera.SingleOrDefault(temp => temp.id == id);
                //var elementos = lstCarreras.Find(temp => temp.id == id);
                return elementos;
            }
            catch (Exception ex)
            {
                throw;
            }            
        }
    }
}