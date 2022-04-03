using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace PaperTrades.Models
{
    public class Receipt
    { 
        //Data for other models
        [Key]
        public int ReceiptId {get;set;}

        [Required]
        public int UserId {get;set;}

        [Required]
        public int WalletId {get;set;}

        [Required]
        public double TransactionPrice {get;set;}

        [Required]
        public double Value {get;set;}

        [Required]
        public double Quantity { get; set;}

        public double Gain { get; set;}
        // {
        //     if(TransactionPrice > BuyInPrice)
        //     {
        //         get { return (Quantity * TransactionPrice) - (Quantity * BuyInPrice);}
        //     }
        // } 
        

        public double Loss { get; set; }
        // {
        //     if(TransactionPrice < BuyInPrice)
        //     {
        //         get { return (Quantity * BuyInPrice) - (Quantity * TransactionPrice)}
        //     }
        // }
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public User Owner {get;set;}

        public Wallet MyWallet {get;set;}

    }
}