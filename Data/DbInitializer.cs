using RestaurantBookingSystemOfficial.Models;

namespace RestaurantBookingSystemOfficial.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RestaurantContext context)
        {
            if (context.Guests.Any())
            {
                return;   // DB has been seeded
            }

            var guests = new Guest[]
            {
                new Guest{FirstName = "John", LastName = "Taylor", EmailAddress = "john.taylor@hotmail.com", PhoneNumber = "7956628761", BookingSize = 3, Booking_date = new DateTime(2023, 12, 1, 12, 0, 0)},
                new Guest{FirstName = "Terry", LastName = "Smith", EmailAddress = "terry.smith@gmail.com", PhoneNumber = "7956123761", BookingSize = 4, Booking_date = new DateTime(2023, 12, 3, 12, 0, 0)},
                new Guest{FirstName = "Donna", LastName = "Green", EmailAddress = "donna.green@live.com", PhoneNumber = "7978562876", BookingSize = 2, Booking_date = new DateTime(2023, 11, 30, 11, 0, 0)},
                new Guest{FirstName = "Patricia", LastName = "Bloggs", EmailAddress = "pat.bloggs@hotmail.com", PhoneNumber = "8766628761", BookingSize = 5, Booking_date = new DateTime(2023, 11, 30, 14, 30, 0)}
            };

                context.Guests.AddRange(guests);
                context.SaveChanges();
            }
        }
    }