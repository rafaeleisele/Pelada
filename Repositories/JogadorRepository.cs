using Pelada.Data;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using Pelada.Models;


namespace Pelada.Repositories
{
    public class JogadorRepository
    {
        public readonly PeladaContext context;

        public JogadorRepository(PeladaContext context) 
        { 
            this.context = context;
        }

        public List<Jogador> GetAll()
        {
            return context.jogadores.ToList();
        }

        public Jogador GetJogadorById(int Id)
        {
            var jogador = context.jogadores.Find(Id);

            return jogador;
        }

        public void AddJogador(Jogador jogador)
        {
            context.jogadores.Add(jogador);
            context.SaveChanges();
        }

        public void DeleteJogador(int Id)
        {
            var jogador = GetJogadorById(Id);

            context.Remove(jogador);
            context.SaveChanges();
        }
    }
}
