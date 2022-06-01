using Fruteria_Team.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruteria_Team.Repositories
{
    public class ComisionesRepository
    {
        fruteriaContext context = new fruteriaContext();


        public IEnumerable<Comisiones> GetAll()
        {
            return context.Comisiones.OrderBy(x => x.IdComision);
        }
    }
}
