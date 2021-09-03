using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BarberServerApi.Models
{
    public partial class Personnel
    {
        public int PersonnelId { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public string PersonnelName { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public string PersonnelSurname { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public Gender PersonelGender { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                         ErrorMessage = "Email adresi geçersiz!")]
        public string PersonnelMaill { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        [DataType(DataType.Password)]
        public string PersonnelPassword { get; set; }

        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                           ErrorMessage = "Entered phone format is not valid.")]
        public string PersonnelPhone { get; set; }


        public string PersonnelImageUrl { get; set; }

        public int? barberId { get; set; }
        public virtual ICollection<Barber> Barber { get; set; }

        public int? userId { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
