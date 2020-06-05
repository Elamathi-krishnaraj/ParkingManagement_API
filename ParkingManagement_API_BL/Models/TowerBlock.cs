using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ParkingManagement_API_BL.Models
{
    public class TowerBlock
    {
        [Key]
        public int TowerBlockId { get; set; }

        public string BlockDescription { get; set; }
    }
}