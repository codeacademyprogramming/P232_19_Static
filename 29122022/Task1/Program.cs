using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CodeAcademy codeAcademy = new CodeAcademy();


            string opt;
            do
            {
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("0. Exit");

                opt = Console.ReadLine();


                switch (opt)
                {
                    case "1":
                        Console.WriteLine("Fullname");
                        string fullname = Console.ReadLine();
                        Console.WriteLine("GroupNo");
                        string groupNo  = Console.ReadLine();
                        Console.WriteLine("Email");
                        string email = Console.ReadLine();
                        Console.WriteLine("Password");
                        string password = Console.ReadLine();
                        Console.WriteLine("ConfirmsPassword");
                        string confirmPassword = Console.ReadLine();

                        var result = codeAcademy.Register(email, password, confirmPassword, fullname, groupNo);

                        if (result.IsSucceed)
                            Console.WriteLine("Qeydiyyatdan kecdiniz!");
                        else
                            result.ShowErrors();

                        break;
                    case "2":
                        Console.WriteLine("Email");
                        email = Console.ReadLine();
                        Console.WriteLine("Password");
                        password = Console.ReadLine();

                        result = codeAcademy.Login(email, password);

                        if (result.IsSucceed)
                            Console.WriteLine("Sisteme daxil oldunuz!");
                        else
                            result.ShowErrors();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Secim yanlsidir!");
                        break;
                }

            } while (opt!="0");


            


        }
    }
}
