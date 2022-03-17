using System.Text;

namespace StockMarket
{
    public class Stock
    {
        public Stock(string companyName, string director, decimal pricePerShare, int totalNumberOfShares)
        {
            CompanyName = companyName;
            Director = director;
            PricePerShare = pricePerShare;
            TotalNumberOfShares = totalNumberOfShares;
        }

        public string CompanyName { get; set; }
        public string Director { get; set; }
        public decimal PricePerShare { get; set; }
        public int TotalNumberOfShares { get; set; }
        public decimal MarketCapitalization => PricePerShare * TotalNumberOfShares;

        public override string ToString()
        {
            StringBuilder sv = new StringBuilder();
            sv.AppendLine($"Company: {this.CompanyName}");
            sv.AppendLine($"Director: {this.Director}");
            sv.AppendLine($"Price per share: ${this.PricePerShare:f2}");
            sv.AppendLine($"Market capitalization: ${this.MarketCapitalization:f2}");
            
            return sv.ToString();
        }
    }
}
