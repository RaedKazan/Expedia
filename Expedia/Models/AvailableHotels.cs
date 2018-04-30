using System;
using System.Threading.Tasks;

namespace Expedia.Models
{
    public class AvailableHotels
    {
        public OfferInformation OfferInfo { get; set; }
        public UserInformation UserInfo { get; set; }
        public Offers Offers { get; set; }

       
    }
}