 using CRUDOperations.Data.Models;
using CRUDOperations.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperations.Data.Services
{
    public class AccountService
    {
        private AppDbContext _context;

        public AccountService(AppDbContext context)
        {
            _context = context;
        }

        public void AddAccount(AccountVM user)
        {
            var _account = new Account()
            {
                //CustomerId = user.CustomerId,
                AccountNumber = user.AccountNumber,
                AccountType = user.AccountType,
                Balance = user.Balance
            };
            _context.accounts.Add(_account);
            _context.SaveChanges();
        }
    }
}
