using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
            Portfolio = new List<Stock>();
        }

        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }
        public List<Stock> Portfolio { get; set; }
        public int Count => this.Portfolio.Count;

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && MoneyToInvest > stock.PricePerShare)
            {
                Portfolio.Add(stock);
                MoneyToInvest -= stock.PricePerShare;
            }
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            var company = Portfolio.Where(x => x.CompanyName == companyName).FirstOrDefault();
            if (company==null)
            {
                return $"{companyName} does not exist.";
            }

            if (sellPrice < company.PricePerShare)
            {
                return $"Cannot sell {companyName}.";
            }

            Portfolio.Remove(company);
            MoneyToInvest += sellPrice;
            return $"{companyName} was sold.";
        }

        public Stock FindStock(string companyName)
        {
            var company = Portfolio.Where(x => x.CompanyName == companyName).FirstOrDefault();
            return company;
        }

        public Stock FindBiggestCompany()
        {
            var company = Portfolio.OrderByDescending(x => x.MarketCapitalization).FirstOrDefault();
            return company;
        }

        public string InvestorInformation()
        {
            StringBuilder sv = new StringBuilder();
            sv.AppendLine($"The investor {this.FullName} with a broker {this.BrokerName} has stocks:");
            foreach (var company in Portfolio)
            {
                sv.AppendLine(company.ToString().Trim());
            }

            return sv.ToString();
        }

    }
}
