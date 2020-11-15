using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TLCN_WEB.Models
{
    public class Dish
    {
        public string Dish_ID { get; set; }
        public string DishName { get; set; }
        public int DishPrice { get; set; }
        public string DishPicture { get; set; }
        public int DishType_ID { get; set; }
        public int Menu_ID { get; set; }
    }
}
