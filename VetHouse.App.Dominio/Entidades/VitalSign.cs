using System;

namespace VetHouse.App.Dominio
{
    public class VitalSign : History
    {
        public new int Id { get; set; }
        public float HeartRate { get; set; }
        public float BreathingFreq { get; set; }
        public float Temperature { get; set; }
        public TypeHealthStatus HealthStatus { get; set; }
    }
}