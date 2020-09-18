using System;
using System.Text.RegularExpressions;
namespace prak3
{
  class Program
  {
    public class Find_Phone
    {
      public static void Main()
      {
        string pattern = @"[+]{0,1}[7]{0,1}[8]{0,1}[(]{0,1}\d{3}[)]{0,1}[-]{0,1}\d{3}[-]{0,1}\d{2}[-]{0,1}\d{2}";
        string input = @"
        +79511357545
        +7(951)1357545
        +7(951)-135-75-45
        (951)1357545
        (951)-135-75-45
        89511357545
        8(951)1357545
        8(951)-135-75-45";
        RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input, pattern, options))
        {
          Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
      }
    }
    static void Main(string[] args)
    {
      
    }
  }
}
