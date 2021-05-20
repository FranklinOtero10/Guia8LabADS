using ADSProject.DAL;
using ADSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ADSProject.Models.Context;

namespace ADSProject.Services
{
    public class ServiceEstudiantes
    {
        // Instancia para acceder a todos los metodos de la DAL
       // public EstudianteDAL estudianteDal = new EstudianteDAL();

        // Para insertar estudiante
        public int insertar(Estudiante estudiante)
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    EstudianteDAL dal = new EstudianteDAL(context);
                    //Llamada para obtener el metodo de todos los registros
                    return dal.insertarEstudiante(estudiante);
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        // Para modificar un estudiante
        public int modificar( int id, Estudiante estudiante)
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    EstudianteDAL dal = new EstudianteDAL(context);
                    //Llamada para obtener el metodo de todos los registros
                    return dal.modificarEstudiante(id,estudiante);
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        // Para eliminar

        public bool eliminar( int id)
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    EstudianteDAL dal = new EstudianteDAL(context);
                    //Llamada para obtener el metodo de todos los registros
                    return dal.eliminarEstudiante(id);
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        // Para obtener todos los estudiantes.
        public List<Estudiante> obtenerTodos()
        {
            //Inicializar el proceso para conectarnos a la bd
            using (MyDbContext context = new MyDbContext())
            {
                //crear instancia de la DAL y le pasamos el context
                EstudianteDAL dal = new EstudianteDAL(context);
                //Llamada para obtener el metodo de todos los registros
                return dal.obtenerTodos();
            }
        }

        // Para obtener por ID.
        public Estudiante obtenerPorID( int id)
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    EstudianteDAL dal = new EstudianteDAL(context);
                    //Llamada para obtener el metodo de todos los registros
                    return dal.obtenerPorID(id);
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}