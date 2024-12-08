using DziennikOcen.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace DziennikOcen.Server.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
            

        [HttpGet]
        public List<User> Get()
        {
                return new List<User>() { new Models.User { Create_at=DateTime.Now} };
        }
    }
}
