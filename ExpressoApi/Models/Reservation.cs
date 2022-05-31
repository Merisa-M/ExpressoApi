using OpenXmlPowerTools;
using System;
using System.ComponentModel.DataAnnotations;

namespace ExpressoApi.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-] +)@([\w\-]+)((\.(\W){2,3})+$")]
        public string Email { get; set; }
        [Required]
        [RegularExpression("^[]*$")]
        public string Phone { get; set; }
        [Required]
        public int TotalPeople { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public string Time { get; set; }
    }
}
