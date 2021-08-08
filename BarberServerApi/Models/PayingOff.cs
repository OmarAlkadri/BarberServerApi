using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BarberServerApi.Models
{
    public partial class PayingOff
    {
        public PayingOff()
        {
            Reservation = new HashSet<Reservation>();
        }
        public int PayingOffId { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public TimeSpan PayingTime { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}
