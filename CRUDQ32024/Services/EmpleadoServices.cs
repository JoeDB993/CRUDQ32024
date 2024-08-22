

using CRUDQ32024.Models;
using SQLite;
using SQLiteNetExtensionsAsync.Extensions;

namespace CRUDQ32024.Services
{
    public class EmpleadoServices
    {

        private readonly SQLiteConnection dbConnection;
        public EmpleadoServices() 
        {
            //Construir ruta
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Empleado.db3");
            //Inicializar el objeto
            dbConnection = new SQLiteConnection(dbPath);

            //Creamos la tabla empleado
            dbConnection.CreateTable<Empleado>();

        }

        /// <summary>
        /// Lista de todos los empleados 
        /// </summary>
        /// <returns>Una lista de empleados</returns>
        public List<Empleado> GetAll()
        {
            var res = dbConnection.Table<Empleado>().ToList;
            return res;
            
        }
        /// <summary>
        /// Guarda un registro a la base de datos
        /// </summary>
        /// <param name="empleado">Objeto con datos del empleado a guardar</param>
        /// <returns>Cantidad de registros ingresados</returns>
        public int Insert(Empleado empleado)
        {
            return dbConnection.Insert(empleado);
        }

        /// <summary>
        /// Actualiza un registro a la base de datos
        /// </summary>
        /// <param name="empleado">Objeto con los datos del empleado a actualizarse</param>
        /// <returns>Cantidad de registros actualizados</returns>
        public int Update(Empleado empleado)
        {
            return dbConnection.Update(empleado);
        }

        /// <summary>
        /// Elimina un registro de la base de datos
        /// </summary>
        /// <param name="empleado">Objeto con los datos a eliminar</param>
        /// <returns>Cantidad de registros eliminados</returns>
        public int Delete(Empleado empleado)
        {
            return dbConnection.Delete(empleado);
        }

    }
}
