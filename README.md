# .net
1)Write a C# program to print fibonacci series without using recursion and using recursion.<br>
using System;

namespace Exercises<br>
{

    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements:");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            
            for (i = 2; i < number; ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3+" ");
                n1 = n2;
                n2 = n3;
            }

        }
    }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940475/156505831-2f26bc2d-66b5-4ad3-a4f6-791d3b1604fd.png)<br>

2)Write a C# program to check prime number.<br>
using System;

namespace Exercises<br>
{

    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime:");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");
        }
    }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940475/156507398-309d6fd1-b81a-4979-874a-c896e0a7dfaa.png)<br>
![image](https://user-images.githubusercontent.com/97940475/156507488-00d6461c-3950-40fd-ab25-2b6802477859.png)<br>

3)Write a C# program to check palindrome number.<br>
using System;

namespace Exercises<br>
{

    class Palindrome
    {
    
        static void Main(string[] args)
        {
            int n,r, sum = 0, temp;
            Console.Write("Enter the Number:");
            n = int.Parse(Console.ReadLine());
            temp = n;
            
            while(n>0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome.");
        }
    }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940475/156508153-c7b85057-dc81-4d44-b761-b7b4c901a9e2.png)<br>
![image](https://user-images.githubusercontent.com/97940475/156508220-20215039-921b-4161-926b-983137ebfdc2.png)<br>

4)Write a C# program to print factorial of a number.<br>
using System;

namespace Exercises<br>
{

    class Factorial
    {
        static void Main(string[] args)
        {
            int i, fact = 1, number;
            Console.Write("Enter any Number:");
            number = int.Parse(Console.ReadLine());
            
            for(i=1;i<=number;i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is:" + fact);
        }
    }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940475/156509481-bd1ba284-e7f1-4414-b00f-62db37bce03c.png)<br>

5)Write a C# program to check whether the given element is Armstrong or not.<br>
using System;

namespace Exercises<br>
{

    class Armstrong
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number=");
            n = int.Parse(Console.ReadLine());
            temp = n;
            
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Armstrong Number");
            else
                Console.Write("Not Armstrong Number");
        }
    }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940475/156510060-2215a164-8abc-4f12-9217-94506a472d57.png)<br>
![image](https://user-images.githubusercontent.com/97940475/156510196-2f5c2c79-905d-43eb-a7ce-d4a24c6db184.png)<br>

6)Write a C# program to find the sum of digits.<br>
using System;

namespace Exercises<br>
{

    class Sum
    {
        static void Main(string[] args)
        {
            int n, sum = 0, m;
            Console.Write("Enter a number:");
            n = int.Parse(Console.ReadLine());
            
            while(n>0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write("Sum is=" + sum);
        }
    }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940475/156510932-61989d3d-a02d-47a2-96a5-0162dab1f62f.png)<br>

7)Write a C# program to reverse given number.<br>
using System;

namespace Exercises<br>
{

    class Reverse
    {
        static void Main(string[] args)
        {
            int n, reverse = 0, rem;
            Console.Write("Enter a number:");
            n = int.Parse(Console.ReadLine());
            
            while(n!=0)
            {
                rem = n % 10;
                reverse = reverse*10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number:" + reverse);
        }
    }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940475/156511532-c8a227e7-2768-4fea-9788-160601ff810c.png)<br>

8)C# program to print a Binary Triangle.<br>
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

9)C# program to check whether the entered number is an Amicable Number or Not.<br>
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

10)C# program to illustrate Multilevel Inheritance with virtual Methods(displaying student details).<br>
using System;

namespace Exercises<br>
{

    class PersonalDetails
    {
        string name;
        int age;
        string gender;
        public PersonalDetails(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public virtual void Display()
        {
            Console.WriteLine("\n..........PERSONAL DETAILS..........\n");
            Console.WriteLine("Name    :" + name);
            Console.WriteLine("Age     :" + age);
            Console.WriteLine("Gender  :" + gender);
        }
    }
    class CourseDetails : PersonalDetails
    {
        int regNo;
        string course;
        int semester;
        public CourseDetails(string name, int age, string gender, int regNo, string course, int semester) : base(name, age, gender)
        {
            this.regNo = regNo;
            this.course = course;
            this.semester = semester;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("\n..........COURSE DETAILS..........\n");
            Console.WriteLine("Register Number    :" + regNo);
            Console.WriteLine("Course             :" + course);
            Console.WriteLine("Semester           :" + semester);

        }
    }

    class MarksDetails : CourseDetails
    {
        int[] marks = new int[5];
        int total;
        float average;
        string grade;
        int flagFail;
        public MarksDetails(String name, int age, string gender, int regNo, string course, int semester, int[] marks) : base(name, age, gender, regNo, course, semester)
        {
            total = 0;
            
            for (int i = 0; i < 5; i++)
            {
                this.marks[i] = marks[i];
                total += marks[i];
                if (marks[i] < 35)
                {
                    flagFail = 1;
                }
            }
            Calculate();
        }
        private void Calculate()
        {
            average = total / 5;
            if (flagFail == 1 || average < 40)
                grade = "Fail";
            else if (average >= 70)
                grade = "Distinction";
            else if (average >= 60)
                grade = "First Class";
            else if (average >= 50)
                grade = "Second Class";
            else
                grade = "Pass Class";
        }
        public override void Display()
        {
            base.Display();
                Console.WriteLine("\n..........MARKS DETAILS..........\n");
                Console.Write("Marks in 5 subjects:");
                for (int i = 0; i < 5; i++)
                    Console.Write(marks[i] + " ");
                Console.WriteLine();
                Console.WriteLine("Total      :" + total);
                Console.WriteLine("Average    :" + average);
                Console.WriteLine("Grade      :" + grade);

            }
        }
        class MultiLevel
        {
            public static void Main(string[] args)
            {
                MarksDetails Student1 = new MarksDetails("Abjhijith", 22, "Male", 20190001, "MCA", 5, new int[] { 77, 80, 98, 95, 90 });
                Student1.Display();

            }
        }
}
    
OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940475/154632315-63f1fa9d-4728-45d4-b717-fdc4a4cadfb5.png)<br>

11)C# program to create a grey Code.<br>
using System;

namespace Exercises<br>
{

    class GrayCode
    {
        static int getGray(int n)
        {
            return n ^ (n >> 1);
        }
        static void Main(string[] args)
        {
            int InputNum, GrayNum;
            Console.Write("\nEnter the decimal number:");
            InputNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nBinary equivalent of {0}:{1}", InputNum, Convert.ToString(InputNum, 2));
            GrayNum = getGray(InputNum);
            Console.WriteLine("\nGray Code equivalent of {0}:{1}", InputNum, Convert.ToString(GrayNum, 2));
        }
    } 
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940475/154635295-6b3b5acd-63e2-429c-a54c-475eae1e002c.png)<br>

12)C# program to Calculate volume of 2 boxes and find the resultant volume after addition of 2 boxes by implementing operator overloading.<br>
using System;

namespace Exercises<br>
{

    class Box
    {
        float width;
        float height;
        float length;
        public float Volume
        {
            get { return width * height * length; }
        }
        public Box(float width, float height, float length)
        {
            this.width = width;
            this.height = height;
            this.length = length;
        }
        public static float operator +(Box box1, Box box2)
        {
            return box1.Volume + box2.Volume;
        }
        public override string ToString()
        {
            return "box with width" + width + ",height" + height + "and length" + length;
        }
    }
        class OperatorOverloading
        {
            public static void Main()
            {
                Box box1 = new Box(10, 20, 30);
                Box box2 = new Box(25, 32, 15);
                Console.WriteLine("Volume of {0} is:{1}", box1, box1.Volume);
                Console.WriteLine("Volume of {0} is:{1}", box2, box2.Volume);
                Console.WriteLine("Volume after adding boxes:{0}", box1 + box2);
            }
        }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940475/154637878-56fecc75-5864-4c40-b430-9d7d79dcad67.png)<br>

13)C# program to Implement principles of Delegates (Converting input string to uppercase first,last and entire string)<br>

    





 







