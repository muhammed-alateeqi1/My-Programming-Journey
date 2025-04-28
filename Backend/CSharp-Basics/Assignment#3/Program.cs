using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Transactions;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}
class Program
{
    public static object Slope_1 { get; private set; }
    public static object Slope_2 { get; private set; }

    static void Main(string[] args)
    {
        #region #Ques-1
        // 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
        Console.WriteLine("Enter a Number");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine(num1 % 3 == 0 && num1 % 4 == 0 ? "Yes" : "No");
        #endregion

        #region #Ques-2
        // 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
        Console.WriteLine("Check ur Numebr is (- OR +) ");
        int num2 = int.Parse(Console.ReadLine());
        if (num2 > 0) {
            Console.WriteLine("Positive Number");
        }
        else
        {
            Console.WriteLine("Nigative Number");
        }
        #endregion

        #region #Ques-3
        // 3- Write a program that takes 3 integers from the user then prints the max element and the min element.
        Console.WriteLine("Enter Your First Number");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Your Second Number");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Your Therd Number");
        int n3 = int.Parse(Console.ReadLine());
        // Find The Max Value
        if (n1 > n2 && n1 > n3)
        {
            Console.WriteLine($"{n1} is Max Value ");
        }
        else if (n2 > n1 && n2 > n3)
        {
            Console.WriteLine($"{n2} is Max Value ");
        }
        else
        {
            Console.WriteLine($"{n3} is Max Value ");
        }
        // Find The Minimum Value
        if (n1 < n2 && n1 < n3)
        {
            Console.WriteLine($"{n1} is the Minimum Value.");
        }
        else if (n2 < n1 && n2 < n3)
        {
            Console.WriteLine($"{n2} is the Minimum Value.");
        }
        else
        {
            Console.WriteLine($"{n3} is the Minimum Value.");
        }
        #endregion

        #region #Ques-4
        // 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
        Console.WriteLine("Check Your Number (Even Or Odd)");
        int num4 = int.Parse(Console.ReadLine());
        Console.WriteLine(num4 % 2 == 0 ? $"{num4} is : Even" : $"{num4} is : Odd");
        #endregion

        #region #Ques-5
        // 5 - Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
        Console.WriteLine("Enter Your Char");
        char UserInput = char.Parse(Console.ReadLine());
        if (UserInput == 'a' || UserInput == 'e' || UserInput == 'i' || UserInput == 'o' || UserInput == 'u')
        {
            Console.WriteLine("Vowel");
        }
        else
        {
            Console.WriteLine("Consonant");

        }

        #endregion

        #region #Ques-6
        // 7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
        Console.WriteLine("Enter Integer Number");
        int TableNum = int.Parse(Console.ReadLine());
        for (int i = 0; i <= 12; i++)
        {
            Console.WriteLine($"{TableNum} x {i} = {TableNum * i}");
        }
        #endregion

        #region #Ques-7
        // 9- Write a program that takes two integers then prints the power.
        Console.WriteLine("Enter Your Base Number");
        int baseNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter The Exponent Number");
        int exponent = int.Parse(Console.ReadLine());
        int res = 1;
        if (exponent < 0)
        {
            Console.WriteLine("This Program Can't Recived Nigative Exponents");
        }
        else
        {
            for (int i = 1; i <= exponent; i++)
            {
                res *= baseNumber;
            }
            Console.WriteLine($"{baseNumber} to the power of {exponent} is : {res}");
        }
        #endregion

        #region #Ques-8
        // 10- Write a program to enter marks of five subjects and calculate total, average and percentage.
        Console.WriteLine("Enter The Mark of  Subject (1)");
        int subMark1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter The Mark of  Subject (2)");
        int subMark2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter The Mark of  Subject (3)");
        int subMark3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter The Mark of  Subject (4)");
        int subMark4 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter The Mark of  Subject (5)");
        int subMark5 = int.Parse(Console.ReadLine());

        // Calculate Total 
        int Total;
            
        Total = subMark1 + subMark2 + subMark3 + subMark4 + subMark5;
       
        // Calculate Avaerage 
        double Avg = Total / 5.0;
        // Calculate Percentage 
        double Percentage = (Total / 500.0) * 100;
        // Results
        Console.WriteLine($"Marks of All Subjects is : {Total}");
        Console.WriteLine($"Average : {Avg}");
        Console.WriteLine($"Percentage : {Percentage}");

        #endregion

        #region #Ques-9
        Console.WriteLine("Enter The Month Number:");
        int month = int.Parse(Console.ReadLine());

        int days;
        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                days = 31;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                days = 30;
                break;
            case 2:
                // Feb Case if it 28 day or 29
                Console.Write("Enter the year: ");
                int year = int.Parse(Console.ReadLine());

                bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
                days = isLeap ? 29 : 28;
                break;
            default:
                Console.WriteLine("Invalid month! Please enter a number from 1 to 12.");
                return;
        }
            Console.WriteLine($"Month {month} has {days} days.");
        #endregion

        #region #Ques-10
        /* 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3),
        and determines whether these points lie on a single straight line.  */
        // Pooint (1)
        Console.WriteLine("Enter coordinates of point 1 (x1 , x1) : ");
        Console.Write("x1 :");
        int x1 = int.Parse(Console.ReadLine());
        Console.Write("y1 :");
        int y1 = int.Parse(Console.ReadLine());
        // Pooint (2)
        Console.WriteLine("Enter coordinates of point 2 (x2 , y2) : ");
        Console.Write("x2 :");
        int x2 = int.Parse(Console.ReadLine());
        Console.Write("y2 :");
        int y2 = int.Parse(Console.ReadLine());
        //Point (3)
        Console.WriteLine("Enter coordinates of point 3 (y3 , y2) : ");
        Console.Write("x3 :");
        int x3 = int.Parse(Console.ReadLine());
        Console.Write("y3 : ");
        int y3 = int.Parse(Console.ReadLine());
        /*
           Point 1 = (x1 , y1) 
           Point 2 = (x2 , y2)
              y2-y1 / x2-x1
         */

        double solpe1 = (double)(y2 - y1) / (x2 - x1);
        /*
        Point 2 = (x2 , y2)
        Point 3 = (x3 , y3)
           y3-y2 / x3-x2
      */
        double slope2 = (double)(y3 - y2) / (x3 - x2);
        if (solpe1 == slope2)
        {
            Console.WriteLine("The points lie on the same straight line.");
        }
        else
        {
            Console.WriteLine("The points do not lie on the same straight line.");
        }
        #endregion

        #region #Ques-11
        /*
         18- Within a company, the efficiency of workers is evaluated based on the duration required to
        complete a specific task. A worker's efficiency level is determined as follows: 
        - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
        - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
        - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
        - If the worker takes more than 5 hours, they are required to leave the company. 
        To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
         */
        Console.WriteLine("Enter the time (in hours) taken to complete the task:");
        int time = int.Parse(Console.ReadLine());
        // Complete The Task Between (2:3)

        if (time > 2 && time <= 3)
        {
            Console.WriteLine("they are considered highly efficient");
        }else if(time >3 && time <= 4)
        {
            Console.WriteLine("they are instructed to increase their speed");
        }else if (time > 4 && time <=5)
        {
            Console.WriteLine("they are provided with training to enhance their speed");
        }else if (time > 5)
        {
            Console.WriteLine("they are required to leave the company");
        }
        else
        {
            Console.WriteLine("Invalid input: Time should be 2 hours or more.");
        }


        #endregion

        #region #Ques-12
        //21- Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
        int a = 10;
        int b = a;
        // a value will be 10 and b value will be (10);
        Console.WriteLine($"Orignal Value of (a): {a}");
        Console.WriteLine($"Orignal Value of (b): {b}");

        a = 20;
        // (a) value will be 20 and (b) value will be (10);

        Console.WriteLine($"Value of (a) : {a}");
        Console.WriteLine($"Value of (b) : {b}");

        #endregion

        #region #Ques-13
        /* Write C# program that Assigning one reference type variable to another and modifying the object through one 
          variable and mention what will happen*/
        Point P1;
        P1 = new Point();
        Point P2 = new Point(); 
        P2 = P1; // P2 TAKE P1 ADDRESS
        P1.X = 10;
        // (P2)  Unreachable Object (Garbage Collector Automaticly will Clear it )
        Console.WriteLine(P2.X);
        Console.WriteLine(P1.X);
        // P1.x Value Equals (10) and P2.x Equales (10) Cause "P2" Takes The Same Address of "P1"
        #endregion

        #region #Ques-14
        // Which of the following statements is correct about the C#.NET code snippet given below? 
        /*
         * Answer 
         *  (b) A value 1 will be assigned to d.
         *  Explanation
        1) 30 < 20 == False;
        2) !false = true;
        3) Convert.Toint32(true) will converts the true into (1)
        (Final Result) The vakue assigned to (d) = 1
         */

        #endregion

        #region #Ques-15
        // Which of the following is the correct output for the C# code given below?
        // Answer (6.5 1)

        #endregion

        #region #Ques-16
        //What will be the output of the C# code given below?
        // Answer d) 7 7 
        #endregion

        /*
         Big Thank For Eng/Mahmoud & Eng/Mostafa <3
         */
    }
}
