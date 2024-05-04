namespace Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookingRoomSeedDatatoDB : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO DBBookingRooms (TypeId, RoomName, RoomNo, RoomBed, RoomPerson, RoomPrice, RoomArea) VALUES (1, 'Standard',13,45,6,7,12); ");
        }
        
        public override void Down()
        {
        }
    }
}
