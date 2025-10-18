using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public  class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? LogoPath { get; set; }
        public bool IsExpense { get; set; }= true;
        public bool IsIncome { get; set; } = true;
        public bool IsActive { get; set; } = true;
        public string? Description { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public decimal? Sequence { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
        public ICollection<Income> Incomes { get; set; }    
        public ICollection<Expense> Expenses { get; set; } 
    }
}
