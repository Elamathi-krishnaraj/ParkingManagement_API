﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingManagement_API_BL.Models;

namespace ParkingManagement_API_BL.Repositories
{
    public interface IRequestDetailsRepository : IRepository<RequestDetails>
    {
        IEnumerable<RequestDetails> GetRequestDetails();
        Task<IEnumerable<RequestDetails>> GetRequestDetailsAsync();
        Task<IEnumerable<RequestDetails>> GetPatientsApi();
    }
}
