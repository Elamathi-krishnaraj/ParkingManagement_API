using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ParkingManagement_API_BL.Models;

namespace ParkingManagement_API_BL.Repositories
{
    public interface IRegisterRepository : IRepository<Registers>
    {
        Task<IEnumerable<Registers>> GetRegisters(int Id);
        Task<Registers> ValidateLogin(Registers LoginDetails);
    }
}