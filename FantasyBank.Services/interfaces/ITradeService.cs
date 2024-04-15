using FantasyBank.Model.interfaces;

namespace FantasyBank.Services.interfaces
{
    public interface ITradeService
    {
        IEnumerable<string> CategorizeTrades(IEnumerable<ITrade> portfolio);
    }
}