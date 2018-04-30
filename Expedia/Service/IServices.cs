using Expedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expedia.Service
{
    public interface IServices
    {
        Task<AvailableHotels> AvailableHotels(RequestHotel request);

    }
}
