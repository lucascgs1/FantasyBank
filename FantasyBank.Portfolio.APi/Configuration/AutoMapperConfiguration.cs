using AutoMapper;
using FantasyBank.Model;
using FantasyBank.Portfolio.Api.ViewModel;

namespace FantasyBank.Portfolio.Api.Configuration
{
    public static class AutoMapperConfiguration
    {
        public static void AddMapperSetup(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Trade, TradeDTO>();
                cfg.CreateMap<TradeDTO, Trade>();
            });

            IMapper mapper = mapperConfig.CreateMapper();
        }
    }
}