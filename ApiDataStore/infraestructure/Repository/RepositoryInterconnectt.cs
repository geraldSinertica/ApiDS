using infraestructure.Models;
using infraestructure.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
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
                bool debugMode = ConfigurationManager.AppSettings["debug"] == "true";

                if (debugMode)
                {
                    Dummie dummie = new Dummie();
                    reportes = dummie.ObtenerDatos().Where(c=>c.NIT==NIT);
                }
                else
                {
                   using (DataStoreContext ctx = new DataStoreContext())
                    {
                        ctx.Configuration.LazyLoadingEnabled = false;
                        reportes = await ctx.T_InterConnect.Where(p => p.NIT == NIT).ToListAsync(); ;

                    }
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

        public async Task<IEnumerable<T_InterConnect>> getByNITDB(string NIT)
        {
            IEnumerable<T_InterConnect> reportes = new List<T_InterConnect>();

            string cadena = ConfigurationManager.ConnectionStrings["BoeYNicola"].ToString();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BoeYNicola"].ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT CLIENTE, NOMBRE, NIT, LIMITE_CREDITO, TMP, ANT, FACT FROM [SOFTLAND].[SOFTLAND].[V_InterConnect] WHERE NIT = @NIT";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NIT", NIT);

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                reportes = new List<T_InterConnect>();
                                while (await reader.ReadAsync())
                                {
                                    T_InterConnect reporte = new T_InterConnect
                                    {
                                        CLIENTE =  reader["CLIENTE"].ToString() ,
                                        NOMBRE =  reader["NOMBRE"].ToString() ,
                                        NIT =  reader["NIT"].ToString() ,
                                        LIMITE_CREDITO =    Convert.ToDecimal(reader["LIMITE_CREDITO"].ToString()) ,
                                        TMP =  Convert.ToInt32( reader["TMP"].ToString()) ,
                                        ANT = Convert.ToInt32(reader["ANT"].ToString()),
                                        FACT = Convert.ToInt32(reader["FACT"].ToString())
                                    };
                                    ((List<T_InterConnect>)reportes).Add(reporte);
                                }
                            }
                            else
                            {
                                reportes = Enumerable.Empty<T_InterConnect>();

                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Manejo de excepciones
                    throw new Exception("Error de SQL \n"+ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error del Servidor \n"+ex.Message);
                }
                finally
                {
                    // Asegura cerrar la conexión
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

            return reportes;

        }
    }
}
