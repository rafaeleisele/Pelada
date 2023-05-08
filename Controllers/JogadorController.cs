using Microsoft.AspNetCore.Mvc;
using Pelada.Data;
using Pelada.Models;
using Pelada.Repositories;

namespace Pelada.Controllers
{
    public class JogadorController : Controller
    {
        private JogadorRepository _jogadorRepository;

        public JogadorController(JogadorRepository repository)
        {
            _jogadorRepository = repository;
        }

        public IActionResult Index()
        {
            var jogadores = _jogadorRepository.GetAll();
            var JogadorViewModel = new JogadorViewModel
            {
                Jogadores = jogadores
            };
            return View(JogadorViewModel);
        }

        [HttpPost]
        public IActionResult Salvar(JogadorViewModel viewModel)
        {
            var Jogador = new Jogador
            {
                Nome = viewModel.Nome,
                Nota = viewModel.Nota
            };

            _jogadorRepository.AddJogador(Jogador);

            return RedirectToAction("Index");
        }

        public IActionResult Deletar(int Id) 
        { 
            _jogadorRepository.DeleteJogador(Id); 
            return RedirectToAction("Index");
        }



    }
}
