using frontend.Models;
using frontend.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace frontend.Controllers;

public class HomeController : Controller
{
    private readonly IPizzaService _service;
    public IEnumerable<PizzaInfo> Pizzas;
    public HomeController(IPizzaService service)
    {
        _service = service;
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult GetPizzas()
    {
        Pizzas = _service.GetPizzas();

        if (Pizzas is null)
            return View("Error");

        return View(Pizzas);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}