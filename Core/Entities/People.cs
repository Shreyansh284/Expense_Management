using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class People
    {
        public int PeopleID { get; set; }
        public string? PeopleCode { get; set; }
        public string Password { get; set; } = null!;
        public string PeopleName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public long MobileNo { get; set; }
        public string? Description { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }=null!;
       
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool? IsActive { get; set; } = true;

        public ICollection<Income> Incomes { get; set; }
        public ICollection<Expense> Expenses { get; set; }
        
    }
}
