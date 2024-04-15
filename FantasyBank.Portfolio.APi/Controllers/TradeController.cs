using AutoMapper;
using FantasyBank.Model;
using FantasyBank.Portfolio.Api.ViewModel;
using FantasyBank.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FantasyBank.Portfolio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly ILogger<TradeController> _logger;

        public TradeController(ILogger<TradeController> logger, IMapper mapper)
        {
            _mapper = mapper;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult GetCategorizedRisk([FromServices] ITradeService tradeService, [FromBody] List<TradeDTO> portfolio)
        {
            try
            {
                var model = _mapper.Map<IList<Trade>>(portfolio);

                return Ok(tradeService.CategorizeTrades(model));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return Problem(ex.Message);
            }
        }
    }
}