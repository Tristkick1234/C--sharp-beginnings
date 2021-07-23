using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] money = {"Peso", "Kwanzaa", "Dinar"};
      Array.Sort(money);
      Console.WriteLine(money.Length);

      for (int i = 0; i < money.Length; i++)
      {
        Console.WriteLine(money[i]);
      }

      foreach (string i in money)
      {
        Console.WriteLine(i);
      }

      string[] dogs;

      dogs = new string[]  {" german", " doge"};

      foreach (string i in dogs)
      {
        Console.WriteLine(i);
      }
      
    }
  }
}