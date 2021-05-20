using ADSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ADSProject.Models.Context;

namespace ADSProject.DAL
{
    public class GrupoDAL
    {
        //public static List<Grupo> lstGrupos = new List<Grupo>();
        //Instancia del contexto que nos permite conectarnos a la BD
        private MyDbContext _context;

        public GrupoDAL(MyDbContext context) { _context = context; }

        public int insertarGrupo(Grupo grupo)
        {
            try
            {
                //Se agregega el grupo que se insertar
                _context.Grupo.Add(grupo);
                //Se guardan los cambios en la bd
                _context.SaveChanges();
                //se retorno el id del grupo insertada
                return grupo.id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificarGrupo(int id, Grupo grupo)
        {
            try
            {
                // Se consulta el grupo
                var currentItem = _context.Grupo.SingleOrDefault(temp => temp.id == id);
                //trasladar los valores del grupo que queremos modificar al registro que acabamos de consultar
                _context.Entry(currentItem).CurrentValues.SetValues(grupo);
                //guardamos los cambios
                _context.SaveChanges();
                //retornamos el id de la carrera recien modificada
                return grupo.id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool eliminarGrupo(int id)
        {
            try
            {
                //se consulta el grupo que se quiere eliminar por el id
                var item = _context.Grupo.SingleOrDefault(x => x.id == id);
                //remover el grupo recien consultada
                _context.Grupo.Remove(item);
                //se guardan los cambios 
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para listar todos los grupos
        public List<Grupo> obtenerTodos()
        {
            //Se consultan todos los registros de grupo
            var listado = _context.Grupo.ToList();
            //retorno el listado de registros
            return listado;
        }

        public Grupo obtenerPorID(int id)
        {
            try
            {
                //Se obtiene el registro usando el id
                var elementos = _context.Grupo.SingleOrDefault(temp => temp.id == id);
                return elementos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}