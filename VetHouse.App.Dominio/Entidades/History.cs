using System;

namespace VetHouse.App.Dominio
{
    public class History
    {
        public int Id { get; set; }
        public System.DateTime CreatedAtHistory { get; set; }
        public String Diagnose { get; set; }

        public CareSuggestion CareSuggestion { get; set; }
        public VitalSign VitalSign { get; set; }
    }
}