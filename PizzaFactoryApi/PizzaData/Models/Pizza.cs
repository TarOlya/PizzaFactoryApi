using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace PizzaData.Models
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Description { get; set; }
        public ICollection<PizzaIngredient> Recipe { get; set; }
    }
}