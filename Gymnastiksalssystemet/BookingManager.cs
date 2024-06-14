using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastiksalssystemet
{
    internal class BookingManager
    {
        public List<Booking> _Bookings { get; private set; }

        private BookingManager()
        {
            _Bookings = [];
        }

        public BookingManager(List<Booking> bookings)
        {
            _Bookings = bookings;
        }

        public void AddBooking(Booking booking)
        {
            if (!CheckTimeAmount(booking))
            {
                throw new Exception("Booking hours are too long. Max. 2 hours!");
            }
            if (CheckIfSunday(booking) && CheckIfBookingTimeIsValidForSunday(booking))
            {
                _Bookings.Add(booking);
                //throw new Exception("The booking time must be be");
            }
            else if (!CheckIfSunday(booking) && CheckIfBookingTimeIsValid(booking))
            {
                _Bookings.Add(booking);
            }
        }

        private bool CheckTimeAmount(Booking booking)
        {
            return booking._end.Hour - booking._start.Hour <= 2;
        }

        private bool CheckIfSunday(Booking booking)
        {
            return booking._date.DayOfWeek == DayOfWeek.Sunday;
        }

        private bool CheckIfBookingTimeIsValid(Booking booking)
        {
            return booking._start.Hour >= 8 - 1 && booking._end.Hour <= 20 - 1;
        }

        private bool CheckIfBookingTimeIsValidForSunday(Booking booking)
        {
            return booking._start.Hour >= 10 - 1 && booking._end.Hour <= 18 - 1;
        }
    }
}
