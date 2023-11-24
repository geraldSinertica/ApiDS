using infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infraestructure.Repository
{
   public interface IRepositoryInterconnectt
    {
       Task<IEnumerable<T_InterConnect>> getByNIT(string NIT);
    }
}
