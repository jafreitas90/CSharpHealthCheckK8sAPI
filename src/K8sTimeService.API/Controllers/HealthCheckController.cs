using Microsoft.AspNetCore.Mvc;

namespace K8sTimeService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {
        private static bool _isHealthy = true;
        private readonly ILogger<HealthCheckController> _logger;

        public HealthCheckController(ILogger<HealthCheckController> logger)
        {
            _logger = logger;
        }

        // Health check endpoint
        [HttpGet]
        public IActionResult GetHealth()
        {
            if (_isHealthy)
            {
                _logger.LogInformation("Health check: Healthy");
                return Ok("Healthy");
            }
            else
            {
                _logger.LogWarning("Health check: Unhealthy");
                return StatusCode(500, "Unhealthy");
            }
        }

        // Endpoint to toggle health status for testing
        [HttpPost("toggle-health")]
        public IActionResult ToggleHealth()
        {
            _isHealthy = !_isHealthy;
            _logger.LogInformation($"Health status changed to: {(_isHealthy ? "Healthy" : "Unhealthy")}");
            return Ok($"Health status changed to: {(_isHealthy ? "Healthy" : "Unhealthy")}");
        }
    }
}
