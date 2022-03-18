using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebServicePostgre.DataAccess;
using WebServicePostgre.Models;

namespace WebServicePostgre.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class catalumnoController : ControllerBase
    {
        private readonly iDataAccessProvider _dataAcessProvider;

        public catalumnoController(iDataAccessProvider dataAccessProvider)
        {
            _dataAcessProvider = dataAccessProvider;
        }

        [HttpGet]
        public IEnumerable<catalumno> Get()
        {
            return _dataAcessProvider.GetCatalumnoRecords();
            
        }

        [HttpGet("{id}")]
        public catalumno Details(int id)
        {
            return _dataAcessProvider.GetCatalumnoSingleRocord(id);
        }

        [HttpPost]
        public IActionResult Create([FromBody] catalumno catalumno)
        {
            if (ModelState.IsValid)
            {
                _dataAcessProvider.AddcatalumnoRecord(catalumno);
                return Ok();
            }
            return BadRequest();
        }
    }
}
