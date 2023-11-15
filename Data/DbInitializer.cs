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
            if (context.Bookings.Any())
            {
                return;   // DB has been seeded
            }
            if (context.Payment.Any())
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

            // var bookings = new List<Booking>
            // {
            //     new Booking{BookingDateTime = new DateTime(2023, 12, 1, 12, 0, 0), GuestID = 1, Guest = context.Guests.First(g=>g.ID == 1), Payment = context.Payment.FirstOrDefault(p=>p.PaymentID == 1)},
            //     new Booking{BookingDateTime = new DateTime(2023, 12, 3, 12, 0, 0), GuestID = 2, Guest = context.Guests.First(g=>g.ID == 2), Payment = context.Payment.FirstOrDefault(p=>p.PaymentID == 2)},
            //     new Booking{BookingDateTime = new DateTime(2023, 11, 30, 11, 0, 0), GuestID = 3, Guest = context.Guests.First(g=>g.ID == 3), Payment = context.Payment.FirstOrDefault(p=>p.PaymentID == 3)},
            //     new Booking{BookingDateTime = new DateTime(2023, 11, 30, 14, 30, 0), GuestID = 4, Guest = context.Guests.First(g=>g.ID == 4), Payment = context.Payment.FirstOrDefault(p=>p.PaymentID == 4)}
            // };

            var payments = new Payment[]
            {
                new Payment{TotalAmount = 40.50, Status = Status.Unpaid},
                new Payment{TotalAmount = 81.00, Status = Status.Paid},
                new Payment{TotalAmount = 120.50, Status = Status.Unpaid},
                new Payment{TotalAmount = 99.99, Status = Status.Paid}
            };

                context.Guests.AddRange(guests);
                // context.Bookings.AddRange(bookings);
                foreach (Payment p in payments)
                {
                    context.Payment.Add(p);
                }
                context.SaveChanges();
            }
        }
    }