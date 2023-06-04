using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebAPIAgendAI.Models;

namespace WebAPIAgendAI.Controllers
{
    //[Authorize (Roles ="Administrador")]
    public class FuncionariosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly int _id;
        public FuncionariosController(ApplicationDbContext context)
        {
            _context = context;
        }
       
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login([Bind("EmailInstitucional,Senha,Perfil")] Funcionario funcionario)
        {
            var usuario = await _context.Funcionarios
                .FirstOrDefaultAsync(m => m.EmailInstitucional == funcionario.EmailInstitucional);
            var idUser = usuario.Id;
            if (usuario == null)
            {
                ViewBag.Message = "Funcionário e/ou Senha inválidos!";
                return View();
            }

            bool isSenhaOk = BCrypt.Net.BCrypt.Verify(funcionario.Senha, usuario.Senha);
            bool perfilOk = Equals(funcionario.Perfil, usuario.Perfil);
            if (usuario.Perfil!= funcionario.Perfil)
            {
                ViewBag.Message = "Perfil inválido!";
                return View();
            }

            if (isSenhaOk && perfilOk)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usuario.Nome),
                    new Claim(ClaimTypes.NameIdentifier, usuario.Nome),
                    new Claim(ClaimTypes.Role, usuario.Perfil.ToString())
                };

                var idUsuario = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(idUsuario);

                var propriedades = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddDays(30),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, propriedades);

                return Redirect("/");

            }

            ViewBag.Message = "Funcionário e/ou Senha inválidos!";
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Funcionarios");
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
        // GET: Funcionarios    
        public async Task<IActionResult> Index()
        {
            return View(await _context.Funcionarios.ToListAsync());
        }
       
        // GET: Funcionarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }
        //[Authorize]
        public async Task<IActionResult> Agendamentos(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionarios
                 .Include(t => t.Agendamentos)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }
        // GET: Funcionarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Funcionarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,EmailInstitucional,Senha,Perfil")] Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                funcionario.Senha = BCrypt.Net.BCrypt.HashPassword(funcionario.Senha);
                _context.Add(funcionario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(funcionario);
        }

        // GET: Funcionarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionarios.FindAsync(id);
            if (funcionario == null)
            {
                return NotFound();
            }
            return View(funcionario);
        }

        // POST: Funcionarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,EmailInstitucional,Senha,Perfil")] Funcionario funcionario)
        {
            if (id != funcionario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    funcionario.Senha = BCrypt.Net.BCrypt.HashPassword(funcionario.Senha);
                    _context.Update(funcionario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuncionarioExists(funcionario.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(funcionario);
        }

        // GET: Funcionarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }

        // POST: Funcionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var funcionario = await _context.Funcionarios.FindAsync(id);
            _context.Funcionarios.Remove(funcionario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FuncionarioExists(int id)
        {
            return _context.Funcionarios.Any(e => e.Id == id);
        }

    }
}
