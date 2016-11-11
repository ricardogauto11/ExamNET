using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Drawing;

namespace ExamNET.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Breed { get; set; }
        [Required]
        public DateTime Birth { get; set; }
        public DateTime Creation { get; set; }
        [Required]
        public State State { get; set; }
        public string Avatar { get; set; }
        public TypeAnimal Animal { get; set; }
    }

    public enum State
    {
        FreeForAdoption,
        FreeForSale,
        Adopted,
        Sold                
    }

    public enum TypeAnimal
    {
        Dog,
        Cat,
        Hamster,
        Rabbit
    }
}