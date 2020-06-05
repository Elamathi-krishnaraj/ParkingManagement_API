using System.Linq;
using System.Web.Http;
using ParkingManagement_API_BL.Models;
using ParkingManagement_API_DAL;
using System.Data.Entity;
using System.Web.Http.Cors;
using ParkingMangement_API_Common;

namespace ParkingManagement.Controllers.Api
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    [RoutePrefix("api/EmployeeSlot")]
    public class EmployeeSlotController : ApiController
    {
        private ParkingManagementContext _context;

        public EmployeeSlotController() {
            _context = new ParkingManagementContext();
        }
        [CacheFiltercs(TimeDuration = 300 )]
        // GET /api/EmployeeSlot
        [Route("")]
        public IHttpActionResult GetEmployeeSlot()
        {

            var resultlistQuery = _context.RequestDetails
                .Include(c => c.Registers)
                .Include(c => c.RequestDurationType)
                .ToList();
            return Ok(resultlistQuery);
        }

        //[Route("~/api/authors/EmployeeSlot")]  using this we can overwrite the route
    }
}
