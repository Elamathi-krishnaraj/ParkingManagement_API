using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParkingManagement_API_BL.Models
{
    public class ParkingSlot
    {
        [Key]
        public int ParkingSlotId { get; set; }

        public string SlotDescription { get; set; }
    }
}