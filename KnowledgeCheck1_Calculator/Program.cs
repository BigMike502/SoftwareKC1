using System;

namespace KnowledgeCheck1_Calculator
{
  class Program : CheckExpressions
  {


    static void Main(string[] args)
    {
      string snumber1;
      string snumber2;
      string input;
      var calculator = new Calculator();


    start:
      Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

      input = Console.ReadLine();

      if (CheckOperatorInput(input) != true)
      {
        Console.Clear();
        Console.WriteLine($"{input} is not a correct value.");
        goto start;
      }
      else
      {
        Console.Clear();
        InfoCheck.CheckType(input);
      }

    Number1:
      Console.WriteLine("Please Enter the 1st of two numbers you would like to calculate.");
      snumber1 = (Console.ReadLine());
      if (IsInputANumber(snumber1) != true)
      {
        Console.Clear();
        Console.WriteLine($"{snumber1} is not a correct value, Please Enter in a number from 0-9.");
        goto Number1;
      }
      else
      {
        Console.Clear();
        Console.WriteLine($"The number you entered was {snumber1}");
      }

    Number2:
      Console.WriteLine("Please Enter the 2nd of two numbers you would like to calculate.");
      snumber2 = (Console.ReadLine());
      if (IsInputANumber(snumber2) != true)
      {
        Console.Clear();
        Console.WriteLine($"{snumber2} is not a correct value, Please Enter in a number from 0-9.");
        goto Number2;
      }
      else
      {
        Console.Clear();
        Console.WriteLine($"The number you entered was {snumber1}");
      }

      double inumber1 = Convert.ToDouble(snumber1);
      double inumber2 = Convert.ToDouble(snumber2);
      double total;

      switch (input)
      {
        case "1":
          total = calculator.Add(inumber1, inumber2);
          Console.Write($"{inumber1} + {inumber2} = {total}");
          break;

        case "2":
          total = calculator.Subtract(inumber1, inumber2);
          Console.Write($"{inumber1} - {inumber2} = {total}");
          break;

        case "3":
          total = calculator.Multiply(inumber1, inumber2);
          Console.Write($"{inumber1} * {inumber2} = {total}");
          break;

        case "4":
          total = calculator.Divide(inumber1, inumber2);
          Console.Write($"{inumber1} / {inumber2} = {total}");
          break;

      }
    }
  }
}