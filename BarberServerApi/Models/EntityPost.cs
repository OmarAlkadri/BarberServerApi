using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BarberServerApi.Models
{
    public partial class EntityPost
    {
        public int EntityPostId { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public string EntityPostText { get; set; }

        public string? EntityPostTime { get; set; }

        public string? EntityImgVideoUrl { get; set; }

        public int BarberId { get; set; }
        public Barber Barber { get; set; }

        public int CommentsId { get; set; }
        public virtual ICollection<Comments>? Comments { get; set; }

        public int LikesId { get; set; }
        public virtual ICollection<Likes>? Likes { get; set; }
    }
}
