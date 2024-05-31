using Basic.Domain.Interfaces;
using Basic.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Basic.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllergiesController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public AllergiesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet("GetAllergies")]
        public IEnumerable<Allergies> GetAllPersons()
        {
            return unitOfWork.Allergies.GetAll();
        }

        [HttpPost("AddAllergies")]
        public async Task<IActionResult> EnterItem(Allergies item)
        {
            unitOfWork.Allergies.Add(item);
            unitOfWork.Save();
            return Ok();
        }

    }
}
