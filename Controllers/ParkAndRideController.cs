using Microsoft.AspNetCore.Mvc;
using Pro.APIConsume.Infrastructure.Interfaces;
using Pro.APIConsume.Infrastructure.Services;

namespace Pro.APIConsume.Controllers
{
    [ApiController]
    [Route("[controller]/api/")]
    public class ParkAndRideController : ControllerBase
    {
        private readonly IHSLParkAndRideService _consumer;
        private readonly ILogger<ParkAndRideController> _logger;
        public ParkAndRideController(IHSLParkAndRideService consumer, ILogger<ParkAndRideController> logger)
        {
            _consumer = consumer;
            _logger = logger;
        }

        /// <summary>
        /// Services provided by a facility.
        /// </summary>
        [HttpGet("services")]
        public async Task<IActionResult> GetServices()
        {
            var services = await _consumer.GetServices();
            return Ok(services);
        }

        /// <summary>
        /// All facilities are operated by an operator.
        /// </summary>
        [HttpGet("operators")]
        public async Task<IActionResult> GetOperators()
        {
            var services = await _consumer.GetOperators();
            return Ok(services);
        }

        /// <summary>
        /// Pricing method is a shortcut for maintaining actual 
        /// facility pricing information.
        /// </summary>
        [HttpGet("pricingmethods")]
        public async Task<IActionResult> GetPricingMethods()
        {
            var services = await _consumer.GetPricingMethods();
            return Ok(services);
        }

        /// <summary>
        /// Payment methods accepted by a facility.
        /// </summary>
        [HttpGet("paymentmethods")]
        public async Task<IActionResult> GetPaymentMethods()
        {
            var services = await _consumer.GetPaymentMethods();
            return Ok(services);
        }

        /// <summary>
        /// Facility status indicates whether the facility is operating normally 
        /// or is exceptionally closed.
        /// </summary>
        [HttpGet("facilitystatuses")]
        public async Task<IActionResult> GetFacilityStatuses()
        {
            var services = await _consumer.GetFacilityStatuses();
            return Ok(services);
        }
    }
}
