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

        public int PayingOffId { get; set; }
        public int paid { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
     //   [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString =  "{mm/dd/yyyy-hh:mm}")]
        public DateTime PayingTime { get; set; }

        public int? ReservationBarberId { get; set; }
        public virtual List<ReservationBarber> ReservationBarber { get; set; }
    }
}