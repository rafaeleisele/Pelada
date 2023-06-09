﻿namespace Pelada.Data
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Nota { get; set; }
        public bool Ativo { get; set; }


        public int? TimeId { get; set; }
        public Time? Time { get; set; }
    }
}
