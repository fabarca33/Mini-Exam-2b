using System;
using System.Linq;

class Program {
  public static double DetermineHypotenuse(double num1, double num2)
  {
    double num3 = 0;

    num3 = Math.Sqrt((num1*num1)+(num2*num2));

    return num3;
  }

  public static void Main (string[] args) {

    double hypotenuse = 0.0;

    Console.WriteLine ("To determine the hypotenuse of a triangle, please enter the lenght of one of the sides");

    double line1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine ("Please enter the lenght of one of the other side");

    double line2 = Convert.ToDouble(Console.ReadLine());

    hypotenuse = DetermineHypotenuse(line1, line2);

    Console.WriteLine("The hypotenuse of the triangle is " +hypotenuse);    
  }
}