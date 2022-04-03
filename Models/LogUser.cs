using System;
using System.ComponentModel.DataAnnotations;

namespace PaperTrades.Models
{
    public class LogUser
    {
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{4,20}$")]
        public string LUserName {get;set;}
        [Required]
        [DataType(DataType.Password)]
        public string LPassword {get;set;}
    }
}