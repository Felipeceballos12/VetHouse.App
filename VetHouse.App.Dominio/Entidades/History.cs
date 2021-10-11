using System.Collections.Generic;
using System;

namespace VetHouse.App.Dominio
{
    public class History
    {
        public int Id { get; set; }
        public System.DateTime CreatedAtHistory { get; set; }
        public String Diagnose { get; set; }

        public List<CareSuggestion> CareSuggestions { get; set; }
        public List<VitalSign> VitalSigns { get; set; }
    }
}