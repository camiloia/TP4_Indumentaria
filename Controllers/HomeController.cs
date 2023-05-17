using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4.Models;

namespace TP4.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

        public IActionResult Index()
    {
        ViewBag.EquiposIndumentaria=Equipos.EquiposIndumentaria;
        return View();
    }
    public IActionResult SelectIndumentaria()
    {
        ViewBag.ListaEquipos=Equipos.ListaEquipos;
        ViewBag.ListaMedias=Equipos.ListaMedias;
        ViewBag.ListaRemeras=Equipos.ListaRemeras;
        ViewBag.ListaPantalones=Equipos.ListaPantalones;
        return View();
    }
    public IActionResult GuardarIndumentaria(int Equipo, int Remera, int Pantalon, int Medias)
    {
        if(Equipo == null || Medias == null || Pantalon == null || Remera==null)
        {
            ViewBag.devolver="No se ingresaron todos los datos";
            return View("SelectIndumentaria");
        }
        else
        {
            Indumentaria indumentaria_ingresada = new Indumentaria(Equipos.ListaRemeras[Remera-1],Equipos.ListaPantalones[Pantalon-1], Equipos.ListaMedias[Medias-1]);
            Equipos.IngresarIndumentaria(Equipos.ListaEquipos[Equipo-1], indumentaria_ingresada);
            ViewBag.EquiposIndumentaria=Equipos.EquiposIndumentaria;
            return View("Index");
        }
        
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
