using System;
using System.Collections.Generic;

namespace VetHouse.App.Dominio
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TypePet Type { get; set; }
        public string Breed { get; set; }
        public string Address { get; set; }
        public float Latitud { get; set; }
        public float Longitude { get; set; }
        public float Weight { get; set; }

        public System.DateTime DateOfBirth { get; set; }
        public GenderPet Gender { get; set; }

        /// agregando las relaciones con las clases relacionadas
        public AuxVet AuxVet { get; set; }
        public History History { get; set; }
        public Owner Owner { get; set; }

        public int idVet { get; set; }
        public Vet Vet { get; set; }
    }
}