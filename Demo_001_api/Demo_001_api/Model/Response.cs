namespace Demo_001_api.Model
{
    public class Response
    {
        public int Id { get; set; } 
        public int StatusCode { get; set; } 
        public string StatusMessage { get; set; }
        public List<User> Users { get; set; }
        public User user { get; set; }

        public List<Income> Incomes { get; set; }
        public Income income { get; set; }
        public List<Expense> Expenses { get; set; } 
        public Expense expense { get; set; }
    }
}
