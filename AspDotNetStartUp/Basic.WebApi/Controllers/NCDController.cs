using Basic.Domain.Interfaces;
using Basic.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Basic.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NCDController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public NCDController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet("GetNCD")]
        public IEnumerable<NCD> GetAllPersons()
        {
            return unitOfWork.NCD.GetAll();
        }

        [HttpPost("AddNCD")]
        public async Task<IActionResult> EnterItem(NCD item)
        {
            unitOfWork.NCD.Add(item);
            unitOfWork.Save();
            return Ok();
        }
    }
}
