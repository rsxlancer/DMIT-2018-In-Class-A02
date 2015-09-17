<Query Kind="Statements">
  <Connection>
    <ID>6044fc24-05c9-4eac-9968-67e9ba810bf9</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//  Generate a list of all the reservations for each day in a specific month
var year = 2014;
var month = 9;
var startDate = new DateTime(year, month, 1);
var endDate = new DateTime(year, month, 30);

var range = Enumerable.Range(1, (endDate - startDate).Days + 1);

range.Dump();

var reservations = from day in range
                   select new
                   {
                        Date = new DateTime(year, month, day),
                        Reservations = from booking in Reservations
                                           where booking.ReservationDate.Year == year
                                              && booking.ReservationDate.Month == month
                                              && booking.ReservationDate.Day == day
                                           select booking
                   };
reservations.Dump(); 