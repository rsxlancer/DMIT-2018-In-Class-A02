<Query Kind="Expression">
  <Connection>
    <ID>c3e2fc9e-bd11-4752-a3ab-944f265138c4</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from eachRow in Reservations
where eachRow.ReservationStatus == 'B' // change single quotes to double in visual Studio
			//TBA - && eachRow has the correct EventCode...
orderby eachRow.ReservationDate
//select eachRow
group eachRow by new {eachRow.ReservationDate.Month, eachRow.ReservationDate.Day}
into dailyReservation
select new // DailyReservation() // Create a class called DailyReservation
{
	Month = dailyReservation.Key.Month,
	Day = dailyReservation.Key.Day,
	Reservations = from booking in dailyReservation
				   select new // Booking() Create a Booking DTO class
					{
						Name = booking.CustomerName,
						Time = booking.ReservationDate.TimeOfDay,
						NumberInParty = booking.NumberInParty,
						Phone = booking.ContactPhone,
						Event = booking.SpecialEvents.Description
					}
	
}