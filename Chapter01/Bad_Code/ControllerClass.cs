using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Bad_Code
{
    public class ControllerClass
    {
        [HttpGet]
        public ActionResult GetAllTransactions()
        {
            List<string> years = new List<string>();
            for (int i = DateTime.Now.Year; i >= 2015; i--)
                years.Add(i.ToString());
            List<string> months = new List<string>();
            for (int j = 1; j <= 12; j++)
                months.Add(j.ToString());
            ViewBag.Transactions = GetTransactions(years, months);
            return View();
        }


        [HttpGet]
        public ActionResult SearchTransactions()
        {
            List<string> years = new List<string>();
            for (int i = DateTime.Now.Year; i >= 2015; i--)
                years.Add(i.ToString());
            List<string> months = new List<string>();
            for (int j = 1; j <= 12; j++)
                months.Add(j.ToString());
            ViewBag.Years = years;
            ViewBag.Months = months;
            return View();
        }

        private List<Transaction> GetTransactions(List<string> years, List<string> month)
        {
            return new List<Transaction>();
        }

        public void ProcessTransaction(string username, string password, float transactionAmount, string transactionType, DateTime time, bool canProcess, bool retryOnfailure)
        {
            //Do something
        }

        public void SendSMS()
        {
            SmppManager smppManager = new SmppManager();
            smppManager.SendMessage("0802312345", "Hello", "John");
        }
    }
}
