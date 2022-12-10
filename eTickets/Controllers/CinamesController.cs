using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class CinamesController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public CinamesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task <IActionResult> Index()
        {
            var allCiname = await _appDbContext.Cinema.ToListAsync();
            return View(allCiname);
        }
    }
}
