using Basic.Domain.Interfaces;
using Basic.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Basic.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiseaseController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public DiseaseController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet("GetDiseases")]
        public IEnumerable<Diseases> GetAllPersons()
        {
            return unitOfWork.Diseases.GetAll();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Diseases>> Get()
        {
            var items = new List<Diseases>
            {
                new Diseases { Id = 1, Name = "Item 1" },
                new Diseases { Id = 2, Name = "Item 2" },
                new Diseases { Id = 3, Name = "Item 3" }
            };



            return Ok(items);
        }

        [HttpPost("AddDisease")] 
        public async Task<IActionResult> EnterItem(Diseases item)
        {
            unitOfWork.Diseases.Add(item);
            unitOfWork.Save();
            return Ok();
        }


    }
}
