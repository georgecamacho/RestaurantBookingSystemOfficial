using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestaurantBookingSystemOfficial.Data;
using RestaurantBookingSystemOfficial.Models;

namespace RestaurantBookingSystemOfficial.Pages.Bookings
{
    public class EditModel : PageModel
    {
        private readonly RestaurantBookingSystemOfficial.Data.RestaurantContext _context;

        public EditModel(RestaurantBookingSystemOfficial.Data.RestaurantContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Booking Booking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Booking = await _context.Bookings
                .Include(b => b.Payment).FirstOrDefaultAsync(m => m.BookingID == id);

            if (Booking == null)
            {
                return NotFound();
            }
           ViewData["PaymentID"] = new SelectList(_context.Payment, "PaymentID", "PaymentID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Booking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingExists(Booking.BookingID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.BookingID == id);
        }
    }
}
