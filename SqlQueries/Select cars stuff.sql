use bilbase
go

SELECT maerke.maerkeName, braendstof.[type], cars.model, cars.kmperliter, cars.pris, cars.aargang, cars.saeder, cars.doere 
	FROM cars 
INNER JOIN braendstof 
	ON braendstof.ID=cars.braendstofType
INNER JOIN maerke 
	ON maerke.maerkeID=cars.maerke