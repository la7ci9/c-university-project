using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi_Common.Models;
using WebApi_Server.Repositories;

namespace WebApi_Server.Controllers
{
    [ApiController]
    [Route("api/cardata")]
    public class CardataController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<Cardata>> Get()
        {
            var cars = CardataRepository.GetCars();
            return Ok(cars);
        }

        [HttpGet("{id}")]
        public ActionResult<Cardata> Get(long id)
        {
           
            var cardata = CardataRepository.GetCardata(id);

            if (cardata != null)
            {
                return Ok(cardata);
            }
            else
            {
                return NotFound();
            }

            
        }

        [HttpPost]
        public ActionResult Post(Cardata cardata)
        {
            CardataRepository.AddCar(cardata);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(Cardata cardata,long id)
        {
            var dbCar = CardataRepository.GetCardata(id);

            if (dbCar != null)
            {
                CardataRepository.UpdateCar(cardata);
                return Ok();
            }
            return NotFound();

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {


            var cardata = CardataRepository.GetCardata(id);
            if (cardata != null)
            {
  
                CardataRepository.DeleteCar(cardata);
                return Ok();
            }

            return NotFound();
        }
    }
}
