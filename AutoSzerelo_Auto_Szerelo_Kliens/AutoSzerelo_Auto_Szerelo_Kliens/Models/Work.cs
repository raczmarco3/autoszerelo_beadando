using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSzerelo_Auto_Szerelo_Kliens.Models
{
    class Work
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
