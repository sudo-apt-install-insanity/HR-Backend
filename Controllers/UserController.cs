using Microsoft.AspNetCore.Mvc;
using HrDatabaseBackend.Services.UserService;
using HrDatabaseBackend.Model.UserModel;

namespace HrDatabaseBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return userService.Get();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(string id)
        {

            var user = userService.Get(id);
            if (user == null)
            {
                return NotFound($"User with Id={id} not found");
            }
            return user;
        }

      

        // POST api/<UserController>
        [HttpPost]
        public ActionResult<User> Post([FromBody] User user)
        {
            userService.Create(user);
            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }


        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] User user)
        {

            var existinguser = userService.Get(id);
            if (existinguser == null)
            {
                return NotFound($"user with Id={id} not found");
            }
            userService.Update(id, user);

            return NoContent();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var existingStudent = userService.Get(id);
            if (existingStudent == null)
            {
                return NotFound($"user with Id={id} not found");
            }
            userService.Remove(id);
            return NoContent();
        }
    }

}