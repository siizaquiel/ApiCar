using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using izcar.api.Models;

namespace izcar.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        private readonly ILogger<CarroController> _logger;
        private List<Carro> _carros;
        public CarroController(ILogger<CarroController> logger)
        {
            _logger = logger;

            _carros = new List<Carro>();

            _carros.Add(new Carro(1, "Gol", "MXB-1347", 2015));
            _carros.Add(new Carro(2, "Polo", "QWA-2I28", 2019));
            _carros.Add(new Carro(3, "Palio", "MXB-1354", 2014));
            _carros.Add(new Carro(4, "Ranger", "MXA-1840", 2011));
            _carros.Add(new Carro(5, "Onix", "RKA-1J22", 2021));
        
        }
         [HttpGet]
        public IActionResult Get()
        {
            return Ok(_carros);
        }


       /* [HttpGet ("{id:int}")]
        public IActionResult GetById(int id)
        {
            var carro = _carros.Where(a => a.Id == id).FirstOrDefault();

            if (carro == null)
            {
                return NotFound(new { message = "Carro não encontrado!", id = id});
            }

            return Ok(carro);
        } */


         [HttpGet ("{placa}")]
        public IActionResult GetByPlaca(string placa)
        {
            var carro = _carros.Where(a => a.Placa.Contains(placa)).FirstOrDefault();

            if (carro == null)
            {
                return NotFound(new { message = "Placa não encontrado!", placa = placa});
            }

            return Ok(carro);
        }

    }
}