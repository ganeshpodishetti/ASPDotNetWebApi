using CRUDOperations.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperations.Data.ViewModels
{
    public class UserVM
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string PhnNo { get; set; }
        public string Country { get; set; }

        //public List<AccountVM> Accounts { get; set; }
    }
}
