using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ParkingManagement_API_BL.Models;
using System.Data.Entity;
using ParkingManagement_API_BL.Repositories;
using System.Threading.Tasks;

namespace ParkingManagement_API_DAL.Repositories
{
    public class TowerBlockRepository : Repository<TowerBlock>, ITowerBlockRepository
    {
        public TowerBlockRepository(ParkingManagementContext context)
            : base(context)
        {
        }
        public async Task<IEnumerable<TowerBlock>> GetTowerBlocks()
        {
            return await ParkingManagementContext.TowerBlocks.ToListAsync();
        }

        public ParkingManagementContext ParkingManagementContext
        {
            get { return Context as ParkingManagementContext; }
        }
    }
}