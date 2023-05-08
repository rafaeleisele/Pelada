using Pelada.Data;
using Pelada.Services.Inteface;

namespace Pelada.Services
{
    public class TimeService : ITimeService
    {
        public List<Time> CriarTimes(List<Jogador> jogadores)
        {
            List<Time> times = new List<Time>();

            int JogadoresPorTime = 5;
            int TotalJogadores = jogadores.Count;
            int totalTimes = (int)Math.Ceiling((double)TotalJogadores / JogadoresPorTime);

            for (int i = 0; i < totalTimes; i++)
            {
                Time time = new Time
                {
                    Id = i + 1,
                    Nome = $"Time {i + 1}",
                    Jogadores = new List<Jogador>()
                };

                for (int j = i * JogadoresPorTime; j < (i + 1) * JogadoresPorTime && j < TotalJogadores; j++)
                {
                    time.Jogadores.Add(jogadores[j]);
                }

                times.Add(time);
            }

            return times;
        }
    }
}
