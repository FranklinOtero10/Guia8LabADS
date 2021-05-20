using ADSProject.DAL;
using ADSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ADSProject.Models.Context;

namespace ADSProject.Services
{
    public class ServiceGrupo
    {
        //public GrupoDAL grupoDal = new GrupoDAL();

        // Para insertar estudiante
        public int insertar(Grupo grupo)
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    GrupoDAL dal = new GrupoDAL(context);
                    //Llamada para obtener el metodo de todos los registros
                    return dal.insertarGrupo(grupo);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificar(int id, Grupo grupo)
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    GrupoDAL dal = new GrupoDAL(context);
                    //Llamada para obtener el metodo de todos los registros
                    return dal.modificarGrupo(id,grupo);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para eliminar

        public bool eliminar(int id)
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    GrupoDAL dal = new GrupoDAL(context);
                    //Llamada para obtener el metodo de todos los registros
                    return dal.eliminarGrupo(id);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Grupo> obtenerTodos()
        {
            //Inicializar el proceso para conectarnos a la bd
            using (MyDbContext context = new MyDbContext())
            {
                //crear instancia de la DAL y le pasamos el context
                GrupoDAL dal = new GrupoDAL(context);
                //Llamada para obtener el metodo de todos los registros
                return dal.obtenerTodos();
            }
        }

        // Para obtener por ID.
        public Grupo obtenerPorID(int id)
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    GrupoDAL dal = new GrupoDAL(context);
                    //Llamada para obtener el metodo de todos los registros
                    return dal.obtenerPorID(id);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}