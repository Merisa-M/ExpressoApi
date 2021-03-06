using ExpressoApi.Data;
using ExpressoApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpressoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReseravtionsController : ControllerBase
    {
        ExpressoDbContext _expressoDbContext;

        public ReseravtionsController(ExpressoDbContext expressoDbContext)
        {
            _expressoDbContext = expressoDbContext;
        }

        [HttpPost]
        public IActionResult Post(Reservation reservation)
        {
            _expressoDbContext.Reservations.Add(reservation);
            _expressoDbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
