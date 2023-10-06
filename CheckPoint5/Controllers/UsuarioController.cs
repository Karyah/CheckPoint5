using Microsoft.AspNetCore.Mvc;

namespace CheckPoint5.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index(string nome, string login, string email, string senha)
        {

            ViewData["chave"] = "Cadastro de Cliente";
            ViewBag.titulo = "Cadastro Cliente";
            TempData["mensagem"] = "Cadastrado com Sucesso!";

            //exercício
            ViewData["nome"] = nome;
            ViewData["login"] = login;
            ViewData["senha"] = senha;
            ViewData["email"] = email;

            return View();
        }

        public IActionResult Cadastrar() { 
            return View();
        }
    }
}
