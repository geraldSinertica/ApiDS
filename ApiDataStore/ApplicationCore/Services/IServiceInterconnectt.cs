using infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
   public interface IServiceInterconnectt
    {
        Task<IEnumerable<T_InterConnect>> getByNIT(string NIT);

    }
}
