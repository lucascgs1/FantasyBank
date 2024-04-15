using FantasyBank.Data;
using FantasyBank.Data.Interfaces;
using FantasyBank.Services;
using FantasyBank.Services.interfaces;

namespace FantasyBank.Portfolio.Api.Configuration
{
    public static class DependencyInjectionSetup
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            ArgumentNullException.ThrowIfNull(services);

            #region repositorios

            services.AddScoped<ITradeRepository, TradeRepository>();

            #endregion repositorios

            #region servicos

            services.AddTransient<ITradeService, TradeService>();

            #endregion servicos
        }
    }
}