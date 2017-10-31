Select TOP 10
	   Stops.StopName,
	   SUM(FuelEvents.FuelUsed) 'Total Fuel Used'
from FuelEvents 
join Stops on FuelEvents.Location=Stops.StopID
where MONTH(FuelEvents.Time) <= dateadd(m,-12,getdate())
Group By StopName
Order BY 'Total Fuel Used' DESC;
