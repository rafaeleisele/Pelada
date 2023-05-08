using Pelada.Data;

namespace Pelada.Services.Inteface
{
    public interface ITimeService
    {
        List<Time> CriarTimes(List<Jogador> jogadores);
    }
}
