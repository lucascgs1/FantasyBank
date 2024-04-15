using FantasyBank.Model.interfaces;
using FantasyBank.Services.interfaces;

namespace FantasyBank.Services
{
    public class TradeService : ITradeService
    {
        public IEnumerable<string> CategorizeTrades(IEnumerable<ITrade> portfolio)
        {
            List<string> tradeCategories = new();

            foreach (var trade in portfolio)
            {
                if (trade.Value < 1000000 && trade.ClientSector == "Public")
                    tradeCategories.Add("LOWRISK");
                else if (trade.Value >= 1000000 && trade.ClientSector == "Public")
                    tradeCategories.Add("MEDIUMRISK");
                else if (trade.Value >= 1000000 && trade.ClientSector == "Private")
                    tradeCategories.Add("HIGHRISK");
            }

            return tradeCategories;
        }
    }
}