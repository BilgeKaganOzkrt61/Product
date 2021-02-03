using System;

namespace Productbk
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 10;
            product1.ProductName = "Sweatshirt";
            product1.ProductPrice = 120;
            product1.ProductSize = "S,M,L";
            product1.ProductFeature = "Oversize and colorful";

            Product product2 = new Product();
            product2.Id = 11;
            product2.ProductName = "Jeans";
            product2.ProductPrice = 90;
            product2.ProductSize = "M,L";
            product2.ProductFeature = "Blue and tight";

            Product product3 = new Product();
            product3.Id = 14;
            product3.ProductName = "Socks";
            product3.ProductPrice = 40;
            product3.ProductSize = "40,41";
            product3.ProductFeature = "Black,red,blue and long";

            Product product4 = new Product();
            product4.Id = 20;
            product4.ProductName = "T-Shirt";
            product4.ProductPrice = 55;
            product4.ProductSize = "S,L";
            product4.ProductFeature = "Limited Edition";

            Console.WriteLine("Products Listed");

            Product[] products = new Product[] { product1, product2, product3, product4 };

            foreach (var product in products)
            {
                Console.WriteLine( product.Id + " --> " + product.ProductName + " :: " +
                    product.ProductPrice + " : " + product.ProductSize + " : "  + product.ProductFeature  );
            }

            


        }
    }
}
