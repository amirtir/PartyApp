using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyApp.Models
{
    public class Guest
    {
        [Required(ErrorMessage = "نام خود را وارد کنید")]
        public string Name { get; set; }
        [Required(ErrorMessage = "نام خانوادگی خود را وارد کنید")]
        public string Family { get; set; }
        [Required(ErrorMessage = "تلفن خود را وارد کنید")]
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
    }
}
