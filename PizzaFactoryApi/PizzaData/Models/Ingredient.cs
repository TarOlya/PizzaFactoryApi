using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaData.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public ICollection<PizzaIngredient> Pizzas { get; set; } 
    }
}