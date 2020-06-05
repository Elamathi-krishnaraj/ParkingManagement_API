using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParkingManagement_API_BL.Models
{
    public class Tower
    {
        [Key]
        public int TowerId { get; set; }

        public string TowerDescription { get; set; }
    }
}