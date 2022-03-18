using System.Collections.Generic;
using WebServicePostgre.Models;

namespace WebServicePostgre.DataAccess
{
    public interface iDataAccessProvider
    {
        /// <summary>
        /// Monserrat Delgado 20220312
        /// Obtiene la lista completa de registros en la tabla catalumno
        /// </summary>
        /// <returns>List<catalumno></returns>
        List<catalumno> GetCatalumnoRecords();

        /// <summary>
        /// Monserrat Delgado 20220312
        /// Obtiene solo un registro de catalumno por ID
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>catalumno</returns>
        catalumno GetCatalumnoSingleRocord(int id);

        /// <summary>
        /// Monserrat Delgado 20220317
        /// Ingresa un nuevo registro a catalumno
        /// </summary>
        /// <param name="catalumno"></param>
        void AddcatalumnoRecord(catalumno catalumno);
    }
}
