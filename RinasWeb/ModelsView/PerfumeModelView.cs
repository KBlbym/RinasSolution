using RinasWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RinasWeb.ModelsView
{
    public class PerfumeModelView
    {
        public IEnumerable<Product> Products {get; set;}
        public IEnumerable<Category> Catecories {get; set;}
    }
}
