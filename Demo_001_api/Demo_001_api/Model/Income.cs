namespace Demo_001_api.Model
{
    public class Income
    {
        public int Id { get; set; }
        public string IncomeName { get; set; }
        public string IncomeDescription { get; set; }
        public string IncomeType { get; set; }
        public decimal Amount { get; set; } 
        public DateTime Time { get; set; }
        public string ImageUrl { get; set; }    
        public int Status { get; set; }

    }
}
