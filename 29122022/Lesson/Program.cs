using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student() { FullName = "Hikmet Abbasov",GroupNo = "P220"};
            Student std2 = new Student() { FullName = "Abbas Abbasov",GroupNo="P123"};
            Student std3 = new Student() { FullName = "Qurban Abbasov",GroupNo = "P121"};

            Console.WriteLine(std1.No);
            Console.WriteLine(std2.No);
            Console.WriteLine(std3.No);


            Console.WriteLine(Product.Counter);
            Console.WriteLine(Calculator.Pow(4,5));


            Console.WriteLine(Math.Pow(10,4));
            Console.WriteLine(Math.Abs(-450));
            Console.WriteLine(Math.Max(34, 55));
            Console.WriteLine(Math.Min(34,55));
            Console.WriteLine(Math.Floor(34.99));
            Console.WriteLine(Math.Round(34.51));
            Console.WriteLine(Math.Ceiling(34.1));




            Product[] products = new Product[0];

            Product product1 = new Product();
            Product product2 = new Product();
            Product product3 = new Product();
            Product product4 = new Product();

            Console.WriteLine(Product.Counter);




            string opt;
            do
            {
                Console.WriteLine("1.Mehsul elave et");
                Console.WriteLine("2. Mehsullara bax");
                Console.WriteLine("3. Mehsullarin sayini goster");
                Console.WriteLine("0. Menudan cix");


                opt = Console.ReadLine();


                switch (opt)
                {
                    case "1":
                        string name;

                        do
                        {
                            Console.WriteLine("Ad:");
                            name = Console.ReadLine();

                        } while (!Product.CheckName(name));

                        string priceStr;
                        double price;

                        do
                        {
                            Console.WriteLine("Qiymet:");
                            priceStr = Console.ReadLine();
                        } while (!double.TryParse(priceStr,out price) || price<0);

                        break;
                    case "2":
                        break;
                    case "3":
                        Console.WriteLine();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Seciminiz yanlisdir!");
                        break;
                }

            } while (opt!="0");
        }

        
    }
}
