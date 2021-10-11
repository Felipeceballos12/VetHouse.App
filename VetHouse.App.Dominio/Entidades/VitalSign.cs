using System;

namespace VetHouse.App.Dominio
{
    public class VitalSign
    {
        public int Id { get; set; }
        public float HeartRate { get; set; }
        public float BreathingFreq { get; set; }
        public float Temperature { get; set; }
        public TypeHealthStatus HealthStatus { get; set; }
        public DateTime CreatedAtVitalSign { get; set; }
    }
}