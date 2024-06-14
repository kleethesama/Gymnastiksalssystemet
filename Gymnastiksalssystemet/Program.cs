using Gymnastiksalssystemet;
using System.Diagnostics;

var testGroup = new Group("Min Gruppe", Enumerable.Range(11, 13), 15, 0);

Console.WriteLine(testGroup);

// Setting booking time from 9 AM to 16 PM today.
var startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10 - 1, 0, 0);
var endTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13 - 1, 0, 0); ;

// Instantiating a booking for today between 9 AM and 12 PM.
var testBooking = new Booking(testGroup, startTime, endTime, 4);

// Setting booking time from 9 AM to 13 PM for Sunday.
var startTimeSunday = new DateTime(2024, 6, 16);
startTimeSunday = startTimeSunday.AddHours(9);
var endTimeSunday = new DateTime(2024, 6, 16);
endTimeSunday = endTimeSunday.AddHours(13);

//Console.WriteLine(startTimeSunday);
//Console.WriteLine(endTimeSunday);

// Instantiating a booking for this Sunday between 11 AM and 16 PM.
var testBookingSunday = new Booking(testGroup, startTimeSunday, endTimeSunday, 5);

//Console.WriteLine("\n" + testBooking);

var allBookings = new List<Booking>();
allBookings.Add(testBooking);
allBookings.Add(testBookingSunday);

var testBookingManager = new BookingManager(allBookings);

Console.WriteLine("\n" + testBookingManager);

// Testing

// Testing if the booking is between 8 AM and 20 PM (not Sunday).
Debug.Assert(testBookingManager._Bookings[0]._start.Hour >= 8 - 1 && testBookingManager._Bookings[0]._end.Hour <= 20 - 1);

// Testing if the bookig is between 10 AM and 18 PM on a Sunday.
Debug.Assert(testBookingManager._Bookings[1]._start.Hour >= 10 - 1 && testBookingManager._Bookings[1]._end.Hour <= 18 - 1);