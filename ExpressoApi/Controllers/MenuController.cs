using ExpressoApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ExpressoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        ExpressoDbContext _expressoDbContext;

        public MenuController(ExpressoDbContext expressoDbContext)
        {
            _expressoDbContext = expressoDbContext;
        }
        [HttpGet]
        public IActionResult GetMenus() {
            var menus = _expressoDbContext.Menus.Include("SubMenus");
            return Ok(menus);   
        }
        [HttpGet("{id}")]
        public IActionResult GetMenus(int id)
        {
            var menus = _expressoDbContext.Menus.Include("SubMenus").FirstOrDefault(m=>m.Id == id);
            if(menus == null)
                return NotFound();
            return Ok(menus);
        }
    }
}
