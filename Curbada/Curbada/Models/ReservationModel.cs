using System;
using System.Collections.Generic;
using System.Linq;
namespace Curbada.Models
{
    public class ReservationModel
    {
        public string RoomName { get; set; }
        public string NoOfGuest { get; set; }
        public string GuestName { get; set; }
        public string ContactNumber { get; set; }
        public string CheckInDate { get; set; }
        public string CheckOutDate { get; set; }
        public string Rate { get; set; }
        public string Notes { get; set; }
    }
}