<Query Kind="Expression">
  <Connection>
    <ID>6044fc24-05c9-4eac-9968-67e9ba810bf9</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// List all the menu items that are Entrees 
// in order from most to least expensive
from food in Items
orderby food.CurrentPrice descending
where food.MenuCategory.Description == "Entree"
select food