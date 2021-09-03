using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BarberServerApi.Models
{
    public partial class ReservationBarber
    {
        public int ReservationBarberId { get; set; }

        public string Day { get; set; }
        public string Hour { get; set; }
        public string Min { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public int UserId { get; set; }

        public virtual User User { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public int BarberId { get; set; }
        public virtual Barber Barber { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public string ReservationType { get; set; }

        public int? PayingOffId { get; set; }
        public PayingOff PayingOff { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public bool reservationStatus { get; set; }
    }
}
