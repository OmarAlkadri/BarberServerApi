using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BarberServerApi.Models
{
    public partial class Province
    {
        public int ProvinceId { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public string ProvinceName { get; set; }

        public int NeighborhoodId { get; set; }
        public virtual ICollection<Neighborhood> Neighborhood { get; set; }
    }
}
