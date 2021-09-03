using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BarberServerApi.Models
{
    public partial class Barber
    {
        public int BarberId { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        [StringLength(20, ErrorMessage = "{0} alanı en fazla 20 karakter olmalı")]
        public string BarberShowName { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public string CertificationImgUrl { get; set; }

        public int? CommentsId { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }


        public int? PersonnelId { get; set; }
        public virtual Personnel Personnel { get; set; }

        public int? WorkingHoursId { get; set; }
        public virtual WorkingHours WorkingHours { get; set; }


        public virtual ICollection<ReservationBarber> ReservationBarber { get; set; }


        public int? ContactInfoId { get; set; }
        public virtual ContactInfo ContactInfo { get; set; }
    }
}
