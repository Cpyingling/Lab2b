/*Author: Charles Yingling        Date: 9/8/2021
*/
using System;

class Program {
  public static void Main (string[] args) {
    //ask for 2 numbers and save to num1 and num2
    Console.WriteLine ("Enter a number.");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("Enter another number.");
    double num2 = Convert.ToDouble(Console.ReadLine());
    //Add numbers and save to sum
    double sum = num1 + num2;
    //display sum
    Console.WriteLine ("Sum = " +sum);
    //Subtract number 2 from 1 and save as diff
    double diff = num1 - num2;
    //display diff
    Console.WriteLine ("Diff = " +diff);
    //* 2 numbers and save as product
    double product = num1 * num2;
    //display product
    Console.WriteLine ("Product = " +product);

    /*
    Questions on quotient part
    */
    //divide num 1 by 2 and save as quotient
    double quotient = num1 / num2; //displays 1.875 
    //double quotient = Convert.ToInt32(num1 / num2); //displays 2
    
    //display quotient
    Console.WriteLine ("Quotient = " +quotient);
    //find remainder using % on num 1 & 2 and save as remainder
    double remainder = num1 % num2;
    //display remainder
    Console.WriteLine ("Remainder = " +remainder);
  }
}