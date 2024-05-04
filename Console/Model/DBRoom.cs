using System.Data.Entity;

namespace Console.Model
{
    internal class DBRoom:DbContext
    {
        public DbSet<DBBookingRoom> dBBookingRooms { get; set; }
    }
}
