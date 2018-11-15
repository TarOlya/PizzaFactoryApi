using System;
using System.Collections.Generic;

namespace PizzaFactoryApi.ViewModels
{
    public class PizzaModel
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public IEnumerable<IngredientModel> Recipe { get; set; }
    }
}