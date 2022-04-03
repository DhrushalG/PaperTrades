using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PaperTrades.Models
{
    public class User{
        [Key]
        public int UserId {get;set;}

        [Required]
        [MinLength(2)]
        public string Name {get;set;}

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{4,20}$", 
        ErrorMessage = "UserName must be atleast 4 characters. Also must contain atleast one uppercase, lowercase, and numerical value")]
        // [StringLength(20, MinimumLength = 4)]
        [Required]
        public string? UserName {get;set;}
        
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password {get;set;}

        [Required]
        public double BuyingPwr {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPass {get;set;}
        public List<Wallet> myWallets { get; set; }
        public List<Receipt> Receipts { get; set; }
    }
}