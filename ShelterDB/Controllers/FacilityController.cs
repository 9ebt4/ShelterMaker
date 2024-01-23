using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShelterDB.Models;

namespace ShelterDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacilityController : ControllerBase
    {
        private readonly ShelterdbContext _dbContext;
        private readonly ILogger<FacilityController> _logger;

        public FacilityController(ShelterdbContext dbContext, ILogger<FacilityController> logger)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllFacilityAsync()
        {
            try
            {
                var facilities = await _dbContext.Facilities.ToListAsync();
                if (facilities == null || facilities.Count == 0)
                {
                    _logger.LogWarning("No facilities found.");
                    return NotFound("No facilities found.");
                }

                return Ok(facilities);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred in GetAllFacilityAsync");
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }
    }
}
