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
            // create the url 
            //fun to add the extintion to the url    :TODO

            var FullUrl = BullidUrl(request);

            //https://www.dotnetperls.com/httpclient
            var client = new HttpClient();   // create http instance
            var response = await client.GetAsync(FullUrl); // calling the wanted url
                                                           //    response.EnsureSuccessStatusCode();
            var content = response.Content; //retriveing the data from the site
            var result = await content.ReadAsStringAsync();  // read the data as a string 
                                                             //https://www.newtonsoft.com/json/help/html/DeserializeObject.htm
            var responseHotel = JsonConvert.DeserializeObject<AvailableHotels>(result);  //Convert the data to AvailableHotels object
            return responseHotel;


        }

        string BullidUrl(RequestHotel request)
        {
            string fuLlUrl = Url;

            if (request.DestinationCity != "" && request.DestinationCity != null)
                fuLlUrl += "&DestinationCity=" + request.DestinationCity;

            if (request.DestinationName != "" && request.DestinationName != null)
                fuLlUrl += "&DestinationName=" + request.DestinationName;

            if (request.LengthOfStay != "" && request.LengthOfStay != null)
                fuLlUrl += "&LengthOfStay=" + request.LengthOfStay;

            if (request.MaxGuestRating != "" && request.MaxGuestRating != null)
                fuLlUrl += "&MaxGuestRating=" + request.MaxGuestRating;

            if (request.MaxStarRating != "" && request.MaxStarRating != null)
                fuLlUrl += "&MaxStarRating=" + request.MaxStarRating;

            if (request.MaxTotalRate != "" && request.MaxTotalRate != null)
                fuLlUrl += "&MaxTotalRate=" + request.MaxTotalRate;

            if (request.MaxTripStartDate != "" && request.MaxTripStartDate != null)
                fuLlUrl += "&MaxTotalRate=" + request.MaxTripStartDate;

            if (request.MinGuestRating != "" && request.MinGuestRating != null)
                fuLlUrl += "&MinGuestRating=" + request.MinGuestRating;

            if (request.MinStarRating != "" && request.MinStarRating != null)
                fuLlUrl += "&MinStarRating=" + request.MinStarRating;

            if (request.MinTotalRate != "" && request.MinTotalRate != null)
                fuLlUrl += "&MinTotalRate=" + request.MinTotalRate;

            if (request.MinTripStartDate != "" && request.MinTripStartDate != null)
                fuLlUrl += "&MinTripStartDate=" + request.MinTripStartDate;

            return fuLlUrl;
        }


    }
}
