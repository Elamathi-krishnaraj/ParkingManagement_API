using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingManagement_API_BL.Models;

namespace ParkingManagement_API_BL.Repositories
{
    public interface ISurrenderHistoryRepository : IRepository<SurrenderHistory>
    {
        Task<IEnumerable<SurrenderHistory>> GetSurrenderHistories();
    }
}
