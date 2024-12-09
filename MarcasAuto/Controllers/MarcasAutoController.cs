using MarcasAuto.Application.Interfaces;
using MarcasAuto.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarcasAuto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasAutoController(IMarcasAutoService marcasAutoService) : ControllerBase
    {
        [HttpGet(Name = "")]
        public async Task<IEnumerable<MarcasAutoEntity>> GetAll()
        {
            return await marcasAutoService.GetAll();
        }
    }
}
