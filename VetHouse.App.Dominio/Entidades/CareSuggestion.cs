using System;

namespace VetHouse.App.Dominio
{
    public class CareSuggestion
    {
        public int Id { get; set; }
        public String Description { get; set; }

        public System.DateTime CreatedAtCareSuggestion { get; set; }

        public int idCareSuggestion { get; set; }
        public CareSuggestion careSuggestion { get; set; }
    }
}