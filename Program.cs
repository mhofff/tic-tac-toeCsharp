using System;
using System.Runtime.InteropServices;
namespace Program
{
  class TicTacToe
  {
    public static void Main(string[] agrs)
    {
      int[] slots = {0,0,0,0,0,0,0,0,0};
      Console.WriteLine("tic tac toe");
      
      int pickNow = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(pickNow);
      printTable(slots);
      if (pickNow == slots[0] || pickNow == slots[2] || pickNow == slots[6] || pickNow == slots[8] )
      {
        
      }



    }
    public static void printTable(int[] array)
    {
      if ()
      Console.WriteLine($"¹? | ²? | ³?");
      Console.WriteLine("————————————");
      Console.WriteLine($"⁴? | ⁵? | ⁶?");
      Console.WriteLine("————————————");
      Console.WriteLine($"⁷? | ⁸? | ⁹?");
    }
  }
}
