using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace RinasWeb.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Volume { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public int[] Ratings { get; set; }
        public DateTime Published { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);

    }
}
