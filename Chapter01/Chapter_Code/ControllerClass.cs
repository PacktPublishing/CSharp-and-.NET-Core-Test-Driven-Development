using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Good_Code
{
    public class ControllerClass
    {
        public void SendSMS()
        {
            smppManager.SendMessage("0802312345", "Hello", "John");
        }


        [HttpGet]
        public ActionResult GetAllTransactions()
        {
            var yearsAndMonths = GetYearsAndMonths();
            ViewBag.Transactions = GetTransactions(yearsAndMonths.Item1, yearsAndMonths.Item2);
            return View();
        }

        [HttpGet]
        public ActionResult SearchTransactions()
        {
            var yearsAndMonths = GetYearsAndMonths();
            ViewBag.Years = yearsAndMonths.Item1;
            ViewBag.Months = yearsAndMonths.Item2;
            return View();
        }

        private List<Transaction> GetTransactions(List<string> years, List<string> month)
        {
            return new List<Transaction>();
        }

        private (List<string>, List<string>) GetYearsAndMonths()
        {
            List<string> years = new List<string>();
            for (int i = DateTime.Now.Year; i >= 2015; i--)
                years.Add(i.ToString());
            List<string> months = new List<string>();
            for (int j = 1; j <= 12; j++)
                months.Add(j.ToString());
            return (years, months);
        }


        public void ProcessTransaction(Transaction transaction)
        {
            //Do something
        }
    }
}
