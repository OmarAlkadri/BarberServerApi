using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberServerApi.ViewModels
{
    public class ReservationModel
    {
        public int BarberId { get; set; }
        public string BarberShowName { get; set; }
        public string BarberImg { get; set; }
        public string times { get; set; }
        public PayingOffModel PayingOffModel { get; set; }
        public ContactInfoModel ContactInfoModel { get; set; }
    }
}
