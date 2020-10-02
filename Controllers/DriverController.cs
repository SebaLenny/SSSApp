using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SSSApp.API.Data;

namespace SSSApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly DataContext dataContext;

        public DriverController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetDrivers()
        {
            var drivers = await dataContext.Driver.ToListAsync();
            return Ok(drivers);
        }

        [HttpGet("{driverId}")]
        public async Task<IActionResult> GetDrivers(int driverId)
        {
            var driver = await dataContext.Driver.FirstOrDefaultAsync(d => d.Id == driverId);
            return Ok(driver);
        }
    }
}