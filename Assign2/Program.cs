using System;

namespace Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            char Option;
            Console.WriteLine("Enter the marks obtained");
            i = Convert.ToInt32(Console.ReadLine());
            if (i > 30 && i <= 45)
            {
                Option = '1';

            }
            else if (i > 45 && i <= 60)
            {
                Option = '2';
            }
            else if (i > 60 && i <= 75)
            {
                Option = '3';
            }
            else if (i > 75 && i <= 100)
            {
                Option = '4';
            }
            else
            {
                Option = '5'; 
            }
                switch (Option)
            {
                case '0':
                    
                    
                        Console.WriteLine("Grade F");
                        break;

                    
                case '1':
                    
                    
                        Console.WriteLine("Grade C");
                        break;
                    
                case '2':
                    
                    
                        Console.WriteLine("Grade B");
                        break;
                    
                case '3':
                    
                    
                        Console.WriteLine("Grade A");
                        break;

                case '4':

                    Console.WriteLine("FAIL");
                    break;
                  
                default:
                    Console.WriteLine("wrong input");
                    break;
            }
        }
    }
}
