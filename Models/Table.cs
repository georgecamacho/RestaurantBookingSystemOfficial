using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantBookingSystem.Models
{
    public enum Status 
    {
        Booked, Available
    }
    public class Table
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TableID { get; set; }
        public int Capacity { get; set; }
        public Status Status { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}