using infraestructure.Models;
using infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
  public  class ServiceInterconnect: IServiceInterconnectt
    {
        private IRepositoryInterconnectt repository;

        public ServiceInterconnect()
        {
            repository = new RepositoryInterconnectt();

        }

        public async Task<IEnumerable<T_InterConnect>> getByNIT(string NIT)
        {
            return await repository.getByNIT(NIT);
        }

        public async Task<IEnumerable<T_InterConnect>> getByNITDB(string NIT)
        {
            return await repository.getByNITDB(NIT);
        }
    }
}
