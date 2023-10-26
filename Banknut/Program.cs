

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banknut
{
    internal class Program
    {

        static int savingaccount = 10000;
        static void Main(string[] args)

           
           
        {
            for (int i = 0; i < 5;)
            {

                Console.WriteLine("hello");

                Console.Write("user : ");

                string user = Console.ReadLine();
                Console.Write("pass : ");
                string pass = Console.ReadLine();


                SayHello(user, pass);


            }




        }


        public static void SayHello(string user, string pass) 
        {
            if (user == "111")
            {
                if (pass == "111")
                {
                    for (int j = 0; j < 5;)
                    {
                        Console.Write("Enter your need d,w,c (deposit/withdrow/cancel) : ");
                        string need = Console.ReadLine();
                        if (need == "d")
                        {
                            Console.Write("need deposit : ");
                            string deposit = Console.ReadLine();
                            int deposit1 = int.Parse(deposit);
                            savingaccount = savingaccount + deposit1;
                            Console.WriteLine("You Monny :" + savingaccount);

                        }
                        else if (need == "w")
                        {
                            Console.Write("Enter your withdrow amount : ");
                            string withdrow = Console.ReadLine();
                            int withdrow1 = int.Parse(withdrow);
                            savingaccount = savingaccount - withdrow1;
                            Console.WriteLine("You Monny :" + savingaccount);
                        }
                        else if (need == "c")
                        {
                            break;
                        }


                    }



                }



            }
            else

            {
                Console.WriteLine("error");
            }

        }




    }

}
