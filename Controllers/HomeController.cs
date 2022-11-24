using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP9_Nowak_Averbuch.Models;

namespace TP9_Nowak_Averbuch.Controllers;

public class HomeController : Controller
{
       public IActionResult Index()
    {
        ViewBag.ListaHabitaciones = BD.VerHabitaciones();
        return View();
    }
    
    public Reserva BuscarReservaAjax(int IdReserva){
        return BD.BuscarReserva(IdReserva);
    }
    public IActionResult ModificarReserva()
    {
        return View();
    }
    public Habitacion VerDetalleHabitacionesAjax(int IdHab){
        ViewBag.ListaSeries  = BD.BuscarReserva(IdHab);
        return ViewBag.ListaSeries;
    }

    [HttpPost]
    public IActionResult GuardarModificacionReserva(Reserva res)
    {
        BD.Modificar(res);
        return View("ModificarReserva");
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
