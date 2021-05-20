using ADSProject.DAL;
using ADSProject.Models;
using ADSProject.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADSProject.Services
{
    public class ServiceCarrera
    {
        //Para acceder a los miembros de carrera dal
        //public CarreraDAL carreraDal = new CarreraDAL();

        // Para insertar carrera
        public int insertar(Carrera carrera)
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    CarreraDAL dal = new CarreraDAL(context);
                    //Llamada para obtener el metodo de todos los registros
                    return dal.insertarCarrera(carrera);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificar(int id, Carrera carrera)
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    CarreraDAL dal = new CarreraDAL(context);
                    //Llamada para obtener el metodo de todos los registros
                    return dal.modificarCarrera(id,carrera);
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
                    CarreraDAL dal = new CarreraDAL(context);
                    //Llamada para obtener el metodo de todos los registros
                    return dal.eliminarCarrera(id);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para obtener todos las carreras.
        public List<Carrera> obtenerTodos()
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    CarreraDAL dal = new CarreraDAL(context);
                    //Llamada para obtener el metodo de todos los registros
                    return dal.obtenerTodos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Para obtener por ID.
        public Carrera obtenerPorID(int id)
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    CarreraDAL dal = new CarreraDAL(context);
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