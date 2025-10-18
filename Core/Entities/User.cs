using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Core.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string Password { get; set; } = null!;
        public long MobileNo { get; set; }
        public string? ProfileImage { get; set; }
        public DateTime Created { get; set; }= DateTime.Now;
        public DateTime Modified { get; set; }=DateTime.Now;
        public bool? IsActive { get; set; } = true;

        public ICollection<People> Peoples { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Income> Incomes { get; set; }
        public ICollection<Expense> Expenses { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }


    }
}
