using Gymnastiksalssystemet;

var testGroup = new Group("Min Gruppe", Enumerable.Range(11, 13), 15, 0);

Console.WriteLine(testGroup);

// Setting booking time from 9 AM to 16 PM today.
var startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10 - 1, 0, 0);
var endTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13 - 1, 0, 0); ;

var testBooking = new Booking(testGroup, startTime, endTime, 4);

Console.WriteLine("\n" + testBooking);