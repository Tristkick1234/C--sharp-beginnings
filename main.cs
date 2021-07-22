using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      /* switch for many*/
      Console.WriteLine("Choose a number greater 20 " );

      int num = Convert.ToInt32(Console.ReadLine());

      if (num > 20)
      {
        Console.WriteLine($"Yes, {num} is greater than 20");
      }
      else if (num == 20)
      {
        Console.WriteLine($"{num} is not greater, try again");
      }
      else
      {
        Console.WriteLine($"Incorrect, {num} is definetly not greater, try again");
      }

      //ALternatively

      string result = (num > 20) ? "Right" : "Wrong";
      Console.WriteLine(result);

      //Switch//

      Console.WriteLine("What Chess move will you make from 1 to 5");

      int chessMove = Convert.ToInt32(Console.ReadLine());

      switch(chessMove)
      {
        case 1:
          Console.WriteLine("YOu chose c1");
          break;
        
        case 2:
          Console.WriteLine("YOu chose b3");
          break;

        case 3:
          Console.WriteLine("YOu chose b4");
          break;

        case 4:
          Console.WriteLine("YOu chose a8");
          break;
        case 5:
          Console.WriteLine("YOu chose e3");
          break;
        default:
          Console.WriteLine("Is not an available option but ok boomer.");
          break;

      }
    }
  }
}