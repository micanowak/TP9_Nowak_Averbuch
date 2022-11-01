using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP9_Nowak_Averbuch.Models;

namespace TP9_Nowak_Averbuch.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult GuardarReserva(DateTime fechaIN, DateTime fechaOUT, int fkHotel, int fkHabitacion, string Nombre, int DNI)
    {
        int id = BD.ReservarHabitacion(fechaIN, fechaOUT, fkHotel, fkHabitacion, Nombre, DNI);
        ViewBag.IdReserva = id;
        return View("MostrarId");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
