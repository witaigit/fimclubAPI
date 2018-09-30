using System.Threading.Tasks;
using FilmClub.Services.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilmClub.Services.Controllers
{
    public class FilmsController : Controller
    {
        private readonly FilmClubContext _context;

        public FilmsController(FilmClubContext context) => _context = context;

        [HttpGet]
        public async Task<IActionResult> List() 
        {
            return Ok(await this._context.Films.ToListAsync());
        }
    }
}