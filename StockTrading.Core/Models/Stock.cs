using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrading.Core.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public required string Symbol { get; set; }
        public required string Name { get; set; }
        public double LastTradedPrice { get; set; }
        public double PreviousClosingPrice { get; set; }
        public double UpperCircuitLimit { get; set; }
        public double LowerCircuitLimit { get; set; }

        [NotMapped]
        public double Change => PreviousClosingPrice != 0
            ? ((LastTradedPrice - PreviousClosingPrice) / PreviousClosingPrice) * 100
            : 0;
    }
    public class StockSearchResult
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Currency { get; set; }
    }
    public class StockData
    {
        public string Symbol { get; set; }
        public Dictionary<DateTime, StockPrice> TimeSeries { get; set; }

    }

    public class StockPrice
    {
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public int Volume { get; set; }
    }
}