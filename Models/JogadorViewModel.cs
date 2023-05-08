using Pelada.Data;

namespace Pelada.Models
{
    public class JogadorViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Nota { get; set; }

        public Time? Time { get; set; }
        public int? IdTime { get; set; }

        public List<Jogador> Jogadores { get; set; }
    }
}
