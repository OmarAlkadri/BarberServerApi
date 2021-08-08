using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BarberServerApi.Models
{
    public partial class District
    {
        public District()
        {
            ContactInfo = new HashSet<ContactInfo>();
        }
        public int DistrictId { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public string DistrictName { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]

        public virtual Neighborhood Neighborhood { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public virtual ICollection<ContactInfo> ContactInfo { get; set; }
    }
}
