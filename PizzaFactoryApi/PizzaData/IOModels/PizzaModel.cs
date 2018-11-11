using System;

namespace PizzaData.IOModels
{
    public class PizzaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int[] Ingredients { get; set; }
        public int Cost { get; set; }
    }
}