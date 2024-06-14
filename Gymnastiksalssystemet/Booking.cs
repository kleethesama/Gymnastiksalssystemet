using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastiksalssystemet
{
    internal class Booking
    {
        public DateTime _date { get; private set; }
        public DateTime _start { get; private set; }
        public DateTime _end { get; private set; }
        public int _hallId { get; private set; }
        public int _Id { get; private set; }

        private Booking()
        {
            _date = DateTime.Now;
            _start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8 - 1, 0, 0);
            _end = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20 - 1, 0, 0);
            _hallId = 0;
            _Id = 0;
        }

        public Booking(Group grp, DateTime start, DateTime end, int hallId)
        {
            _date = DateTime.Now;
            _start = start;
            _end = end;
            _hallId = hallId;
            _Id = 0; // TODO
        }

        public string GetWeekDay()
        {
            var dateToday = DateTime.Today;
            var day = dateToday.DayOfWeek;
            return day.ToString();
        }
    }
}
