using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment_3.Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Assignment_3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public async Task<ActionResult<IList<User>>> GetUsers()
        {
            try
            {
                IList<User> users = await _userService.GetUsers();  //TODO: keep in mind for SEP: send only 1 user not a list
                return Ok(users);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}