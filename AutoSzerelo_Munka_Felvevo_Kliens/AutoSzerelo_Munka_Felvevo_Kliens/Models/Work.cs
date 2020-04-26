﻿using System;

namespace AutoSzerelo_Munka_Felvevo_Kliens.Models
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
