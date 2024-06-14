using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastiksalssystemet
{
    internal class Booking
    {
        public Group _BookedGroup { get; private set; } // Since this is private set, I should implement CRUD.
        public DateTime _date { get; private set; }
        public DateTime _start { get; private set; }
        public DateTime _end { get; private set; }
        public int _hallId { get; private set; }
        public int _Id { get; private set; }

        private Booking()
        {
            _BookedGroup = null;
            _date = DateTime.Now;
            _start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8 - 1, 0, 0);
            _end = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20 - 1, 0, 0);
            _hallId = 0;
            _Id = 0;
        }

        public Booking(Group grp, DateTime start, DateTime end, int hallId, int id)
        {
            _BookedGroup = grp;
            _start = start;
            _end = end;
            _date = DateTime.Now;
            _hallId = hallId;
            _Id = id; // TODO
        }

        public string GetWeekDay()
        {
            var dayOfWeek = _date.DayOfWeek;
            return dayOfWeek.ToString();
        }

        public override string ToString()
        {
            string description = string.Empty;
            description += $"This booking is set for the date: {_date.ToLongDateString()}\n";
            description += $"The weekday for this booking is: {GetWeekDay()}\n";
            description += $"The booking time is between: {_start.TimeOfDay} and {_end.TimeOfDay}\n";
            description += $"The hall ID is: {_hallId}";
            return description;
        }
    }
}
