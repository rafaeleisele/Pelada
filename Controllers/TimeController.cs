using Microsoft.AspNetCore.Mvc;
using Pelada.Data;
using Pelada.Repositories;
using Pelada.Services.Inteface;

namespace Pelada.Controllers
{
    public class TimeController : Controller
    {
        private readonly ITimeService _timeService;

        private JogadorRepository _jogadorRepository;


        public TimeController(ITimeService timeService, JogadorRepository jogadorRepository)
        {
            _timeService = timeService;
            _jogadorRepository = jogadorRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CriarTimes()
        {
            // Obter todos os jogadores
            List<Jogador> jogadores = _jogadorRepository.GetAll();

            // Criar os times usando o TimeService
            List<Time> times = _timeService.CriarTimes(jogadores);

            // Redirecionar para uma view ou outro método, dependendo do que você deseja fazer em seguida
            // Por exemplo, você pode redirecionar para uma view que exibe os times
            return RedirectToAction("Index");
        }
    }

}

