using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the simple calculator. Would you like to add, multiply, subtract, divide, exponent, or exit? ");

      string response = Convert.ToInt32(Console.ReadLine());
      //if exit then break loop

      int x;
      int y;
      int i = 0;
      while (i < 5)
      {
        if (response == "add")
        Console.WriteLine("Choose two numbers");

        int Adding = Console.Readline(x + y) ;
        i++;
      }
    }
  }
}