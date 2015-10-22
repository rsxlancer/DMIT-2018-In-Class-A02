<Query Kind="Expression">
  <Connection>
    <ID>c3e2fc9e-bd11-4752-a3ab-944f265138c4</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from eachRow in SpecialEvents
where eachRow.Active
select new // ActiveEvent()
{
	Code = eachRow.EventCode,
	Description = eachRow.Description
	
}