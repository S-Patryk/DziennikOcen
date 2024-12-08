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
            var fakeUsers = new List<User>()
            {
                new User()
                {
                    Update_at = DateTime.MinValue,
                    Create_at = DateTime.Now,
                    Password = "saddsad",
                    Pin = 123,
                    RoleID = 1,
                    UserID = 1,
                    Username = "jacek"
                },
                new User()
                {
                    Update_at = DateTime.MinValue,
                    Create_at = DateTime.Now,
                    Password = "saddsad",
                    Pin = 123,
                    RoleID = 1,
                    UserID = 2,
                    Username = "patryk"
                },
            };

            return fakeUsers;
        }
    }
}
