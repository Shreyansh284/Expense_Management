using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Income
    {
        public int IncomeID { get; set; }
        public DateTime IncomeDate { get; set; }
        public int? CategoryID { get; set; }
        public Category Category { get; set; }
        public int? SubCategoryID { get; set; }
        public SubCategory SubCategory { get; set; }
        public int PeopleID { get; set; }
        public People People { get; set; }  
        public int? ProjectID { get; set; }
        public Project Project { get; set; }
        public decimal Amount { get; set; }
        public string? IncomeDetail { get; set; }
        public string? AttachmentPath { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }=true;
        public int UserID { get; set; }
        public User User { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

    }
}
