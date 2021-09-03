using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BarberServerApi.Models
{
    public partial class Neighborhood
    {

        public int NeighborhoodId { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public string NeighborhoodName { get; set; }

        public int ProvinceId { get; set; }
        public virtual Province Province { get; set; }

        public int DistrictId { get; set; }
        public virtual ICollection<District> District { get; set; }
    }
}
