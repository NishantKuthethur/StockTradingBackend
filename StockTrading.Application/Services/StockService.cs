using Newtonsoft.Json;
using StockTrading.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockTrading.Application.Services
{
    //public interface IStockService
    //{
    //    Task<StockData> GetStockByTickerAsync(string ticker);
    //    Task<IEnumerable<StockSearchResult>> SearchStocksAsync(string keyword);
    //    Task<IEnumerable<StockSearchResult>> GetStocksByMarketAsync(string market);
    //}
    //public class StockService : IStockService
    //{
    //    private readonly HttpClient _httpClient;
    //    private readonly string _apiKey;

    //    public StockService(HttpClient httpClient, IConfiguration configuration)
    //    {
    //        _httpClient = httpClient;
    //        _apiKey = configuration["AlphaVantage:ApiKey"];
    //        _httpClient.BaseAddress = new Uri("https://www.alphavantage.co/");
    //    }
    //    public async Task<StockData> GetStockByTickerAsync(string ticker)
    //    {
    //        try
    //        {
    //            string query = $"query?function=TIME_SERIES-INTRADAY&symbol={ticker}&interval=5min&apikey={_apiKey}";
    //            var response = await _httpClient.GetFromJsonAsync<AlphaVantageTimeSeriesResponse>(query);

    //            return new StockData
    //            {
    //                Symbol = ticker,
    //                TimeSeries = response.TimeSeries.ToDictionary(
    //                    k => DateTime.Parse(k.Key),
    //                    v => new StockPrice
    //                    {
    //                        Open = v.Value.Open,
    //                        High = v.Value.High,
    //                        Low = v.Value.Low,
    //                        Close = v.Value.Close,
    //                        Volume = v.Value.Volume
    //                    })
    //            };
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("Failed to fetch stock data", ex);
    //        }
    //    }
    //    public async Task<IEnumerable<StockSearchResult>> GetStocksByMarketAsync(string market)
    //    {
    //        try
    //        {
    //            var results = await SearchStocksAsync(market);
    //            return results.Where(r => r.Region.Contains(market, StringComparison.OrdinalIgnoreCase));
    //        }
    //        catch (Exception ex) { throw new Exception("", ex); }
    //    }

    //    public async Task<IEnumerable<StockSearchResult>> SearchStocksAsync(string keyword)
    //    {
    //        try
    //        {
    //            string query = $"query=SYMBOL_SEARCH&keywords={keyword}&apikey={_apiKey}";
    //            var result = await _httpClient.GetFromJsonAsync<AlphaVantageSearchResponse>(query);

    //            return result.BestMatches.Select(r => new StockSearchResult
    //            {
    //                Symbol = r.Symbol,
    //                Name = r.Name,
    //                Region = r.Region,
    //                Currency = r.Currency
    //            });
    //        }
    //        catch (Exception ex) { throw new Exception("", ex); }
    //    }

    //    private class AlphaVantageSearchResponse
    //    {
    //        public IEnumerable<BestMatch> BestMatches { get; set; }
    //    }

    //    private class BestMatch
    //    {
    //        [JsonProperty("1. symbol")]
    //        public string Symbol { get; set; }
    //        [JsonProperty("2. name")]
    //        public string Name { get; set; }
    //        [JsonProperty("4. region")]
    //        public string Region { get; set; }
    //        [JsonProperty("8. currency")]
    //        public string Currency { get; set; }
    //    }

    //    private class AlphaVantageTimeSeriesResponse
    //    {
    //        public Dictionary<string, TimeSeriesData> TimeSeries { get; set; }
    //    }

    //    private class TimeSeriesData
    //    {
    //        [JsonProperty("1:open")]
    //        public decimal Open { get; set; }
    //        [JsonProperty("2:high")]
    //        public decimal High { get; set; }
    //        [JsonProperty("3:low")]
    //        public decimal Low { get; set; }
    //        [JsonProperty("4:close")]
    //        public decimal Close { get; set; }
    //        [JsonProperty("5:volume")]
    //        public int Volume { get; set; }

    //    }
    //}
}
