using _02_DispositivosEletronicos.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02_DispositivosEletronicos.Controllers
{
    public class DispositivoController : Controller
    {
        public IActionResult Index()
        {
            List<DispositivoEletronico> dispositivos = new List<DispositivoEletronico>
            {
                new Computador { Marca = "Dell", Modelo = "Inspirion", AnoDeFabricacao = 2021,  EhLaptop = true, MemoriaRam = 16, SistemaOperacional = "Windows 11" },
                new Computador { Marca = "Samsung", Modelo = "Inspirion", AnoDeFabricacao = 2021,  EhLaptop = false, MemoriaRam = 16, SistemaOperacional = "Windows 11" }
            };
            return View(dispositivos);
        }
    }
}
