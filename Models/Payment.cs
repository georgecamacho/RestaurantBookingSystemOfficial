using System.ComponentModel.DataAnnotations;

namespace RestaurantBookingSystemOfficial.Models
{
    public enum Status 
    {
        Paid, Unpaid
    }
    public class Payment
    {
        public int PaymentID { get; set; }
        public double TotalAmount { get; set; }
        public Status status { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}