using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperations.Data.Models
{
    public class User
    {
        public int UserId { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string PhnNo { get; set; }
        public string Country { get; set; }

        // Navigation Properties
        public List<Account> Accounts { get; set; }
    }
}
