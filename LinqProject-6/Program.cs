namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2-datalarım
            //LİNQ = Language Integrated Query(DİLE ENTEGRE EDİLMİŞ SORGU)
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName ="Bilgisayar" },
                new Category{CategoryId = 2, CategoryName ="Telefon" }
            };
            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1,CategoryId = 1, ProductName = "Acer Laptop,",QuantityPerUnit = "32 GB RAM",UnitPrice = 10000,UnitInStock = 5 },
                new Product{ProductId = 2,CategoryId = 1, ProductName = "Asus Laptop,",QuantityPerUnit = "16 GB RAM",UnitPrice = 8000,UnitInStock = 3 },
                new Product{ProductId = 3,CategoryId = 1, ProductName = "HP Laptop,",QuantityPerUnit = "8 GB RAM",UnitPrice = 6000,UnitInStock = 2 },
                new Product{ProductId = 4,CategoryId = 2, ProductName = "Samsung Telefon,",QuantityPerUnit = "4 GB RAM",UnitPrice = 5000,UnitInStock = 15 },
                new Product{ProductId = 5,CategoryId = 2, ProductName = "Apple Telefon,",QuantityPerUnit = "4 GB RAM",UnitPrice = 8000,UnitInStock = 0 },
            };
            Console.WriteLine("Algoritmik ---------------------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
                
            }
            Console.WriteLine("Linq ---------------------------");
            var result = products.Where(product => product.UnitPrice > 5000 && product.UnitInStock > 3);
            //where metodu listemiz için bir döngü oluşturuyor.şarta uyanların her birini yeni listeye atıyor.
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
            
        }
        
        
    }
    //1-classlarım
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}