using ApplicationCore.Services;
using DataStore.Models;
using infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace ApiDataStore.Controllers
{
    [RoutePrefix("api/Interconect")]
    public class InterconnecttController : ApiController
    {
        // GET: Interconnectt

        [Route("byNIT")]
        public async Task<IHttpActionResult> getByNIT(string NIT)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                IServiceInterconnectt service = new ServiceInterconnect();

                IEnumerable<T_InterConnect> reportes = await service.getByNIT(NIT);

                if (reportes == null || !reportes.Any())
                {
                    response.StatusCode = 404;
                    response.Message = "Reportes no encontrados verifique el NIT ";

                }
                else
                {
                    response.StatusCode = 200;
                    response.Message = "Reportes encontrado";
                    response.Data = reportes;
                }

                return Json(response);
            }
            catch (Exception e)
            {

                response.StatusCode = 500;
                response.Message = e.Message;

                return Json(response);
            }
        }

        [Route("byNITDB")]
        public async Task<IHttpActionResult> getByNITDB(string NIT)
        {
            ResponseModel response = new ResponseModel();
            try
            {

                IServiceInterconnectt service = new ServiceInterconnect();
                IEnumerable<T_InterConnect> reportes = new List<T_InterConnect>();

               reportes = await service.getByNITDB(NIT);

                if (reportes == null || !reportes.Any())
                {
                    response.StatusCode = 404;
                    response.Message = "Reportes no encontrados verifique el NIT ";

                }
                else
                {
                    response.StatusCode = 200;
                    response.Message = "Reportes encontrado";
                    response.Data = reportes;
                }

                return Json(response);
            }
            catch (Exception e)
            {

                response.StatusCode = 500;
                response.Message ="Error Controller: \n "+ e.Message;

                return Json(response);
            }
        }



    }
}
