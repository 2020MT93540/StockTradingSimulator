using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StockTradingSimulator.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace StockTradingSimulator.Controllers
{
    public class DashboardController : Controller
	{
        int CurrentPageIndex = 1;

        public ActionResult Index()
		{
			return View();
        }
        [HttpGet]
        public JsonResult TransactionDetails()
        {
            int maxRows = 10;
            ViewBag.BalanceAmount = "Your contact page.";
            ViewBag.CurrentStatus = "CurrentStatus";
            string jsonString = System.IO.File.ReadAllText(Server.MapPath("~/Data/transaction.json"));
            Transaction jsonObject = JsonConvert.DeserializeObject<Transaction>(jsonString);


            var filteredData = jsonObject.transactionAccount.Where(x => x.userId == "1")
                        .Skip((CurrentPageIndex - 1) * maxRows)
                        .Take(maxRows).ToList(); ;
            
            //TransactionModel transactionModel = new TransactionModel();
            //transactionModel.transactionAccount = (filteredData);
            //double pageCount = (double)((decimal)filteredData[0].transactionList.Count() / Convert.ToDecimal(maxRows));
            //transactionModel.PageCount = (int)Math.Ceiling(pageCount);
            //transactionModel.CurrentPageIndex = currentPageIndex;

            return Json(filteredData, JsonRequestBehavior.AllowGet);


        }
    }
}