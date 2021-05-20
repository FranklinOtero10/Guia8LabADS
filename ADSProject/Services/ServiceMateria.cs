using ADSProject.DAL;
using ADSProject.Models;
using ADSProject.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADSProject.Services
{
    public class ServiceMateria
    {
        //public MateriaDAL materiaDal = new MateriaDAL();

        public int insertar(Materia materia)
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    MateriaDAL dal = new MateriaDAL(context);
                    //Llamada para obtener el metodo de todos los registros
                    return dal.insertarMateria(materia);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificar(int id, Materia materia)
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    MateriaDAL dal = new MateriaDAL(context);
                    //Llamada para obtener el metodo de todos los registros
                    return dal.modificarMateria(id,materia);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool eliminar(int id)
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    MateriaDAL dal = new MateriaDAL(context);
                    //Llamada para obtener el metodo de todos los registros
                    return dal.eliminarMateria(id);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Materia> obtenerTodos()
        {
            //Inicializar el proceso para conectarnos a la bd
            using (MyDbContext context = new MyDbContext())
            {
                //crear instancia de la DAL y le pasamos el context
                MateriaDAL dal = new MateriaDAL(context);
                //Llamada para obtener el metodo de todos los registros
                return dal.obtenerTodos();
            }
        }

        public Materia obtenerPorID(int id)
        {
            try
            {
                //Inicializar el proceso para conectarnos a la bd
                using (MyDbContext context = new MyDbContext())
                {
                    //crear instancia de la DAL y le pasamos el context
                    MateriaDAL dal = new MateriaDAL(context);
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