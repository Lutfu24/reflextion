using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Reflextion
{
    internal static class Store
    {
        public static Product[] products;
        public static Product[] bproducts;
        public static Product[] dproducts;
        public static Product[] mproducts;

        public static Food type;

        static Store()
        {
            products = new Product[0];
            bproducts = new Product[0];
            dproducts = new Product[0];
            mproducts = new Product[0];

            type = new Food();
        }
        public static void AddProduct()
        {
        no:
            Console.WriteLine("Please enter no");
            string no = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(no))
            {
                goto no;
            }
        str:
            Console.WriteLine("Please enter name");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                goto str;
            }
        price:
            Console.WriteLine("Please enter price");
            double price;
            bool result = double.TryParse(Console.ReadLine(), out price);
            if (!result)
            {
                goto price;
            }
        type:
            Console.WriteLine("Please enter type: Baker 1: Drink 2: Meat 3");
            int num;
            bool count = int.TryParse(Console.ReadLine(), out num);
            if (num != (int)Food.Baker && num != (int)Food.Drink && num != (int)Food.Meat)
            {
                goto type;
            }
            Product product = new Product(no,name,price,type);
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }

        public static void RemoveProductByNo()
        {
            Console.WriteLine("Please enter no");
            string no = Console.ReadLine();
            foreach (var product in products)
            {
                if (product.No==no)
                {
                    product.Name.Remove(0);
                }
                else
                {
                    Console.WriteLine("Product not found");
                }
            }
        }

        public static void FilterProductsByType()
        {
            Console.WriteLine("Please enter type: Baker 1: Drink 2: Meat 3");
            int num;
            bool count = int.TryParse(Console.ReadLine(), out num);
            foreach (var product in products)
            {
                if (num == (int)Food.Baker)
                {
                    Array.Resize(ref bproducts, bproducts.Length + 1);
                    bproducts[bproducts.Length - 1] = product;
                }
                foreach (var item in bproducts)
                {
                    Console.WriteLine(item);
                }
                if (num == (int)Food.Drink)
                {
                    Array.Resize(ref dproducts, dproducts.Length + 1);
                    dproducts[dproducts.Length - 1] = product;
                }
                foreach (var item in dproducts)
                {
                    Console.WriteLine(item);
                }
                if (num == (int)Food.Meat)
                {
                    Array.Resize(ref mproducts, mproducts.Length + 1);
                    mproducts[mproducts.Length - 1] = product;
                }
                foreach (var item in mproducts)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void FilterProductByName()
        {
            Console.WriteLine("Please enter str");
            string str = Console.ReadLine();
            foreach (Product product in products)
            {
                if (product.Name.Contains(str))
                {
                    Console.WriteLine(product.Name);
                }
            }
        }

       
    }
}
