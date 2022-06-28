using ExpensesAPI.Models.Enums;

namespace ExpensesAPI.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string ExpenseName { get; set; }
        public string EstablishmentName { get; set; }
        public DateTime Date { get; set; }
        public ExpenseCategory Category { get; set; }
        public double Amount { get; set; }


    }
}
