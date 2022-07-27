﻿namespace BlazorAppButton.Data
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string Name { get; set; }
        public decimal BasePrice { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string GetFormattedBasePrice() => BasePrice.ToString("0.00");
        public decimal Price { get; set; }
        public bool Vegetarian { get; set; }
        public bool Vegan { get; set; }
    }
}