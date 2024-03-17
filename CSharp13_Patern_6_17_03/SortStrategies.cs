using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13_Patern_6_17_03
{
    interface ISortStrategy<T>
    {
        void Sort(List<T> items);
    }

    
    class SortByPriceAscending : ISortStrategy<Product>
    {
        public void Sort(List<Product> items)
        {
            items.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));
        }
    }

    class SortByPriceDescending : ISortStrategy<Product>
    {
        public void Sort(List<Product> items)
        {
            items.Sort((p1, p2) => p2.Price.CompareTo(p1.Price));
        }
    }
}
