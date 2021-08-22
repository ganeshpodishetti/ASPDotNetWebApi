using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperations.Data.Models
{
    public class Account
    {
        [Key]
        public int CustomerId { get; set; }
        public long AccountNumber { get; set; }
        public string AccountType { get; set; }
        public double Balance { get; set; }
    }
}
