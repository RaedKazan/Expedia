using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Expedia.Models
{
    public class RequestHotel
    {
        [Display(Name= "Destination Name")]
        public string DestinationName { get; set; }

        [Display(Name = "Destination City")]
        public string DestinationCity { get; set; }

        [Display(Name = "Min Trip Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public string MinTripStartDate { get; set; } 

        [Display(Name = "Max Trip Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public string MaxTripStartDate { get; set; }
        
        [Display(Name = "Length Of Stay")]
        public string LengthOfStay { get; set; }
        

        [Display(Name = "Max Star Rating")]
        public string MaxStarRating { get; set; }

        [Display(Name = "Min Star Rating")]
        public string MinStarRating { get; set; }

        [Display(Name = "Max Total Rate")]
        public string MaxTotalRate { get; set; }
        [Display(Name = "Min Total Rate")]
        public string MinTotalRate { get; set; }

        [Display(Name = "Max Guest Rating")]
        public string MaxGuestRating { get; set; }

        [Display(Name = "Min Guest Rating")]
        public string MinGuestRating { get; set; }
    }
}
