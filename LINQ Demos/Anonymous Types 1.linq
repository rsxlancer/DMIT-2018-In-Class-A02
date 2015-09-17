<Query Kind="Expression">
  <Connection>
    <ID>6044fc24-05c9-4eac-9968-67e9ba810bf9</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// Anonymous Types 1.linq
from food in Items
where food.MenuCategory.Description == "Entree" && food.Active
orderby food.CurrentPrice descending
select new
{
	Description = food.Description,
	Price = food.CurrentPrice,
	Calories = food.Calories
}