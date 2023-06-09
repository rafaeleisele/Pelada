using Microsoft.AspNetCore.Mvc;
using Pelada.Data;
using Pelada.Models;
using Pelada.Repositories;
using System.Collections.Generic;

namespace Pelada.Controllers
{
    public class TimeController : Controller
    {
        public TimeRepository _timeRespository;
        public JogadorRepository _jogadorRepository;

        public TimeController(TimeRepository timeRepository, JogadorRepository jogadorRepository)
        {
            _timeRespository = timeRepository;
            _jogadorRepository = jogadorRepository;
        }

        public IActionResult Index()
        {

            var viewModel = new TimeViewModel
            {
                Times = _timeRespository.GetAll(),
                Jogadores = _jogadorRepository.GetAll(),
            };
            return View(viewModel);
        }


        //CRUD
        [HttpPost]
        public IActionResult AddTime(TimeViewModel timeViewModel)
        {
            var Time = new Time
            {
                Nome = timeViewModel.Nome,
            };

            _timeRespository.Add(Time);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _timeRespository.Delete(id);
            return RedirectToAction("Index");
        }


        ////Modal
        //public IActionResult AbrirModalJogadores()
        //{
        //    return View();
        //}


        [HttpPost]
        public IActionResult AddJogadorToTheTime(int idtime, int idjogador)
        {
            Jogador jogador = _jogadorRepository.GetJogadorById(idjogador);

            jogador.TimeId = idtime;

            _jogadorRepository.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Sorteio()
        {
            var jogadores = _jogadorRepository.GetJogadoresAtivos();
            var times = _timeRespository.GetAll();
            var totalTime = 0;

            // Ordene os jogadores por nota decrescente
            jogadores = jogadores.OrderByDescending(j => j.Nota).ToList();

            // Crie uma lista de listas para representar os times
            List<List<Jogador>> timesJogadores = new List<List<Jogador>>();
            foreach (var time in times)
            {
                timesJogadores.Add(new List<Jogador>());
            }

            // Atribua cada jogador ao time com a menor soma total de notas até agora
            foreach (var jogador in jogadores)
            {
                // Encontre o time com a menor soma total de notas
                var timeComMenorNota = timesJogadores.OrderBy(t => t.Sum(j => j.Nota)).First();
                timeComMenorNota.Add(jogador);
            }

            // Atualize os times no banco de dados
            for (int i = 0; i < times.Count; i++)
            {
                var time = times[i];
                time.Jogadores = timesJogadores[i];
                _timeRespository.Update(time);
            }

            return RedirectToAction("Index");
        }


    }
}

