using System;

namespace PizzaFactoryApi.ViewModels
{
    public class IngredientModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public string ImageUrl { get; set; }
    }
}