using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using StockTradingSimulator.Models;

namespace StockTradingSimulator.Controllers
{
    public class TradingController : Controller
    {
        // GET: Trading
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sell()
        {
            int maxRows = 10;
            ViewBag.BalanceAmount = "Your contact page.";
            ViewBag.CurrentStatus = "CurrentStatus";
            string jsonString = System.IO.File.ReadAllText(Server.MapPath("~/Data/transaction.json"));
            Transaction jsonObject = JsonConvert.DeserializeObject<Transaction>(jsonString);
           int scripID= Convert.ToInt32(Request.QueryString.Get("id"));

            var filteredData = jsonObject.transactionAccount.Where(x => x.userId == "1")
                                                .Take(maxRows).ToList();

            var scrip = filteredData[0].transactionList[scripID];

            return View(scrip);
        }
        public ActionResult Buy()
        {
            return View();
        }
    }
}