using System.ComponentModel.DataAnnotations;

namespace ParkingMangement_API_Common
{
    public class Actionlog
    {
        [Key]
        public int ActionLogId { get; set; }
        public string ControllerDescrption { get; set; }
        public string ActionExectionInfo { get; set; }
        public string IPAddressInfo { get; set; }
        public string ExectionTime { get; set; }
    }
}