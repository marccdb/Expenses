using ExpensesAPI.Models;

namespace ExpensesAPI.Data
{
    public interface IExpensesRepo
    {
        bool SaveChanges();

        IEnumerable<Expense> GetExpenses();
        Expense GetExpenseById(int id);
        void AddExpense(Expense expense);
        void UpdateExpense(Expense expense);
        void DeleteExpense(Expense expense);

    }
}
