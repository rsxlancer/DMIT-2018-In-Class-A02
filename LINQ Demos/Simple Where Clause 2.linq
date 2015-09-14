<Query Kind="Expression">
  <Connection>
    <ID>580a085e-afc1-44f7-8525-b6c3a0aa5221</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//booking is a variable name that I make up
from booking in Reservations
where booking.EventCode.Equals("A")
select booking
