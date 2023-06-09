using Pelada.Data;
using System.Collections.Generic;

namespace Pelada.Models
{
    public class TimeViewModel
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }

        public List<Jogador>? Jogadores { get; set; }

        public List<Time>? Times { get; set; }
    }
}
