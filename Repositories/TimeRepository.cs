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

    }
}
