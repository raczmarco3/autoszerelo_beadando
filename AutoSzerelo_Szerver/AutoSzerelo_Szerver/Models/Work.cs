using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSzerelo_Szerver.Models
{
    public class Work
    {
        public long WorkId { get; set; }
        public string ClientName { get; set; }
        public string CarType { get; set; }
        public string LicensePlate { get; set; }
        public string Problem { get; set; }
        public DateTime Date { get; set; }
        public string State { get; set; }

    }
}
