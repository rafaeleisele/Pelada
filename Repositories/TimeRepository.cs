using Microsoft.EntityFrameworkCore;
using Pelada.Data;

namespace Pelada.Repositories
{
    public class TimeRepository
    {
        public readonly PeladaContext context;

        public TimeRepository(PeladaContext context)
        {
            this.context = context;
        }

        public List<Time> GetAll()
        {
            return context.times.ToList();
        }

        public Time Get(int id)
        {
            var time = context.times.Find(id);
            return time;
        }

        public void Delete(int id)
        {
            var time = Get(id);
            context.Remove(time);
            context.SaveChanges();
        }

        public void Add(Time time)
        {
            context.times.Add(time);
            context.SaveChanges();
        }

        public int GetNumberOfTeams()
        {
            return context.times.Count();
        }

        public void Update(Time time)
        {
            context.times.Update(time);
            context.SaveChanges();
        }


        //public List<Jogador> JogadoresDoTime(int TimeId) 
        //{ 
        //    List<Jogador> JogadoresDoTime = context.jogadores.Where(x => x.TimeId == TimeId).ToList();

        //    return JogadoresDoTime;
        //}

    }
}
