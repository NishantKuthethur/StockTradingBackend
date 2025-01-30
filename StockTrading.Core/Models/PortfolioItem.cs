using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrading.Core.Models
{
    public class PortfolioItem
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public required Stock Stock { get; set; }
        public int UserId { get; set; }
        public required User User { get; set; }
        public int Quantity { get; set; }
        public double AverageBuyingPrice { get; set; }

        [NotMapped]
        public double CurrentMarketPrice => Stock.LastTradedPrice;

        [NotMapped]
        public double Investment => Quantity * AverageBuyingPrice;

        [NotMapped]
        public double CurrentValue => Quantity * CurrentMarketPrice;

        [NotMapped]
        public double ProfitOrLoss => CurrentValue - Investment;

        [NotMapped]
        public double ProfitOrLossPercentage => Investment != 0
            ? (ProfitOrLoss / Investment) * 100
            : 0;
    }
}
