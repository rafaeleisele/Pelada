﻿namespace Pelada.Data
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Nota { get; set; }

        public Time? Time { get; set; }
        public int? IdTime { get; set; }

        public List<Jogador> Jogadores { get; set; }
    }
}
