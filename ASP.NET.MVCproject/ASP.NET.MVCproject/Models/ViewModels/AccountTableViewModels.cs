using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.Models.ViewModels
{
    public class AccountTableViewModels
    {
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Remark { get; set; }
    }
}