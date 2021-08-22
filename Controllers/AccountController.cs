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

        [HttpGet("GetAllAccounts")]
        public IActionResult GetAllAccounts()
        {
            var allAccounts = _accountService.GetAllAccounts();
            return Ok(allAccounts);
        }

        [HttpGet("getAccountById/{id}")]
        public IActionResult GetUserById(int id)
        {
            var accountById = _accountService.GetAccountById(id);
            return Ok(accountById);
        }

        [HttpPut("updateAccountById/{id}")]
        public IActionResult UpdateAccountById(int id, [FromBody] AccountVM account)
        {
            var updateAccount = _accountService.UpdateAccountById(id, account);
            return Ok(updateAccount);
        }

        [HttpDelete("DeleteAccountById/{id}")]
        public IActionResult DeleteAccountById(int id)
        {
            _accountService.DeleteAccountById(id);
            return Ok();
        }
    }
}
