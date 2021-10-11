using System.Collections.Generic;
using System;

namespace VetHouse.App.Dominio
{
    public class Vet : Person
    {
        public string RegisterRethus { get; set; }
        public string Specialty { get; set; }
        public List<Pet> Pets { get; set; }
    }
}