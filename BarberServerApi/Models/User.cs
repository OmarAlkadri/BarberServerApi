using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarberServerApi.Models
{
    public class User
    {
        public int UserId { get; set; }

        public String UserName { get; set; }

        public int yas { get; set; }

        public int? PersonnelId { get; set; }
        public virtual Personnel Personnel { get; set; }

        public int? CommentslId { get; set; }
        public ICollection<Comments>? Comments { get; set; }
        public int? ReservationBarberId { get; set; }
        public ICollection<ReservationBarber>? ReservationBarber { get; set; }
    }
}
