using System;
using System.Collections.Generic;
using System.Linq;
using WebServicePostgre.Models;

namespace WebServicePostgre.DataAccess
{
    public class DataAccessProvider : iDataAccessProvider
    {
        private readonly PostgreSqlContext _context;

        public DataAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }

        List<catalumno> iDataAccessProvider.GetCatalumnoRecords()
        {
            return _context.catalumno.ToList();
        }

        catalumno iDataAccessProvider.GetCatalumnoSingleRocord(int id)
        {
            return _context.catalumno.FirstOrDefault(t=>t.id == id);
        }

        public void AddcatalumnoRecord(catalumno catalumno)
        {
            _context.catalumno.Add(catalumno);
            _context.SaveChanges();
        }
    }
}
