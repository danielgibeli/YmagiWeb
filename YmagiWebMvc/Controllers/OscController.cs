using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YmagiWebMvc.Models;

namespace YmagiWebMvc.Controllers
{
    public class OscController : Controller
    {
        public IActionResult Index()
        {
            List<Osc> list = new List<Osc>();
            list.Add(new Osc { Id = 1, OSC = "Resolvi Mudar", Contato = "Paula", Telefone = "999945651" });
            list.Add(new Osc { Id = 2, OSC = "Casa do Vovô", Contato = "Waldemir", Telefone = "999945651" });
            return View(list);
        }
    }
}