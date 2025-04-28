//using System.ComponentModel;

using System.Text;

namespace Assignment_5
{
    internal class Program
    {
        #region Helper
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        #endregion
        #region Question-1 is Function
        //static void SwapByValue(int a, int b)
        // {
        //     int Changer;
        //     Changer = b;
        //     b = a;
        //     a = Changer;
        //     Console.WriteLine($"The Vlaue of arguments inside The Function {a},{b}");

        // }  
        // static void SwapByRef( ref int a,  ref int b)
        // {
        //     int Changer;
        //     Changer = b;
        //     b = a;
        //     a = Changer;

        // }
        #endregion
        #region Question-2 is Function
        //static void increment(int[] Arr) 
        //{
        //    Arr[0] += 1;
        //    Console.WriteLine($"Inside The Function : ");
        //    for(int i=0; i < Arr.Length; i++)
        //    {
        //        Console.Write(Arr[i] + " ");
        //    }
        //    Console.WriteLine();
        //}
        #endregion
        #region Question-3 is Function
        //static void Calculations(int[]ArrOfIntegers)
        //{
        //    int SubmtionOfTwoNumbers = ArrOfIntegers[0] + ArrOfIntegers[1];
        //    int SubtractingOfTwoNumbers = ArrOfIntegers[2] - ArrOfIntegers[3];
        //    Console.WriteLine($"Submtion of The First Two Numbers : {SubmtionOfTwoNumbers}\nSubtracting of Second Two Numbers :  {SubtractingOfTwoNumbers}");
        //}
        #endregion
        #region Question-4 is Function
        // static void SumIndividualDigits(int AcualNumber)
        //{
        //    int SumOfIndividualNumbers = 0;
        //    while (AcualNumber > 0)
        //    {
        //        int Digit = AcualNumber % 10;
        //        SumOfIndividualNumbers += Digit;
        //        AcualNumber = AcualNumber / 10;
        //    }
        //    Console.WriteLine();

        //    Console.WriteLine($"Sum Of Individual Numbers : {SumOfIndividualNumbers} ");
        //}
        #endregion
        #region Question-5 is Function
        //static void isPrime(int ActualNumber)
        //{
        //    if (ActualNumber % 2 != 0)
        //    {
        //        Console.WriteLine($"True Prime Number : {ActualNumber}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"False This Number:{ActualNumber} is not a Prim Number");
        //    }
        //}
        #endregion
        #region Question-6 is Function
        //static void MinMax(ref int[] Arr)
        //{
        //    int max = Arr[0]; // Start Form Index One 
        //    int min = Arr[0]; // Start From Index One
        //    for (int i =0; i < Arr.Length -1; i++) 
        //    {
        //        if (max > Arr[i]) // Check if the max Greaterthan The i or Not if max > i // assign the max 
        //        {
        //            max = Arr[i];
        //        }
        //        if (min < Arr[i]) // Check if the min Lowerthan The i or Not if min < i // assign the min
        //        {
        //            min = Arr[i];
        //        }
        //    }
        //    Console.WriteLine($"The Maxinum Value is : {max}");
        //    Console.WriteLine($"The Minimum Value is : {min}");

        //}
        #endregion
        #region Question-7 is Function
        //static void GetFactorial(int NumberFactorial)
        //{
        //    int f = 1;
        //    for (int i = 1 ; i <= NumberFactorial; i++)
        //    {
        //        f =  f * i;
        //    }
        //    Console.WriteLine($"The Factorial of this Number {NumberFactorial} is : {f}");
        //}
        #endregion
        #region Question-8 is Function
        //static void ChangeChar(StringBuilder word , int index, char NewChar)
        //{
        //    // without Using Parameters 
        //    //StringBuilder WordBeforeChange = new StringBuilder("Learn");
        //    //Console.WriteLine($"Word Before Change : {WordBeforeChange}\n");
        //    //WordBeforeChange[0] = 'E';
        //    //string WordAfterChange = WordBeforeChange.ToString();
        //    //Console.WriteLine($"Word After Change : {WordAfterChange}");

        //    word[index] = NewChar;
        //}   
        #endregion
        static void Main(string[] args)
        {
            // 1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            #region Answer
            // 1. In pass-by value, a copy of the value of the argument is passed to the function.

            // 2. The called function works with the copy of the value and any modifications made within the function do not affect the original value outside the function.

            // 3. The original value remains unchanged.

            // Example
            //Console.WriteLine("-------------- Pass By Value --------------");
            //int x = 5 , y = 3 ;
            //Console.WriteLine($"Before Passing the Values {x} , {y}"); // 5 , 3
            //SwapByValue(x, y);
            //Console.WriteLine($"Afyer Passing the Values {x} , {y}"); // 5 , 3

            // Passing By Reference (i Will Use Ref) To Pass The Acual Address As a Arguments to Swap Function

            //Console.WriteLine("-------------- Pass By Ref --------------");

            //Console.WriteLine($"Before Passing the Values {x} , {y}"); // 5 , 3
            //SwapByRef(ref x, ref y);
            //Console.WriteLine($"Afyer Passing the Values {x} , {y}"); // 3 , 5

            #endregion
            // 2- Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example.
            #region Answer
            /*
       Pass by reference:

        1. In pass-by reference, a reference or memory address of the argument is passed to the function.

        2. The called function can directly access and modify the original value of the argument using the reference.

        3. Any modifications made to the parameter within the function will affect the original value outside the function.
             */
            // ex
            //int[] MyList = { 10, 20, 30 };
            // increment(MyList);
            //Console.WriteLine($"Outside the Function : ");
            //for (int i = 0; i < MyList.Length; i++)
            //{
            //    Console.Write(MyList[i] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(MyList[0]);
            #endregion
            // 3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            #region Answer
            //int[] FourNumbers = new int[4];
            //int UserInput = 0;
            //for (int i = 0; i < FourNumbers.Length; i++)
            //{
            //    bool isValid = false;
            //    while (!isValid)
            //    {
            //    Console.WriteLine("Enter a Number");
            //    string input = Console.ReadLine();
            //    if (int.TryParse(input, out UserInput))
            //        {
            //            FourNumbers[i] = UserInput;
            //            isValid = true;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid Input! Please Enter a Valid integer");
            //        }
            //    }

            //}
            ////to Display
            //for (int i = 0; i < FourNumbers.Length; i++)
            //{
            //    Console.Write(FourNumbers[i] + (i < FourNumbers.Length - 1 ?"," : "\n"));
            //}

            // Calculations(FourNumbers);

            // try to make this code protective to avoid the exceptions
            #endregion
            // 4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            #region Answer
            //Console.Write("Enter a Number : ");
            //bool Flag = false;
            //if (!Flag)
            //{
            //    if (int.TryParse(Console.ReadLine(), out int UserInput))
            //    {
            //      SumIndividualDigits(UserInput);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid number.");
            //    }
            //}
            #endregion
            // 5- Create a function named "IsPrime", which receives an integer number and returns true if it is prime, or false if it is not:
            #region Answer
            //Console.Write("Check Your Number isPrime Number or Not : ");

            //bool isValid = int.TryParse(Console.ReadLine(), out int UserInput);
            //Console.WriteLine(isValid ? $"The Number You Entered is {UserInput}" : "Invalid Input Please Enter a Valid Number " );
            //isPrime(UserInput);
            #endregion
            // 6- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            #region Answer
            //int[] array = { 10, 30, 40, 100, 170, 50, 20, 60 };
            //MinMax(ref array);
            #endregion
            // 7- Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            #region Answer
            //Console.Write("Enter A Number : ");
            //bool isValid = int.TryParse(Console.ReadLine(), out int userInput);
            //if (isValid)
            //{
            //    GetFactorial(userInput);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid! Input Please Enter a Number");
            //}
            #endregion
            // 8- Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            #region Answer
            //StringBuilder myWord = new StringBuilder("Learn");

            //Console.Write("Enter The Char Index : ");
            //int index = int.Parse(Console.ReadLine());
            //Console.Write("Enter The Char : ");
            //char newChar = Console.ReadLine()[0];

            //Console.WriteLine($"Word Before Change : {myWord}");
            //ChangeChar(myWord, index, newChar);
            //Console.WriteLine($"Word After Change : {myWord}");

            #endregion
            // 9- Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            #region Answer
            //Console.Write("Enter Identitiy Matrix size (n)  : " );
            //int n = int.Parse(Console.ReadLine());
            //for (int i =0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1");
            //        }
            //        else
            //        {
            //            Console.Write("0");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            // 10- Write a program in C# Sharp to find the sum of all elements of the array.
            #region Answer
            //int[] Arr = { 10, 20, 30, 40 };
            //int TotalArrElemets = 0;
            //for (int i = 0; i < Arr.Length; i++) {
            //    TotalArrElemets += Arr[i];
            //}
            //Console.WriteLine($"Total Sum Of Array Elemnts = {TotalArrElemets}");
            #endregion
            // 11- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            #region Answer
            //int[] Arr1 = { 1, 3, 5, 7 };
            //int[] Arr2 = { 2, 4, 6, 8 };
            //int[] MergedArray = new int[8];
            //int i = 0 , j = 0 , k = 0 ;
            //while (i < Arr1.Length && j < Arr2.Length)
            //{
            //    if (Arr1[i] < Arr2[j])
            //    {
            //        MergedArray[k] = Arr1[i];
            //        i++;
            //    }
            //    else
            //    {
            //        MergedArray[k] = Arr2[j];
            //        j++;
            //    }
            //    k++;
            //}

            //while (i < Arr1.Length)
            //{
            //    MergedArray[k++] = Arr1[i++];
            //}

            //while (j < Arr2.Length)
            //{
            //    MergedArray[k++] = Arr2[j++];
            //}
            //PrintArray(MergedArray);
            #endregion
            // 12- Write a program in C# Sharp to count the frequency of each element of an array.
        }


    }
}
