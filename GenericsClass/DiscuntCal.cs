using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClass
{

    
    public class DiscuntCal<TProduct> where TProduct : Prodcut
    {
        public void CalculateDiscount(TProduct product)
        {
            product.Price = 12;
        }
    }
}
