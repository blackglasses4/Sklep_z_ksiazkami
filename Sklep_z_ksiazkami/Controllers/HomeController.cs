using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sklep_z_ksiazkami.Data;
using Sklep_z_ksiazkami.Models;
using System.Diagnostics;

namespace Sklep_z_ksiazkami.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            IEnumerable<Book> books = _context.Book.ToList();
            return View(books);
        }

        public async Task<IActionResult> Add(int id)
        {
            //if (ModelState.IsValid)
            //{
            //    order.date = DateTime.Now;
            //    _context.Add(order);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //ViewData["BookId"] = new SelectList(_context.Book, "Id", "Id", order.BookId);
            //ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", order.UserId);
            //return View(order);
            IdentityUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            var order = new Order();
            order.BookId = id;
            order.UserId = user.Id;
            order.date = DateTime.Now;
            order.status = "Nowe";

            _context.Add(order);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult BookDetails(int id)
        {
            Book book = _context.Book.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}