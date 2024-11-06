using Microsoft.EntityFrameworkCore;

namespace Demo_001_api.Model
{
    public class AppDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Response> Responses { get; set; }  
        public DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions options): base(options)
        {
            
        }
    }
}
