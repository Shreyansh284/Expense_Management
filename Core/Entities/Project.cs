using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; } = null!;
        public string? ProjectLogo { get; set; }
        public DateTime? ProjectStartDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public string? ProjectDetail { get; set; }
        public string? Description { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool? IsActive { get; set; }=true;

        public ICollection<Expense> Expenses { get; set; }
        public ICollection<Income> Incomes { get; set; }   
    }
}
