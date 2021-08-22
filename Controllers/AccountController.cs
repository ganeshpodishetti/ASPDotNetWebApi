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
    public class AccountController : ControllerBase
    {
        private AccountService _accountService;
        public AccountController(AccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("addAccount")]
        public IActionResult AddUser([FromBody] AccountVM user)
        {
            _accountService.AddAccount(user);
            return Ok();
        }
    }
}
