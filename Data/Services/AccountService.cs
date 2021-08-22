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

        // Add Account
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

        // Get all accounts
        public List<Account> GetAllAccounts() => _context.accounts.ToList();

        // Get User By Id
        public Account GetAccountById(int Id)
        {
            var _userWithAccount = _context.accounts.Where(n => n.CustomerId == Id).Select(user => new Account()
            {
                CustomerId = user.CustomerId,
                AccountNumber = user.AccountNumber,
                AccountType = user.AccountType,
                Balance = user.Balance
            }).FirstOrDefault();

            return _userWithAccount;
        }

        public Account UpdateAccountById(int userId, AccountVM account)
        {
            var _account = _context.accounts.FirstOrDefault(n => n.CustomerId == userId);
            if (_account != null)
            {
                _account.AccountNumber = account.AccountNumber;
                _account.AccountType = account.AccountType;
                _account.Balance = account.Balance;
                _context.SaveChanges();
            }
            return _account;
        }

        public void DeleteAccountById(int userId)
        {
            var _user = _context.accounts.FirstOrDefault(n => n.CustomerId == userId);
            if (_user != null)
            {
                _context.accounts.Remove(_user);
                _context.SaveChanges();
            }
        }
    }
}
