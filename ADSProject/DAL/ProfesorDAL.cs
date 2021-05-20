using ADSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ADSProject.Models.Context;

namespace ADSProject.DAL
{
    public class ProfesorDAL
    {
        //public static List<Profesor> lstProfesores = new List<Profesor>();

        //Instancia del contexto que nos permite conectarnos a la BD
        private MyDbContext _context;

        public ProfesorDAL(MyDbContext context) { _context = context; }

        public int insertarProfesor(Profesor profesor)
        {
            try
            {
                //Se agregega el profesor que se insertar
                _context.Profesor.Add(profesor);
                //Se guardan los cambios en la bd
                _context.SaveChanges();
                //se retorno el id de la carrera insertada
                return profesor.id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificarProfesor(int id, Profesor profesor)
        {
            try
            {
                // Se consulta el profesor
                var currentItem = _context.Profesor.SingleOrDefault(temp => temp.id == id);
                //trasladar los valores del profesor que queremos modificar al registro que acabamos de consultar
                _context.Entry(currentItem).CurrentValues.SetValues(profesor);
                //guardamos los cambios
                _context.SaveChanges();
                //retornamos el id de la carrera recien modificada
                return profesor.id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool eliminarProfesor(int id)
        {
            try
            {
                //se consulta el profwsor que se quiere eliminar por el id
                var item = _context.Profesor.SingleOrDefault(x => x.id == id);
                //remover el profesor recien consultada
                _context.Profesor.Remove(item);
                //se guardan los cambios 
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Profesor> obtenerTodos()
        {
            //Se consultan todos los registros de profesor
            var listado = _context.Profesor.ToList();
            //retorno el listado de registros
            return listado;
        }

        // para encontrar un profesor por ID
        public Profesor obtenerPorID(int id)
        {
            try
            {
                //Se obtiene el registro usando el id
                var elementos = _context.Profesor.SingleOrDefault(temp => temp.id == id);
                return elementos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}