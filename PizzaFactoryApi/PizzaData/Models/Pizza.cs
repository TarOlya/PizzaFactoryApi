using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PizzaData.Models
{
    public class Pizza: BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double Cost { get; set; }
        public string Description { get; set; }
        public ICollection<PizzaIngredient> Recipe { get; set; }
        public bool Hit { get; set; }
    }
}