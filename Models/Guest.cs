namespace RestaurantBookingSystemOfficial.Models 
{
    public enum Allergens {
        Dairy, Crustacean, Fish, Nuts, Eggs, Gluten
    }
    public class Guest 
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set;}
        public string PhoneNumber { get; set; }
        public DateTime Booking_date { get; set; }
        public List<Allergens> Allergies { get; set; }
        public ICollection<Booking> Bookings { get; set; }

    }
}