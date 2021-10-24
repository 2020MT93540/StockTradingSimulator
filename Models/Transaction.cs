using System;
using System.ComponentModel.DataAnnotations;

namespace StockTradingSimulator.Models
{
    public class Transaction
    {
        public int _id { get; set; }
        public TransactionAccount[] transactionAccount { get; set; }

    }
    public class TransactionAccount
    {
        public int id { get; set; }
        public string userId { get; set; }
        public float InitialAmount { get; set; }

        public TransactionList[] transactionList { get; set; }

    }

    public class TransactionList
    {
        [Display(Name = "tId")]
        public int tId { get; set; }

        [Display(Name = "company")]
        public string company { get; set; }

        [Display(Name = "share")]
        public float share { get; set; }

        [Display(Name = "buyAt")]
        public float buyAt { get; set; }

        [Display(Name = "sellAt")]
        public float sellAt { get; set; }

        [Display(Name = "buyDatetime")]
        public string buyDatetime { get; set; }

        [Display(Name = "sellDatetime")]
        public string sellDatetime { get; set; }

    }
}