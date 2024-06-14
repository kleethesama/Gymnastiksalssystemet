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

        private bool CheckIfBookingOverlaps(Booking booking)
        {
            foreach (Booking bookingInList in _Bookings)
            {
                if (booking._date.Date == bookingInList._date.Date)
                {
                    return booking._start.Hour >= bookingInList._start.Hour && booking._end.Hour <= bookingInList._end.Hour;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string description = string.Empty;
            description += $"There are currently {_Bookings.Count} amount of bookings.\n";
            description += "Here are all the bookings:";
            foreach (Booking booking in _Bookings)
            {
                description += $"\n\n{booking}";
            }
            return description;
        }
    }
}
