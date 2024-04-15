using FantasyBank.Data.Interfaces;
using FantasyBank.Model;

namespace FantasyBank.Data
{
    public class TradeRepository : Repository<Trade>, ITradeRepository
    {
        private readonly ApplicationDbContext _context;

        public TradeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}