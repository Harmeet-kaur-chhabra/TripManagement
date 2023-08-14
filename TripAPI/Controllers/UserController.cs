using Microsoft.AspNetCore.Mvc;
using TripData;
using TripModel;
using TripModel.DTO;

namespace TripAPI.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : Controller
    {
        //End point created
        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> GetUsers()
        {
            return Ok(TripStore.userList);
        }
        [HttpGet("{id:int}")]
        public ActionResult<UserDTO> GetUsers(int id)
        {
            return Ok(TripStore.userList.FirstOrDefault(u=>u.UserId==id));
        }
    }
}
