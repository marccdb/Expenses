using Microsoft.EntityFrameworkCore;
using ExpensesAPI.Models;

namespace ExpensesAPI.Data
{
    public class ExpensesContext : DbContext
    {

        public ExpensesContext(DbContextOptions<ExpensesContext> options) : base(options)
        {

        }

        public DbSet<Expense> Expenses { get; set; }

    }
}
