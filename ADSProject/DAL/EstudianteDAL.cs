using ADSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ADSProject.Models.Context;

namespace ADSProject.DAL
{
    public class EstudianteDAL
    {
        // Listado de estudiantes, a nivel de memoria del proyecto
        //public static List<Estudiante> lstEstudiantes = new List<Estudiante>();

        //Instancia del contexto que nos permite conectarnos a la BD
        private MyDbContext _context;

        public EstudianteDAL(MyDbContext context) { _context = context; }

        public int insertarEstudiante(Estudiante estudiante)
        {
            try
            {
                //Se agregega el estudiante que se va a  insertar
                _context.Estudiante.Add(estudiante);
                //Se guardan los cambios en la bd
                _context.SaveChanges();
                //se retorno el id de la carrera insertada
                return estudiante.id;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public int modificarEstudiante( int id, Estudiante estudiante)
        {
            try
            {
                // Se consulta el estudiante
                var currentItem = _context.Estudiante.SingleOrDefault(temp => temp.id == id);
                //trasladar los valores de estudiante que queremos modificar al registro que acabamos de consultar
                _context.Entry(currentItem).CurrentValues.SetValues(estudiante);
                //guardamos los cambios
                _context.SaveChanges();
                //retornamos el id de la carrera recien modificada
                return estudiante.id;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        // Para eliminar un estudiante del listado
        public bool eliminarEstudiante( int id)
        {
            try
            {
                //se consulta la carrera que se quiere eliminar por el id
                var item = _context.Estudiante.SingleOrDefault(x => x.id == id);
                //remover la carrera recien consultada
                _context.Estudiante.Remove(item);
                //se guardan los cambios 
                _context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        // Para listar todos los estudiantes
        public List<Estudiante> obtenerTodos()
        {
            //Se consultan todos los registros de carrera
            var listado = _context.Estudiante.ToList();
            //retorno el listado de registros
            return listado;
        }

        // para encontrar un estudiante por ID
        public Estudiante obtenerPorID(int id)
        {
            try
            {
                //Se obtiene el registro usando el id
                var elementos = _context.Estudiante.SingleOrDefault(temp => temp.id == id);
                return elementos;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

    }
}