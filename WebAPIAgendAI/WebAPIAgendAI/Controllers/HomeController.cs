using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAPIAgendAI.Models;

namespace WebAPIAgendAI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
       
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            return View();
        }
        [Authorize]
        public IActionResult CreateAgendamento()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAgendamento([Bind("Data,Quantidade,Sala,EmailInstitucional,FuncionarioId,Tipo")] Agendamento agendamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(agendamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(agendamento);
        }
        [Authorize]
        // GET: Home/ListaAgendamento/5
        [HttpGet, ActionName("ListaAgendamento")]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> ListaAgendamento(int id, Funcionario funcionario, Agendamento agendamento)
        //{
        ////    if (funcionario.EmailInstitucional == null)
        ////    {
        ////        return View(await _context.Agendamentos.ToListAsync());
        ////    }

        ////    if (funcionario.EmailInstitucional == agendamento.EmailInstitucional)
        ////    {

        ////        return View(await _context.Agendamentos.Where(o => o.Id == id).ToListAsync());

        ////    }

        //    return View(await _context.Agendamentos.ToListAsync());
        //}

        public async Task<IActionResult> ListaAgendamento()
        {
            return View(await _context.Agendamentos.ToListAsync());
        }
    }
}
