using CRUD_MongoDB_API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Text.Json;
using System.Web.Helpers;

namespace CRUD_MongoDB_API.Controllers
{
   
    public class MongoController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var service = new MongoDBService("mongodb://localhost:27017", "NetCoreTest", "ImportCSV");
            var result = await service.GetAll();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetTopThousand()
        {
            var service = new MongoDBService("mongodb://localhost:27017", "NetCoreTest", "ImportCSV");
            var result = await service.GetTopThousand();
            return Ok(result);
        }
    }
}
