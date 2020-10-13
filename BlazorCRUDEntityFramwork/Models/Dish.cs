using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDEntityFramwork.Models
{
    public class Dish
    {
        public int DishId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
