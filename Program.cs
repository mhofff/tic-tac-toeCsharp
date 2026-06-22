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
      //slots[0] = 1;
      printTable(slots);
      if (pickNow == slots[0] || pickNow == slots[2] || pickNow == slots[6] || pickNow == slots[8] )
      {
        
      }



    }
    public static void printTable(int[] array)
    {
      if (array.All(x => x == 0))//masive only use zero
      {
        Console.WriteLine("¹? | ²? | ³?");
        Console.WriteLine("————————————");
        Console.WriteLine("⁴? | ⁵? | ⁶?");
        Console.WriteLine("————————————");
        Console.WriteLine("⁷? | ⁸? | ⁹?");
      }
      else if (array.Any(c => c != 0))
      {
        Console.WriteLine($"{array[0]} | ²{array[1]} | ³{array[2]}");
        Console.WriteLine("————————————");
        Console.WriteLine($"⁴{array[3]} | ⁵{array[4]} | ⁶{array[5]}");
        Console.WriteLine("————————————");
        Console.WriteLine($"⁷{array[6]} | ⁸{array[7]} | ⁹{array[8]}");
      }
      
    }
  }
}
