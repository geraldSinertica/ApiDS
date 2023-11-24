using infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infraestructure.Repository
{
    public class RepositoryInterconnectt : IRepositoryInterconnectt
    {
        public async Task<IEnumerable<T_InterConnect>> getByNIT(string NIT)
        {
            try
            {

                IEnumerable<T_InterConnect> reportes = null;
                using (DataStoreContext ctx = new DataStoreContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    reportes = await ctx.T_InterConnect.Where(p => p.NIT == NIT).ToListAsync(); ;

                }
                return reportes;

            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception(dbEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
