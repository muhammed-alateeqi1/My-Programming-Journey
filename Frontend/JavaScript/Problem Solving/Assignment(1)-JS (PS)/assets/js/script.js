/*
1- Write a program that allow to user enter number then printit
Example
Input: 5
Output: 5
*/ 

// Solution Start -->
// Solution End <--

// Solution Start -->

 
// var value = window.prompt("Enter Your Number");
// console.log(value);

// Solution End <--

// -------------------------------------------------------------------

/*
2- Write a program that take number from user then print yes if that number can divide by 3
and 4 otherwise print no
Example1
Input: 12 Output Yes
Example 2
Input: 9 Output No
*/ 

// Solution Start -->


// var value = window.prompt("Enter Your Number");

// var number = Number(value);

// if(number % 3 ==0 && number % 4==0){
//     console.log("Yes");
// }else{
//     console.log("No");
// }



// Solution End <--


// -------------------------------------------------------------------

/*
3- Write a program that allows the user to insert 2 integers then print the max
Example:
Input: 3 5
Output: 5
Example 2
Input: 10 7
Output: 10
*/

// Solution Start -->
// var num1 = Number(window.prompt("Enter Your First Number"))
// var num2 = Number(window.prompt("Enter Your First Number"))

// if(num1 > num2){
//     console.log('Max Number :',num1);
// }else if(num1 < num2){
//     console.log('Max Number :',num2);
// }else if(num1 == num2){
//     console.log("The entered numbers are equal. Enter one number larger than the other");
// }else{
//     console.log("please enter numbers only");
// }
// Solution End <--


// -------------------------------------------------------------------

/*
4- Write a program that allows the user to insert an integer then print negative if it is
negative number otherwise print positive.
Example 1
Input: -5
Output negative
Example 2
Input: 10
Output positive
*/


// Start Solution -->

// var num = Number(window.prompt("Enter Your Number"))

// if(num > 0){
//     console.log("Positive Number");
// } else if(num < 0){
//     console.log("Negative Number");
// }else{
//     console.log("ZERO");
// }

// End Solution <--

// ------------------------------------------------------------------- 



/*
5- Write a program that take 3 integers from user then print the max element
and the min element.
Example 1
Input:7,8,5
Output:
max element = 8
min element = 5
Example2
Input: 3 6 9
Outputs:
Max element = 9
Min element = 3
*/ 

// Start Solution --->

// var num1 = Number(window.prompt("Enter Your First Number "))
// var num2 = Number(window.prompt("Enter Your Second Number "))
// var num3 = Number(window.prompt("Enter Your Third Number "))

// var maxValue;

// if(num1 >= num2 && num1>=num3){
//     maxValue = num1;
// }else if(num2 >= num1 && num2 >= num3){
//     maxValue = num2;
// }else{
//     maxValue = num3;
// }

// var minValue;
// if(num1 <= num2 && num1<=num3){
//     minValue = num1;
// }else if(num2<=num1 && num2 <=num3){
//     minValue = num2;
// }else{
//     minValue = num3;
// }

// console.log("Max Number",maxValue);
// console.log("Min Number",minValue);

// End Solution --->

// ------------------------------------------------------------------- 


// 

/*
    6- Write a program that allows the user to insert integer number then
    check If a number is oven or odd
    Example 1
    Input: 8
    Output: even
    Example 2
    Input: 7
    Output: odd
*/ 

// Start Solution ---> 

    // var num = Number(window.prompt("Enter the number"))

    // if(num%2==0){
    //     console.log("EVEN Number : ",num);
    // }else if(num%2==1){
    //     console.log("Odd Number : ",num);
    // }else{
    //     console.log("Please Enter Numbers only");
    // }




// End Solution <---





// ------------------------------------------------------------------- 


/*
8- Write a program that take character from user then if it is vowel chars (a,e,I,o,u)
then print vowel otherwise print consonant
Example1
Input: O
Output: vowel
Example 2
Input: b
Output:
Consonant
*/ 

// Start Solution --> 

    // var char = window.prompt("Enter your char");
    // if(char=="a" ||char=="e"||char=="i"||char=="o"||char=="u" ){
    //     console.log("Vowel");
    // }else if(char=="A" ||char=="E"||char=="I"||char=="O"||char=="U"){
    //     console.log("Vowel");
    // }else{
    //     console.log("Consonant");
    // }

// End Solution <--




// ------------------------------------------------------------------- 


/*
9- Write a program that allows user to insert integer then print all numbers between 1 to
that’s number
Example Input 5
Output 1, 2, 3, 4, 5
*/ 

// Start Solution --->

//  var number = Number(prompt("Enter The Number"));
//  var output =" ";

//  for(i=1; i <= number; i++ ){
//     output+=i;
// }
// console.log(output);

// End Solution --->




// ------------------------------------------------------------------- 

/*
10- Write a program that allows user to insert integer then print a multiplication table up to 12.
Example
Input: 5
Outputs:
5 10 15 20 25 30 35 40 45 50 55 60
*/ 
     
// Start Solution --->

//  var number = Number(prompt("Enter The Number"));
//  var multiplicationTable;

//    for( var i=0; i<=12; i++){
//     multiplicationTable = number*i;
//     console.log(multiplicationTable);
// }
// End Solution <--




// ------------------------------------------------------------------- 




/*
11- Write a program that allows to user to insert number then print all even numbers
between 1 to this number
Example:
Input: 15
Output: 2 4 6 8 10 12 14
*/ 
    // Start Solution --->

//   var number = Number(prompt("Enter The Number"));  
//   for (var i = 2; i <= number; i+=2) {
//       console.log(i);
//   }
  
    // End Solution --->



// ------------------------------------------------------------------- 





/*

12- Write a program that take two integers then print the power
Example:
Input: 4 3
Output: 64
Hint how to calculate 4^3 = 4 * 4 * 4 =64

*/ 

// Start Solution --->
// var baseNumber = Number(prompt("Enter the base number:"));
// var exponent = Number(prompt("Enter the exponent:"));

// var power = 1; 
// for (var i = 0; i < exponent; i++) {
//     power *= baseNumber;
// }


// console.log("The result of " + baseNumber + "^" + exponent + " is:", power);
// End Solution <---
// ------------------------------------------------------------------- 


/*
13- Write a program to enter marks of five subjects and calculate total, average and
percentage.
Example
Input: - Enter Marks of five subjects:
95
76
58
90
89
Output:-.Total marks = 435
Average Marks =87
Percentage =87
*/ 
// Start Solution --->

// var subj1 = Number(prompt("Enter Your Subject 1:"));
// var subj2 = Number(prompt("Enter Your Subject 2:"));
// var subj3 = Number(prompt("Enter Your Subject 3:"));
// var subj4 = Number(prompt("Enter Your Subject 4:"));
// var subj5 = Number(prompt("Enter Your Subject 5:"));

//  var totalMarks = subj1+subj2+subj3+subj4+subj5;

//  var averageMarks = totalMarks / 5;

//  var percentage = (totalMarks/500) * 100;

//  console.log("totalMarks is :",totalMarks);
//  console.log("AverageMarks is :",averageMarks);
//  console.log("Percentage is :",percentage);

// End Solution <---
// ------------------------------------------------------------------- 

/*
14- Write a program to input marks of five subjects
Physics, Chemistry, Biology, Mathematics and Computer
, Find percentage and grade
Percentage >= 90%: Grad A
Percentage >= 80%: Grad B
Percentage >= 70%: Grad C
Percentage >= 60%: Grad D
Percentage >= 40%: Grad E
Percentage < 40%: Grad F
*/ 
// Start Solution --->
//     var physics = Number(window.prompt("Mark of Physics"));
//     var chemistry = Number(window.prompt("Mark of Chemistry"));
//     var biology = Number(window.prompt("Mark of Biology"));
//     var mathematics = Number(window.prompt("Mark of Mathematics"));
//     var computer = Number(window.prompt("Mark of Computer"));
    
//     var totalMarks = physics + chemistry + biology + mathematics + computer;
//     var percentage = (totalMarks / 500)*100;

//     if(percentage >= 90){
//         console.log("Percentage : ",percentage+"%");
//         console.log("Grad : A");
//     }else if(percentage >= 80){
//         console.log("Percentage : ",percentage);
//         console.log("Grad : B");
//     }
// else if(percentage >= 70){
//         console.log("Percentage : ",percentage);
//         console.log("Grad : C");
//     }else if(percentage >= 60){
//         console.log("Percentage : ",percentage);
//         console.log("Grad : D");
//     }else if(percentage >= 40){
//         console.log("Percentage : ",percentage);
//         console.log("Grad : E");
//     }else if(percentage < 40){
//         console.log("Percentage : ",percentage);
//         console.log("Grad : F");
//     }else{
//         console.log("Please Enter Integrs value only");
//     }


// End Solution <---
// ------------------------------------------------------------------- 




// 14-Write a program to input month number and print number of days in that
// month.
// Example:
// Input: - Month Number: 1
// Output:-. Days in Month: 31

// Solution Start --->

// var monthNumber = Number(window.prompt("Enter Month Number"));
// var daysInMonth;

// if(monthNumber === 1 ||monthNumber === 3 ||monthNumber === 5 ||monthNumber === 7 ||monthNumber === 8 ||monthNumber === 10 ||monthNumber === 12){
//     daysInMonth = 31;
// }else if(monthNumber === 4 ||monthNumber === 6 ||monthNumber === 9 ||monthNumber === 11){
//     daysInMonth = 30;
// }else if(monthNumber === 2){
//     daysInMonth = 28;
// }else{
//     console.log('incorrect Month Number ');
// }
// if(daysInMonth){
//     console.log('days in Month : ',daysInMonth);
// }

// Solution End <---
// ------------------------------------------------------------------- 


/*
15- Write a program to print total number of days in month
*/ 

// Solution Start--->
/*
var monthNumber = Number(window.prompt("Enter Month Number"))
var dayInMonth;

switch(monthNumber){
    case 1:
        dayInMonth = 31;
        console.log('Days in Month : ', dayInMonth);
    break;
    case 3:
        dayInMonth = 31;
        console.log('Days in Month : ', dayInMonth);
    break;
    case 5:
        dayInMonth = 31;
        console.log('Days in Month : ', dayInMonth);
    break;
    case 7:
        dayInMonth = 31;
        console.log('Days in Month : ', dayInMonth);
    break;
    case 8:
        dayInMonth = 31;
        console.log('Days in Month : ', dayInMonth);
    break;
    case 10:
        dayInMonth = 31;
        console.log('Days in Month : ', dayInMonth);
    break;
    case 12:
        dayInMonth = 31;
        console.log('Days in Month : ', dayInMonth);
    break;

    case 4:
        dayInMonth = 30;
        console.log('Days in Month : ', dayInMonth);
    break;
    case 6:
        dayInMonth = 30;
        console.log('Days in Month : ', dayInMonth);
    break;
    case 9:
        dayInMonth = 30;
        console.log('Days in Month : ', dayInMonth);
    break;
    case 11:
        dayInMonth = 30;
        console.log('Days in Month : ', dayInMonth);
    break;

    case 2:
        dayInMonth = 28;
        console.log('Days in Month : ', dayInMonth);
    break;
    default:
        console.log("incorrect Month Number ");
}
*/ 
// Solution End <---
// ------------------------------------------------------------------- 


/*
16- Write a program to check whether an alphabet is vowel or consonant (a,e,I,o,u)

*/ 

// Solution Start --->
/*
var char = window.prompt("Enter any character")

switch(char){
    case 'a' || 'A':
    case 'e' || 'E':
    case 'i' || 'I':
    case 'o' || 'O':
    case 'u' || 'U':
        console.log("vowel");
        break;
    default:
    console.log("consonant");
    break;
}

*/ 
// Solution End <---
// ------------------------------------------------------------------- 



// 17- Write a program to find maximum between two numbers

// Solution Start --->
/*
var num1=Number(prompt("Enter First Number"))
var num2=Number(prompt("Enter Second Number"))
var maxNumber;
switch(true){
    case num1 > num2:
        maxNumber = num1
        console.log("Max Number is :",maxNumber); 
        break;
    case num2 > num1:
        maxNumber = num2
        console.log("Max Number is :",maxNumber); 
        break;
    default:
        console.log("First Number Equals Second Number");
}

*/ 

// Solution End <---
// ------------------------------------------------------------------- 

// Solution Start --->

// 18- Write a program to check whether a number is even or odd

/*
var number = Number(window.prompt("Enter the First number"))

switch(true){
    case number%2==0:
        console.log("Even");
        break;
    default:
        console.log("Odd");
        break;
}
*/ 
// Solution End <---

// ------------------------------------------------------------------- 

// 19- Write a program to check whether a number is positive or negative or zero

// Solution Start --->

/*
var number = Number(window.prompt("Enter Your Number"));

switch(true){
   case number > 0:
       console.log("Positive Number :",number);
       break;
   case number < 0:
       console.log("Negative Number :",number);
       break;
   default:
       console.log("ZERO :",number);  
}
*/ 

// Solution End <---
// ------------------------------------------------------------------- 


// 20- Write a program to create Simple Calculator

// Solution Start --->
// var num1 = Number(window.prompt("Enter First Number:"));
// var operation = window.prompt("Enter operation (+, -, *, /):");
// var num2 = Number(window.prompt("Enter Second Number:"));
// var result;

// switch(operation) {
//     case '+':
//         result = num1 + num2;
//         console.log("Result:", result);
//         break;
//     case '-':
//         result = num1 - num2;
//         console.log("Result:", result);
//         break;
//     case '*':
//         result = num1 * num2;
//         console.log("Result:", result);
//         break;
//     case '/':
//         if (num2 !== 0) {
//             result = num1 / num2;
//         } else {
//             console.log("Error: Division by zero!");
//         }
//         break;
//     default:
//         console.log("Incorrect operation entered.");
// }
// Solution End <---
