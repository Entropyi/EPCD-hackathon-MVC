using System.Diagnostics;
using epcdhackthon.Data;
using Microsoft.AspNetCore.Mvc;
using epcdhackthon.Models;

namespace epcdhackthon.Controllers;

public class FormController : Controller
{
    private readonly ApplicationDbContext _context;


    private readonly ILogger<HomeController> _logger;

    public FormController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(
        [Bind(
            "Id,FullNameInArabic,FullNameInEnglish,PhoneNumber,Email,Nationality,DateOfBirth,IdeaName,IdeaDescription,TeamName,CreationDate")]
        Request Requests)
    {
        if (ModelState.IsValid)
        {
            _context.Add(Requests);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View(Requests);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}