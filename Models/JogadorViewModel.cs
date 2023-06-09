using Pelada.Data;

namespace Pelada.Models
{
    public class JogadorViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Nota { get; set; }
        public bool Ativo { get; set; }

        public Time? Time { get; set; }
        public int? TimeId { get; set; }

        public List<Jogador> Jogadores { get; set; }
    }
}
