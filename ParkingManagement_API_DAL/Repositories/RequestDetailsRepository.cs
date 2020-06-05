using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ParkingManagement_API_BL.Models;
using ParkingManagement_API_BL.Repositories;
using System.Threading.Tasks;

namespace ParkingManagement_API_DAL.Repositories
{
    public class RequestDetailsRepository : Repository<RequestDetails>, IRequestDetailsRepository
    {
        public RequestDetailsRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public async Task<IEnumerable<RequestDetails>> GetRequestDetailsAsync()
        {
            return await ParkingManagementContext.RequestDetails
                .Include(c=>c.RequestDurationType)
                .Include(c=>c.Registers).ToListAsync();
        }
        public IEnumerable<RequestDetails> GetRequestDetails()
        {
            return ParkingManagementContext.RequestDetails
                .Include(c => c.RequestDurationType)
                .Include(c => c.Registers).ToList();
        }
        public async Task<IEnumerable<RequestDetails>> GetPatientsApi()
        {
            return await ParkingManagementContext.RequestDetails
                .Include(c => c.Registers)
                .Include(c=>c.RequestDurationType)
                .ToListAsync();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}