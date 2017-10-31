Select Stops.StopName,
	   AVG(FuelEvents.FuelUsed) 'Average Fuel Used'
from FuelEvents 
join Stops on FuelEvents.Location=Stops.StopID
where MONTH(FuelEvents.Time) = Month(getdate())
Group By StopName
Order BY 'Average Fuel Used' DESC;