# .net
1)C# program to print a Binary Triangle.<br>
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

2)C# program to check whether the entered number is an Amicable Number or Not.<br>
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

3)c# program to illustrate Multilevel Inheritance with virtual Methods(displaying student details).<br>
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

4)C# program to create a grey Code.<br>
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

5)C# program to Calculate volume of 2 boxes and find the resultant volume after addition of 2 boxes by implementing operator overloading.<br>
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

    





 







