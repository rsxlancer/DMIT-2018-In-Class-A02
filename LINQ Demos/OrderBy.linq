<Query Kind="Expression">
  <Connection>
    <ID>580a085e-afc1-44f7-8525-b6c3a0aa5221</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from food in Items
orderby food.Description descending
select food