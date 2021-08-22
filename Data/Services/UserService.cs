using CRUDOperations.Data;
using CRUDOperations.Data.Models;
using CRUDOperations.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperations.Data.Services
{
    public class UserService
    {
        private AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public void AddUser(UserVM user)
        {
            var _user = new User()
            {
                Name = user.Name,
                Age = user.Age,
                Gender = user.Gender,
                PhnNo = user.PhnNo,
                Country = user.Country,
                Accounts = user.Accounts.ToList()
            };
            _context.users.Add(_user);
            _context.SaveChanges();
        }

        public List<User> GetAllUsers() => _context.users.ToList();

        public User GetUserById(int userId)
        {
            var _userWithAccount = _context.users.Where(n=> n.UserId == userId).Select(user => new User()
            {
                Name = user.Name,
                Age = user.Age, 
                Gender = user.Gender,
                PhnNo = user.PhnNo,
                Country = user.Country,
                Accounts = user.Accounts
            }).FirstOrDefault();

            return _userWithAccount;
        }

        //public User GetUserById(int userId) => _context.users.FirstOrDefault(n => n.UserId == userId);

        public User UpdateUserById(int userId, UserVM user)
        {
            var _user = _context.users.FirstOrDefault(n => n.UserId == userId);
            if(_user != null)
            {
                _user.Name = user.Name;
                _user.Age = user.Age;
                _user.Gender = user.Gender;
                _user.PhnNo = user.PhnNo;
                _user.Country = user.Country;
                //_user.Accounts = user.Accounts;
                _context.SaveChanges();
            }
            return _user;
        }

        public void DeleteUserById(int userId)
        {
            var _user = _context.users.FirstOrDefault(n => n.UserId == userId);
            if(_user!=null)
            {
                _context.users.Remove(_user);
                _context.SaveChanges();
            }
        }
    }
}
