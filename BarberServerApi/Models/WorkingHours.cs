using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberServerApi.Models
{
    public class WorkingHours
    {
        public int WorkingHoursId { get; set; }
        public int OpeningTime { get; set; }
        public int closingTime { get; set; }
        public List<int> WorkingHoursOfDay { get; set; }
        public List<Days> WorkingDaysOfWeek { get; set; }
        public List<Min> WorkingMinOfHours { get; set; }
        public int BarberId { get; set; }
        public Barber Barber { get; set; }
    }
}
