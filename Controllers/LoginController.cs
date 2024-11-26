using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bibliotec.Contexts;
using Microsoft.EntityFrameworkCore;
using Bibliotec.Models;

namespace Bibliotec.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        Contest context = new Contest();

        [Route ("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            string emailInformado = form["Email"];
            string senhaInformada = form["Senha"];
         
                Usuario usuarioBuscado = context.Usuario.FirstOrDefault(usuario => usuario.Email == emailInformado && usuario.Senha == senhaInformada)!;
         




if (usuarioBuscado == null)
{
Console.WriteLine($"Dados Invalidos!!");
return LocalRedirectResult("~/Login");

} else {
    Console.WriteLine($"Eba voce entrou!");
    HttpContext.Session.SetString("UsuarioID", usuarioBuscado.UsuarioId.ToString());
    HttpContext.Session.SetString("Admin", usuarioBuscado.Admin.ToString());
    return LocalRedirectResult("~/Livro");
}
            return View();
        }

        private IActionResult LocalRedirectResult(string v)
        {
            throw new NotImplementedException();
        }

        public IActionResult Index()
        {
            return View();
        }


        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}