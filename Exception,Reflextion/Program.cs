namespace Exception_Reflextion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double selection;
            Console.WriteLine("Welcome");
            do
            {
            start:
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Filter product name");
                Console.WriteLine("3. Remove product");
                Console.WriteLine("4. Filter product type");
                bool result = double.TryParse(Console.ReadLine(), out selection);
                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            Console.Clear();
                            Store.AddProduct();
                            break;
                        case 2:
                            Console.Clear();
                            Store.FilterProductByName();
                            goto start;
                            break;
                        case 3:
                            Console.Clear();
                            Store.RemoveProductByNo();
                            goto start;
                            break;
                        case 4:
                            Console.Clear();
                            Store.FilterProductsByType();
                            goto start;
                            break;
                        default:
                            Console.WriteLine("Enter valid number:");
                            goto start;
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    goto start;
                }
            } while (selection != 0);
        }
    }
}