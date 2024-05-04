using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Model
{
    internal class DBBookingRoom
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string RoomName { get; set; }
        public int RoomNo { get; set; }
        public int RoomBed { get; set; }
        public int RoomPerson { get; set; }
        public int RoomPrice { get; set; }
        public  int RoomArea { get; set; }
        public byte[] RoomPicture { get; set; }
    }
}
