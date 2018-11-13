using System;

namespace PizzaData.Models
{
    public class PizzaIngredient: BaseEntity
    {
        public Guid PizzaId { get; set; }
        public Pizza Pizza { get; set; }

        public Guid IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}