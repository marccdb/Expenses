using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExpensesAPI.Models;

namespace ExpensesAPI.Data
{
    public class ExpensesRepo : IExpensesRepo
    {

        private readonly ExpensesContext _context;

        public ExpensesRepo(ExpensesContext context)
        {
            _context = context;
        }

        public void AddExpense(Expense expense)
        {
            if (expense != null)
            {
                throw new Exception("Please enter a valid expense.");
            }

            _context.Expenses.Add(expense);

        }

        public void DeleteExpense(Expense expense)
        {
            if(expense != null)
            {
                throw new Exception("Please enter a valid expense.");
            }

            _context.Expenses.Remove(expense);
        }

        public Expense GetExpenseById(int id)
        {
            return _context.Expenses.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Expense> GetExpenses()
        {
            return _context.Expenses.ToList();
        }

        public void UpdateExpense(Expense expense)
        {
            if (expense != null)
            {
                throw new Exception("Please enter a valid expense.");
            }

            _context.Expenses.Update(expense);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }


    }
}
