using BarberServerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberServerApi.ViewModels
{
    public class ShowBarberModel
    {
        public int BarberId { get; set; }
        public string BarberShowName { get; set; }
        public int OpeningTime { get; set; }
        public int closingTime { get; set; }
        public string BarberImg { get; set; }
        public ContactInfoModel ContactInfoModel { get; set; }
    }
}
