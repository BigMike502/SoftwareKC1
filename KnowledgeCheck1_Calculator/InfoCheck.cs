using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
  class InfoCheck
  {
    public static void CheckType(string EquationType)
    {
      switch (EquationType)
      {
        case "1":
          Console.WriteLine($"You would like to add your numbers, Please enter in your numbers!");
          break;
        case "2":
          Console.WriteLine($"You would like to Subtract your numbers, Please enter in your numbers!");
          break;
        case "3":
          Console.WriteLine($"You would like to Multiply your numbers, Please enter in your numbers!");
          break;
        case "4":
          Console.WriteLine($"You would like to Divide your numbers, Please enter in your numbers!");
          break;
      }
    }
  }
}
