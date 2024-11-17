using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
  internal class CheckExpressions
  {

    public static bool IsInputANumber(string number)
    {

      if (Regex.Match(number, @"^[0-9]+$").Success)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static bool CheckOperatorInput(string number)
    {
      if (Regex.Match(number, @"^[1-4]{1}$").Success)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static bool CheckYesOrNo(string YesOrNo)
    {
      if (Regex.Match(YesOrNo, @"^(?:yes\b|y\b|no\b|n\b)$").Success)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
