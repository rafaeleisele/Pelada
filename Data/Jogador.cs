using System.ComponentModel.DataAnnotations;

namespace Pelada.Data
{
    public class Jogador
    {
        [Key]
        public int Id { get; set; }
        public string NomeJogador { get; set; }
        public int Nota { get; set; }
    }
}
