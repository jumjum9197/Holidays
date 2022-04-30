using System;

namespace Holidays
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int amount = 0;
            tife:
            Console.WriteLine("wat size of coffe do you want?");
           var size =Convert.ToInt32(Console.ReadLine());
            
            switch (size)
            {
                case 1:
                    amount += 1;
                    break;
                    case 2:
                    amount += 2;
                    break;
                case 3:
                    amount += 3;
                    break;
                    default:
                    Console.WriteLine("invalid");
                    break;



            }
            Console.WriteLine("thanks for your patronage");
            Console.WriteLine("do you which to buy another coffe? yes or no");
            string another = (Console.ReadLine().ToUpper().Trim());
            switch (another)
            {
                case "YES":
                    goto tife;
                case "NO":
                    break;

            }
               
                
                





            if (amount == 1)
            {
                Console.WriteLine($"bill:{ amount} dollar");

            }
            else
            {
                Console.WriteLine($"bill: {amount} dollars");
            }


            
        }
    }
}
