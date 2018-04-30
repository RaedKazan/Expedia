using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expedia.Models
{
    public class Hotel
    {
        public OfferDateRange OfferDateRange { get; set; }
        public Destination Destination { get; set; }
        public HotelInformation HotelInfo { get; set; }
        public HotelPricingInformation HotelPricingInfo { get; set; }
        public HotelUrls HotelUrls { get; set; }
    }
}
