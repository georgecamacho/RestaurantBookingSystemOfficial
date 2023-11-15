using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace RestaurantBookingSystemOfficial.Models 
{
    public class Guest 
    {
        public int ID { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "First name cannot be longer than 30 characters.")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Last name cannot be longer than 30 characters.")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set;}
        [Required]
        [StringLength(10, ErrorMessage = "Phone number cannot be longer than 10 characters.")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }
        [Range(1, 15, ErrorMessage = "Party size must be greater than or equal to 1. For bookings bigger than 15 please call the restaurant to cater for this.")]
        public int BookingSize { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Booking_date { get; set; }
        public int? BookingID { get; set; }
        public Booking Booking { get; set; }

    }
}