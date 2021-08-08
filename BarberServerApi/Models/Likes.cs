using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BarberServerApi.Models
{
    public partial class Likes
    {
        public int LikesId { get; set; }
        public int likes { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public virtual User User{ get; set; }

        public int EntityPostId { get; set; }
        public EntityPost EntityPost { get; set; }
    }
}
