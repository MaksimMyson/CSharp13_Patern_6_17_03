namespace CSharp13_Patern_6_17_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            List<Product> products = new List<Product>
        {
            new Product("Ноутбук", 1500),
            new Product("Смартфон", 800),
            new Product("Планшет", 600),
            new Product("Монітор", 300),
            new Product("Клавіатура", 100)
        };

            
            ProductSorter sorter = new ProductSorter(new SortByPriceAscending());
            sorter.SortProducts(products);
            Console.WriteLine("Сортування за зростанням ціни:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            
            sorter.SetSortStrategy(new SortByPriceDescending());
            sorter.SortProducts(products);
            Console.WriteLine("\nСортування за спаданням ціни:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
