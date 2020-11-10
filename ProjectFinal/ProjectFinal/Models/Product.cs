using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Models
{
    public class Product
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
        public string Despition { set; get; }
        public int Count { set; get; }
        public string Color { set; get; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } 
    }
}
