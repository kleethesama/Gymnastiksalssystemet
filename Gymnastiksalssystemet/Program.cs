using Gymnastiksalssystemet;

var testGroup = new Group("Min Gruppe", Enumerable.Range(11, 13), 15, 0);

Console.WriteLine(testGroup);

// Setting booking time from 9 AM to 16 PM today.
var start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10 - 1, 0, 0);
var end = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17 - 1, 0, 0); ;

var testBooking = new Booking(testGroup, DateTime.Today);