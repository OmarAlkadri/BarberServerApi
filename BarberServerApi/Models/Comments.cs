using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BarberServerApi.Models
{
    public partial class Comments
    {
        public int CommentsId { get; set; }

        public int EntityPostId { get; set; }
        public virtual EntityPost EntityPost { get; set; }

        public string Comments1 { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
