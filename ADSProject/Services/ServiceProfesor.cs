using ADSProject.DAL;
using ADSProject.Models;
using ADSProject.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADSProject.Services
{
    public class ServiceProfesor
    {
       // public ProfesorDAL profesorDal = new ProfesorDAL();

        // Para insertar profesor
        public int insertar(Profesor profesor)
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    ProfesorDAL dal = new ProfesorDAL(context);
                    //Llamada para obtener el metodo de todos los registros
                    return dal.insertarProfesor(profesor);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificar(int id, Profesor profesor)
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    ProfesorDAL dal = new ProfesorDAL(context);
                    //Llamada para obtener el metodo de todos los registros
                    return dal.modificarProfesor(id,profesor);
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
                    ProfesorDAL dal = new ProfesorDAL(context);
                    //Llamada para obtener el metodo de todos los registros
                    return dal.eliminarProfesor(id);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Profesor> obtenerTodos()
        {
            //Inicializar el proceso para conectarnos a la bd
            //Inicializar el proceso para conectarnos a la bd
            using (MyDbContext context = new MyDbContext())
            {
                //crear instancia de la DAL y le pasamos el context
                ProfesorDAL dal = new ProfesorDAL(context);
                //Llamada para obtener el metodo de todos los registros
                return dal.obtenerTodos();
            }
        }

        // Para obtener por ID.
        public Profesor obtenerPorID(int id)
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    ProfesorDAL dal = new ProfesorDAL(context);
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