namespace Expedia.Models
{
    public class HotelPricingInformation
    {
        public double AveragePricceValue { get; set; }
        public double TotalPriceValue { get; set; }
        public double CrossOutPriceValue { get; set; }
        public double OriginalPricePerNight { get; set; }
        public double PercentSavings { get; set; }
        public string Currency { get; set; }
        public bool DRR { get; set; }
    }
}