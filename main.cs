using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
     /*methods can call also known as functions */

     for (int i = 0; i < 5; i++)
     {
       MyMethod(3, 2);
     };

     MethodTwo(a:1, b:2, c:3);
     



    }

    static void MethodTwo(int a, int b, int c)
    {
      Console.WriteLine("It is " + c);
    }

    static void MyMethod(int x, int y)
    {
      
      Console.WriteLine(x + y);
    }
  }
}