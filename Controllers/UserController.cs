using CRUDOperations.Data.Services;
using CRUDOperations.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        } 


        [HttpGet("getAllUsers")]
        public IActionResult GetAllUsers()
        {
            var allUsers = _userService.GetAllUsers();
            return Ok(allUsers);
        } 

        [HttpGet("getUserById/{id}")]
        public IActionResult GetUserById(int id)
        {
            var userById = _userService.GetUserById(id);
            return Ok(userById);
        }

        [HttpPost("addUserWithAccount")]
        public IActionResult AddUser([FromBody]UserVM user)
        {
            _userService.AddUser(user);
            return Ok();
        }

        [HttpPut("updateUserById/{id}")]
        public IActionResult UpdateUserById(int id, [FromBody]UserVM user)
        {
            var updatedUser = _userService.UpdateUserById(id, user);
            return Ok(updatedUser);
        }

        [HttpDelete("DeleteUserById/{id}")]
        public IActionResult DeleteBookById(int id)
        {
            _userService.DeleteUserById(id);
            return Ok();
        }
    }
}
