using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using ParkingManagement_API_BL.Models;
using ParkingManagement_API_BL.Repositories;

namespace ParkingManagement_API_DAL.Repositories
{
    public class TowerRepository : Repository<Tower>, ITowerRepository
    {
        public TowerRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public async Task<IEnumerable<Tower>> GetTowers()
        {
            return await ParkingManagementContext.Towers.ToListAsync();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}