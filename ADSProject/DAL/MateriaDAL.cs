using ADSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ADSProject.Models.Context;

namespace ADSProject.DAL
{
    public class MateriaDAL
    {
        // Listado de Materias, a nivel de memoria del proyecto
        //public static List<Materia> lstMateria = new List<Materia>();

        //Instancia del contexto que nos permite conectarnos a la BD
        private MyDbContext _context;

        public MateriaDAL(MyDbContext context) { _context = context; }

        public int insertarMateria(Materia materia)
        {
            try
            {
                //Se agregega la carrera que se insertar
                _context.Materia.Add(materia);
                //Se guardan los cambios en la bd
                _context.SaveChanges();
                //se retorno el id de la carrera insertada
                return materia.id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificarMateria(int id, Materia materia)
        {
            try
            {
                // Se consulta la materia
                var currentItem = _context.Materia.SingleOrDefault(temp => temp.id == id);
                //trasladar los valores de la materia que queremos modificar al registro que acabamos de consultar
                _context.Entry(currentItem).CurrentValues.SetValues(materia);
                //guardamos los cambios
                _context.SaveChanges();
                //retornamos el id de la materia recien modificada
                return materia.id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool eliminarMateria(int id)
        {
            try
            {
                //se consulta la materia que se quiere eliminar por el id
                var item = _context.Materia.SingleOrDefault(x => x.id == id);
                //remover la materia recien consultada
                _context.Materia.Remove(item);
                //se guardan los cambios 
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Materia> obtenerTodos()
        {
            //Se consultan todos los registros de carrera
            var listado = _context.Materia.ToList();
            //retorno el listado de registros
            return listado;
        }
        
        public Materia obtenerPorID(int id)
        {
            try
            {
                //Se obtiene el registro usando el id
                var elementos = _context.Materia.SingleOrDefault(temp => temp.id == id);
                return elementos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}