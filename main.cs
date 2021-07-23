using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      //loops
      int i = 0;
      while (i < 9)
      {
        Console.WriteLine(i);
        i++;
      }
      int b = 0;
      do
      {
        Console.WriteLine(b);
        b++;
      }
      while(b < 9);

      //for loops
      for(int g = 0; g < 10; g++)
      {
        Console.WriteLine($"This is a {g}");
      }

      string[] progrmLang = {"C#","JavaScript", "C++", "Python"};
      foreach(string x in progrmLang)
      {
        Console.WriteLine(x + " Is one of the languages.");
      }

      //Break and COntinue
    }
  }
}