using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the simple calculator. Would you like to add, multiply, subtract, divide, or exit? ");

      string response = Console.ReadLine();
      //if exit then break loop

   
      
      while (true)
      {
        if (response == "add")
        {
          Console.WriteLine("Choose two numbers");

          int x = Convert.ToInt32(Console.ReadLine());
          int y = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine(x + y);
          string jac = Console.ReadLine();

          if (x == 0 && y == 0);
          {
            Console.WriteLine("Continue or Exit ");
            string decide = Console.ReadLine();
            if (decide == "continue")
            {
              continue;
            }
            else
            {
              break;
            }
          } 
        }
        else if (response == "subtract" || jac == "subtract")
        {
          Console.WriteLine("Choose two numbers");

          int x = Convert.ToInt32(Console.ReadLine());
          int y = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine(x - y);

          if (x == 0 & y == 0);
          {
            Console.WriteLine("Continue or Exit ");
            string decide = Console.ReadLine();
            if (decide == "continue")
            {
              continue;
            }
            else
            {
              break;
            }
          } 
        }
        else if (response == "multiply")
        {
          Console.WriteLine("Choose two numbers");

          int x = Convert.ToInt32(Console.ReadLine());
          int y = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine(x * y);

          if (x == 0 & y == 0);
          {
            Console.WriteLine("Continue or Exit ");
            string decide = Console.ReadLine();
            if (decide == "continue")
            {
              continue;
            }
            else
            {
              break;
            }
          } 
        }
        else if (response == "divide")
        {
          Console.WriteLine("Choose two numbers");

          double x = Convert.ToDouble(Console.ReadLine());
          double y = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine(x / y);

          if (x == 0 & y == 0);
          {
            Console.WriteLine("Continue or Exit ");
            string decide = Console.ReadLine();
            if (decide == "continue")
            {
              continue;
            }
            else
            {
              break;
            }
          } 
        }

        else if (response == "exit")
        {
          break;
        }

        else
        {
          break;
        }

      }
      Console.WriteLine("Calculator closed.");
    }
  }
}