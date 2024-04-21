/* User */
DECLARE @pv VARCHAR(MAX) = 'Vung Tau';
DECLARE @checkin DATE = '3/31/2024';

SELECT HotelName, RoomName, RoomPerson, RoomPicture, RoomBed, AC, Hairdryer, Chair, Desk, Refrigerator, Balcony, Bathtub, Minibar, CoffeeMaker, SafetyBox, Kitchen, Champage, Bidet, Throne
FROM ((Hotel 
JOIN (Room JOIN TypeRoom ON Room.TypeId = TypeRoom.TypeId) ON Hotel.HotelId = (Room.RoomId / POWER (10, DATALENGTH (CAST (Room.RoomNo AS VARCHAR(MAX))))))
LEFT JOIN PersonOrder ON Room.RoomId = PersonOrder.RoomId)
WHERE Hotel.HotelProvince = @pv AND (OrderEnd < @checkin OR OrderEnd IS NULL);

SELECT HotelName, RoomPicture, RoomName, RoomPerson, RoomBed, AC, Chair, Hairdryer, Desk, Refrigerator, Balcony, Bathtub, Champage, CoffeeMaker, Kitchen, SafetyBox, Minibar, Bidet, Throne 
FROM ((Room JOIN TypeRoom ON Room.TypeId = TypeRoom.TypeId)
JOIN Hotel ON Hotel.HotelId = (Room.RoomId / POWER (10, DATALENGTH (CAST (Room.RoomNo AS VARCHAR(MAX))))))