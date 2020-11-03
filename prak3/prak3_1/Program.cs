
using System;
using System.Text.RegularExpressions;
namespace prak3_1
{
  class Program
  {
    static string ReformatPhone(string s)
    {
      Match m = Regex.Match(s, @" ^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$"); return String.Format("({0}) {1}-{2}", m.Groups[1], m.Groups[2], m.Groups[3]);
    }

    public static void Main()
      {
        string find_my_number = @"[+]{0,1}[7]{0,1}[8]{0,1}[(]{0,1}\d{3}[)]{0,1}[-]{0,1}\d{3}[-]{0,1}\d{2}[-]{0,1}\d{2}";// регулятор  телефона
        string[] text = {
        "+79511357545",
        "+7(951)1357545",
        "+7(951)-135-75-45",
        "(951)1357545",
        "(951)-135-75-45",
        "89511357545",
        "8(951)1357545",
        "8(951)-135-75-45",
        "ЫЫЫЫЫЫЫЫЫЫЫЫЫЫЫЫ"};
      foreach (string item in text)
      {
        string pattern = @"[+]{0,1}[7]{0,1}[8]{0,1}[(]{0,1}\d{3}[)]{0,1}";
        if (Regex.IsMatch(item, pattern)) Console.WriteLine(ReformatPhone(item) + " is a phone number");
        else Console.WriteLine(item + " is unknown");
      }


    }
  }
}