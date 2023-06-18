﻿using PizzaApp.Models.Enums;

namespace PizzaApp.Models.Domain
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsOnPromotion { get; set; }
        public PizzaSizeEnum PizzaSize { get; set; }
        public bool HasExtras { get; set; }
    }
}
