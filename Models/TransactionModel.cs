using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockTradingSimulator.Models
{
    public class TransactionModel
    {
        public List<TransactionAccount> transactionAccount { get; set; }

        ///<summary>
        /// Gets or sets CurrentPageIndex.
        ///</summary>
        public int CurrentPageIndex { get; set; }

        ///<summary>
        /// Gets or sets PageCount.
        ///</summary>
        public int PageCount { get; set; }
    }
}