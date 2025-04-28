using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ques-1
            //  Write a program that allows the user to enter a number then print it.
            //Console.WriteLine("Enter Your Number");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Your Number is : {Number}");
            #endregion
            #region Ques-2
            /*
             Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
             */
            //string Str = "xyz123";
            //int res;
            //bool isSuccess = int.TryParse(Str, out res);
            //Console.WriteLine(isSuccess);
            //Console.WriteLine(res);

            #endregion
            #region Ques-3
            /*
             Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
             */
            //double num1 = 2.5;
            //double num2 = 2.5;
            //double sum = num1 + num2;
            //Console.WriteLine(sum);

            #endregion
            #region Ques-4
            // Write C# program that Extract a substring from a given string.
            //string myName = "Muhammed Al-Ateeqi";
            //string Res = myName.Substring(9,9);
            //Console.WriteLine(Res);
            #endregion
            #region Ques-5
            /*
             Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
             */
            //int X = 1; 
            //int Y = X;
            //X = 5;
            //Console.WriteLine(X); // 5;
            //Console.WriteLine(Y); // 1;
            // new value for every variable cause value type has dependent instance 
            #endregion
            #region Ques-6
            /*
             Write C# program that Assigning one reference type variable to 
            another and modifying the object through one variable and mention what will happen
             */
            //Point P1 = new Point(); //Unreachable Object
            //Point P2 = new Point();
            //P1.Y = 1;
            //P1.X = 3;
            //P1 = P2;
            //P2.Y = 2;
            //P1.X = 5;
            //Console.WriteLine($"{P1.X} , {P1.Y}"); // (2,5)
            //Console.WriteLine($"{P2.X} , {P2.Y}"); // (2,5)
            // Cause P2 Reference to the same object at heap 
            #endregion
            #region Ques-7
            // Write C# program that take two string variables and print them as one variable 
            //Console.Write("Enter Your First Name : ");
            //string fName = Console.ReadLine();
            //Console.Write("Enter Your Last Name : ");
            //string lName = Console.ReadLine();
            //string FullName = $"{fName} {lName}";
            //Console.WriteLine(FullName);
            #endregion
            #region Ques-8
            /*
             Write a program that calculates the simple interest given the principal amount, rate of interest, and time.
            The formula for simple interest is 
            Interest = (principal * rate * time ) /100.
             */
            //Console.Write(" Enter The Principle :");
            //double Principle = Convert.ToDouble(Console.ReadLine());

            //Console.Write(" Enter The Rate : ");
            //double Rate = Convert.ToDouble(Console.ReadLine());

            //Console.Write(" Enter The Time : ");
            //double Time = Convert.ToDouble(Console.ReadLine());

            //double SimpleIntrestEquation = Principle * Rate * Time / 100.0;
            //Console.WriteLine($"Simple Interst Equals : {SimpleIntrestEquation} ");
            #endregion
            #region Ques-9
            /*
            Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is
            BMI = (Weight)/(Height*Height)
             */
            //Console.Write("Enter Your Weight in Kilogram : ");
            //double Weight = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Your Height in Meter :");
            //double Height = Convert.ToDouble(Console.ReadLine());

            //// BMI Equation
            //double BMI = Weight / (Height * Height);
            //Console.WriteLine($" The BMI is : {BMI}");


            #endregion
            #region Ques-10
            /*
             Write a program that uses the ternary operator to check if the temperature is too hot, too cold,
            or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold",
            above 30 degrees is "Just Hot", and anything else is "Just Good".
             */
            //Console.Write("Enter The Tempreture : ");
            //double Tempreture = Convert.ToDouble(Console.ReadLine());
            //string result = (Tempreture < 10 ? "Just Cold" : (Tempreture > 30 ? "Too Hot": "Just Good"));
            //Console.WriteLine(result);
            #endregion
            #region Ques-11
            /*
             Write a program that takes the date from the user and displays it in various formats using string interpolation.
                Ex :
                Today's date : 20 – 11 – 2001
             */
            //int Day, Month, Year;
            //Console.Write("Day :");
            //Day = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Month :");
            //Month = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Year :");
            //Year = Convert.ToInt32(Console.ReadLine());

            //string Date = $"{Day} - {Month} - {Year}";
            //Console.WriteLine(Date);
            #endregion
            #region Ques-12
            //What is the output of the following C# code?
            //DateTime date = new DateTime(2024, 6, 14); Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            // output => The event is on 06/14/2024
            #endregion
            #region Ques-13
            //Which of the following statements is correct about the C#.NET code snippet given below?
            //     int d;
            //     d = Convert.ToInt32(!(30 < 20));
            // // output will be (1 , True) cause Not(!) Operator reversed the result .
            // // without not the res will be (0 , False if declared by bool datatype)
            // Console.WriteLine(d);
            //bool c = Convert.ToBoolean(!(30 < 20));
            // Console.WriteLine(c);
            #endregion
            #region Ques-14
            //Which of the following is the correct output for the C# code given below?
            //Console.WriteLine(13 / 2 + " " + 13 % 2);
            //answer = > (a) 6.5 1
            #endregion
            #region Ques-15
            // What will be the output of the C# code given below?
            int num = 1, z = 5;
            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);
            // answer => (d) 7 7 "Postfix Topic"
            #endregion
        }
    }
}
