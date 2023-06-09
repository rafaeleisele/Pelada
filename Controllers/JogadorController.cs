using Microsoft.AspNetCore.Mvc;
using Pelada.Data;
using Pelada.Models;
using Pelada.Repositories;
using System.Globalization;

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
        public IActionResult Salvar(JogadorViewModel jogadorViewModel)
        {
            var jogador = new Jogador();


            // Conversão da string para double com o CultureInfo correto
            jogador.Nota = double.Parse(jogadorViewModel.Nota, CultureInfo.InvariantCulture);
            jogador.Nome = jogadorViewModel.Nome;
            jogador.Ativo = false;

            _jogadorRepository.Add(jogador);
            return RedirectToAction("Index");
        }



        public IActionResult Deletar(int Id) 
        { 
            _jogadorRepository.DeleteJogador(Id); 
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AlterarStatusAtivo(int id, bool ativo)
        {
            var jogador = _jogadorRepository.GetJogadorById(id);
            if (jogador == null)
            {
                return NotFound();
            }

            jogador.Ativo = ativo;
            _jogadorRepository.Update(jogador);

            return Ok();
        }


    }
}
