# .net

using System;

namespace Exercises<br>
{

    class BinaryTriangle
    {
        static void Main(string[] args)
        {
            int number, digit = 1;<br>
            Console.Write("\nEnter the number of lines:");
            number = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= number; i++)
            {
                for (int space = number - i; space > 0; space--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(digit + " ");
                    digit = (digit == 1) ? 0 : 1;
                }
                Console.Write("\n");
            }
            
        }
    }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940475/154415939-8376da3c-f862-42ba-be3e-037a2c9fc26e.png)<br>


using System;

namespace Exercises<br>
{

    class AmicableNumber
    {
        static void Main(string[] args)
        {
            int num1, num2, sum1 = 0, sum2 = 0;
            Console.WriteLine("\n-----------AMICABLE NUMBER--------\n");
            Console.Write("\nEnter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            for(int i=1;i<num1;i++)
            {
                if(num1%i==0)
                {
                    sum1 += i;
                }
            }
            for(int i=1;i<num2;i++)
            {
                if (num2%i==0)
                {
                    sum2 += i;
                }
            }
            if(sum1==num2 && sum2==num1)
            {
                Console.WriteLine("\nThe numbers {0} and {1} are amicable.", num1, num2);
            }
            else
            {
                Console.WriteLine("\nThe numbers {0} and {1} are not amicable.", num1, num2);
            }
        }
    }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940475/154425518-d110acb3-9901-4fb7-bd1b-4bed4f611d6c.png)<br>
![image](https://user-images.githubusercontent.com/97940475/154627211-6dc00b0e-3d74-4594-9fb8-8f98fd976e87.png)<br>






