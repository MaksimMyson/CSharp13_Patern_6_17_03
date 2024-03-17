using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13_Patern_6_17_03
{
    class ProductSorter
    {
        private ISortStrategy<Product> _sortStrategy;

        public ProductSorter(ISortStrategy<Product> sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void SetSortStrategy(ISortStrategy<Product> sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void SortProducts(List<Product> products)
        {
            _sortStrategy.Sort(products);
        }
    }
}
