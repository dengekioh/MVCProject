using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;
using MVCProject.Models.ViewModels;

namespace MVCProject.Controllers
{
    public class AccountTableController : Controller
    {
        // GET: AccountTable
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult Submit()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult AccountTable()
        {
            return View(this.CreateAccountTables(100));
        }
        private string RandomCategory(int rowNumber)
        {
            if ((rowNumber % 2) == 0)
                return "收入";
            else
                return "支出";
        }
        private List<AccountTableViewModels> CreateAccountTables(int rowCount)
        {
            List<AccountTableViewModels> accountTableList = new List<AccountTableViewModels>();
            Random rnd = new Random();

            for (int i = 1; i <= rowCount; i++)
            {
                var accountTable = new AccountTableViewModels()
                {
                    Date = DateTime.Now.AddDays(rnd.Next(0, 30)),
                    Amount = (Decimal)rnd.Next(10, 10000),
                    Category = this.RandomCategory(rnd.Next(0, 100) % 2),
                };
                accountTableList.Add(accountTable);
            }
            return accountTableList;
        }
    }
}