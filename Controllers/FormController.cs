using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using epcdhackthon.Models;

namespace epcdhackthon.Controllers;

public class FormController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public FormController(ILogger<HomeController> logger)
    {
        _logger = logger;
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
}