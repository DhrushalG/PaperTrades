using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PaperTrades.Models
{
    public class Wallet{
        [Key]
        public int WalletId {get;set;}

        [Required]
        public string IsTracking {get;set;}

        [Required]
        public double Quantity {get;set;}

        public double AvgBuyingPrice { get; set;}

        [Required]
        public double BuyInPrice { get; set;}

        [Required]
        public double CurrPrice { get; set;}

        [Required]
        public double Value 
            { 
            get { return Quantity * AvgBuyingPrice;}
            }
        public double Profit { get; set; }
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public int UserId {get;set;}
        public User Owner {get;set;}
        public List<Receipt> myReceipts { get; set; }
    }
}