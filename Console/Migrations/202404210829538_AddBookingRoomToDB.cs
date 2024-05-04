namespace Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookingRoomToDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DBBookingRooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeId = c.Int(nullable: false),
                        RoomName = c.String(),
                        RoomNo = c.Int(nullable: false),
                        RoomBed = c.Int(nullable: false),
                        RoomPerson = c.Int(nullable: false),
                        RoomPrice = c.Int(nullable: false),
                        RoomArea = c.Int(nullable: false),
                        RoomPicture = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DBBookingRooms");
        }
    }
}
