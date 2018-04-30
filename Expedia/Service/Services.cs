using Expedia.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Expedia.Service
{
    public class Services : IServices
    {
        const string Url = "https://offersvc.expedia.com/offers/v2/getOffers?scenario=deal-finder&page=foo&uid=foo&productType=Hotel";

        public async Task<AvailableHotels> AvailableHotels(RequestHotel request)
        {
            var FullUrl = BullidUrl(request);
            var client = new HttpClient();  
            var response = await client.GetAsync(FullUrl); 
            var content = response.Content; 
            var result = await content.ReadAsStringAsync();  
            var responseHotel = JsonConvert.DeserializeObject<AvailableHotels>(result);  
            return responseHotel;
        }

        string BullidUrl(RequestHotel request)
        {
            string fuLlUrl = Url;

            if (!string.IsNullOrEmpty(request.DestinationCity))
                fuLlUrl += "&DestinationCity=" + request.DestinationCity;

            if (!string.IsNullOrEmpty(request.DestinationName))
                fuLlUrl += "&DestinationName=" + request.DestinationName;

            if (!string.IsNullOrEmpty(request.LengthOfStay))
                fuLlUrl += "&LengthOfStay=" + request.LengthOfStay;

            if (!string.IsNullOrEmpty(request.MaxGuestRating))
                fuLlUrl += "&MaxGuestRating=" + request.MaxGuestRating;

            if (!string.IsNullOrEmpty(request.MaxStarRating))
                fuLlUrl += "&MaxStarRating=" + request.MaxStarRating;

            if (!string.IsNullOrEmpty(request.MaxTotalRate))
                fuLlUrl += "&MaxTotalRate=" + request.MaxTotalRate;

            if (!string.IsNullOrEmpty(request.MaxTripStartDate))
                fuLlUrl += "&MaxTotalRate=" + request.MaxTripStartDate;

            if (!string.IsNullOrEmpty(request.MinGuestRating))
                fuLlUrl += "&MinGuestRating=" + request.MinGuestRating;

            if (!string.IsNullOrEmpty(request.MinStarRating))
                fuLlUrl += "&MinStarRating=" + request.MinStarRating;

            if (!string.IsNullOrEmpty(request.MinTotalRate))
                fuLlUrl += "&MinTotalRate=" + request.MinTotalRate;

            if (!string.IsNullOrEmpty(request.MinTripStartDate))
                fuLlUrl += "&MinTripStartDate=" + request.MinTripStartDate;

            return fuLlUrl;
        }


    }
}
