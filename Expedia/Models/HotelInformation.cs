namespace Expedia.Models
{
    public class HotelInformation
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string LocalizedHotelName { get; set; }
        public string HotelDestination { get; set; }
        public int HotelDestinationRegionId { get; set; }
        public string HotelLongDestination { get; set; }
        public string HotelStreetAddress { get; set; }
        public string HotelCity { get; set; }
        public string HotelProvince { get; set; }
        public string HotelCountryCode { get; set; }
        public double HotelLatitude { get; set; }
        public double HotelLongitude { get; set; }
        public double HotelStarRating { get; set; }
        public double HotelGuestReviewRating { get; set; }
        public double HotelReviewTotal { get; set; }
        public string HotelImageUrl { get; set; }
        public bool VipAccess { get; set; }
        public bool IsOfficialRating { get; set; }
    }
}