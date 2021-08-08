using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BarberServerApi.Models
{
    public partial class ContactInfo
    {
        public int ContactInfoId { get; set; }
        public int? DistrictId { get; set; }
        public int? PersonnelId { get; set; }


        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public string StreetAvenueName { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public virtual District District { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public virtual Personnel Personnel { get; set; }
    }
}
