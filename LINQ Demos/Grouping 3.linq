<Query Kind="Expression">
  <Connection>
    <ID>6044fc24-05c9-4eac-9968-67e9ba810bf9</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from food in Items
group food by food.MenuCategoryID into result
select result