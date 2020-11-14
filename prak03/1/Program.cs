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
        string find_my_number = @"[+]{0,1}[7]{0,1}[8]{0,1}[(]{0,1}\d{3}[)]{0,1}[-]{0,1}\d{3}[-]{0,1}\d{2}[-]{0,1}\d{2}";// регулятор моего телефона
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
          if (Regex.IsMatch(item, pattern))
          {
            Console.WriteLine(item + " это телефон");
          }
          else
          {
            Console.WriteLine(
            string.Format("{0} это НЕ телефон", item)
            );
          }

        }

      }
    }
  }
}