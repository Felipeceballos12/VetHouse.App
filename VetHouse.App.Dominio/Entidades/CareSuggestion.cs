using System;

namespace VetHouse.App.Dominio
{
    public class CareSuggestion : History
    {
        public new int Id { get; set; }
        public String Description { get; set; }

        public System.DateTime CreatedAtCareSuggestion { get; set; }
    }
}