using DziennikOcen.Server.Models;
using DziennikOcen.Server.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DziennikOcen.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            
           var userrepository = new UserRepository();

           var users = await userrepository.GetAll();

            return Ok(users);
        }
    }
}
