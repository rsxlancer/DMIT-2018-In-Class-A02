<Query Kind="Expression">
  <Connection>
    <ID>580a085e-afc1-44f7-8525-b6c3a0aa5221</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//Grouping Sample
from food in Items
group food by food.MenuCategoryID