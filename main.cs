using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      /* Casting going to big to small data type or small to big */
      //User  input
      Console.WriteLine("Age? ");
      int age = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("So you are " + age + "?");
      
      string result =
      (age < 18) ? "You're a minor": "You're an adult";
      Console.WriteLine(result);

    }
  }
}