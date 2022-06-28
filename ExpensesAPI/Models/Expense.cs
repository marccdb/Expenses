using ExpensesAPI.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ExpensesAPI.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        public string ExpenseName { get; set; }
        [Required]
        public string EstablishmentName { get; set; }

        public DateTime Date { get; set; }
        
        public ExpenseCategory Category { get; set; }
        [Required]
        public double Amount { get; set; }


    }
}
