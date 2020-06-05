using System.Collections.Generic;
using System.Data.Entity;
using ParkingManagement_API_BL.Models;
using ParkingManagement_API_BL.Repositories;
using System.Threading.Tasks;

namespace ParkingManagement_API_DAL.Repositories
{
    public class RequestDuationTypeRepository : Repository<RequestDurationType>, IRequestDuationTypeRepository
    {
        public RequestDuationTypeRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public async Task<IEnumerable<RequestDurationType>> GetRequestDurationType()
        {
            return await ParkingManagementContext.RequestDurationTypes.ToListAsync();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}