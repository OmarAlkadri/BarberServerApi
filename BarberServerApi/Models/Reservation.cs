using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BarberServerApi.Models
{
    public partial class Reservation
    {
        public Reservation()
        {
            ReservationBarber = new HashSet<ReservationBarber>();
        }

        public int ReservationId { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public TimeSpan ReservationTime { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public virtual PayingOff Paying { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public virtual ICollection<ReservationBarber> ReservationBarber { get; set; }


    }
}
