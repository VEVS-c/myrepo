using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            


            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;

            string name = "skendy";           
            Console.WriteLine("  Type in your password...  ");
            label:
            string varbl = Console.ReadLine();

            if (name == varbl)
            {
                Console.Clear();

                Console.WriteLine(" OK ");

                Console.Clear();

                Console.WriteLine(" Type in a number...");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                Console.WriteLine(" Type in another number...");
                int b = Convert.ToInt32(Console.ReadLine());
                

                 Console.WriteLine("Izaberi: A za Sabiranje, B za Oduzimanje, C za Mnozenje, D za Dijeljenje: ");
                 var input = Console.ReadLine();


                void A()
                {
                    int x = a + b;
                    Console.WriteLine(" Sabiranje: " + x);
                }
                void B()
                {
                    int y = a - b;
                    Console.WriteLine(" Oduzimanje: " + y);              
                }
                void C()
                {
                    int z = a * b;
                    Console.WriteLine(" Mnozenje: " + z);
                }
                void D()
                {
                    int c = a / b;
                    Console.WriteLine(" Dijeljenje: " + c);
                    
                }
                



                

                if (input == "A")
                {
                    A();
                }
                if (input == "B")
                {
                    B();
                }
                if (input == "C")
                {
                    C();
                }
                if (input == "D")
                {
                    D();
                }
               
                
            }
            else
            {
                Console.WriteLine("Wrong password, try again.");

                Console.Clear();
                
                goto label;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }

    // 25.6.2019 23:35
}
