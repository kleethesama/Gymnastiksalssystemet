using Gymnastiksalssystemet;
using System.Diagnostics;

var testGroup = new Group("Min Gruppe", Enumerable.Range(11, 13), 15, 0);

Console.WriteLine(testGroup);

// Setting booking time from 9 AM to 16 PM today.
var startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10 - 1, 0, 0);
var endTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13 - 1, 0, 0); ;

// Instantiating a booking for today between 9 AM and 12 PM.
var testBooking = new Booking(testGroup, startTime, endTime, 4, 0);

// Setting booking time from 9 AM to 13 PM for Sunday.
var startTimeSunday = new DateTime(2024, 6, 16);
startTimeSunday = startTimeSunday.AddHours(9);
var endTimeSunday = new DateTime(2024, 6, 16);
endTimeSunday = endTimeSunday.AddHours(13);

//Console.WriteLine(startTimeSunday);
//Console.WriteLine(endTimeSunday);

// Instantiating a booking for this Sunday between 11 AM and 16 PM.
var testBookingSunday = new Booking(testGroup, startTimeSunday, endTimeSunday, 5, 1);

//Console.WriteLine("\n" + testBooking);

var allBookings = new List<Booking>();
allBookings.Add(testBooking);
allBookings.Add(testBookingSunday);

var testBookingManager = new BookingManager(allBookings);

Console.WriteLine("\n" + testBookingManager);

// Setting booking time from 9 AM to 16 PM today.
var testOveralpStartTime1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13 - 1, 0, 0);
var testOveralpEndTime1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15 - 1, 0, 0); ;

// Setting booking time from 11 AM to 14 PM today.
var testOveralpStartTime2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11 - 1, 0, 0);
var testOveralpEndTime2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12 - 1, 0, 0); ;

var testOverlapBooking1 = new Booking(testGroup, testOveralpStartTime1, testOveralpEndTime1, 4, 0);
var testOverlapBooking2 = new Booking(testGroup, testOveralpStartTime2, testOveralpEndTime2, 4, 0);

var testOverlapBookingManager = new BookingManager();
testOverlapBookingManager.AddBooking(testOverlapBooking1);
testOverlapBookingManager.AddBooking(testOverlapBooking2);

// Testing if the booking is between 8 AM and 20 PM (not Sunday).
Debug.Assert(testBookingManager._Bookings[0]._start.Hour >= 8 - 1 && testBookingManager._Bookings[0]._end.Hour <= 20 - 1);

// Testing if the bookig is between 10 AM and 18 PM on a Sunday.
Debug.Assert(testBookingManager._Bookings[1]._start.Hour >= 10 - 1 && testBookingManager._Bookings[1]._end.Hour <= 18 - 1);