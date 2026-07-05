namespace Program
{
  class TicTacToe
  {
    public static void Main(string[] agrs)
    {
      char[] slots = {'?','?','?','?','?','?','?','?','?'};
      Console.WriteLine("tic tac toe");
      printTable(slots);
      int pickNow =  -1;
      //while (slots.Any(d => d == '?'))
      //{
        pickNow = Convert.ToInt32(Console.ReadLine());
        //PlayerChose(pickNow);
        //slots[pickNow] = 'X';
        PlayerChose(pickNow, slots);
        //printTable(slots);
        if (pickNow == 0 || pickNow == 2 || pickNow == 6 || pickNow == 8)
        {
          MachineChose(4,slots);
          printTable(slots);

          if (pickNow == 0)
          {

            pickNow = Convert.ToInt32(Console.ReadLine());
            PlayerChose(pickNow, slots);


          if (pickNow == 6)
          {

            MachineChose(3,slots);
            printTable(slots);

          }
          else
          {

            MachineChose(1,slots);
            printTable(slots);

          }
          

          }
          
          
        }
        else if (pickNow == 1 || pickNow == 3 || pickNow == 5 || pickNow == 7)
        {

          MachineChose(4,slots);
          printTable(slots);
          pickNow = Convert.ToInt32(Console.ReadLine());

        }
        else
        {

          MachineChose(6,slots);
          printTable(slots);
          pickNow = Convert.ToInt32(Console.ReadLine());

        }
        
      //}
      
      //Console.WriteLine(pickNow);
      //slots[0] = 1;
      //if (pickNow == slots[0] || pickNow == slots[2] || pickNow == slots[6] || pickNow == slots[8] )
      //while (slots.Any(d => d == 0))
      /*{
        pickNow = Convert.ToInt32(Console.ReadLine());

      }*/


    }
    public static void printTable( char[] array)

    {
      if (array.All(x => x == '?'))//masive only use zero
      {
        Console.WriteLine("⁰? | ¹? | ²?");
        Console.WriteLine("————————————");
        Console.WriteLine("³? | ⁴? | ⁵?");
        Console.WriteLine("————————————");
        Console.WriteLine("⁶? | ⁷? | ⁸?");
      }
      else if (array.Any(c => c != '?'))
      {
        Console.WriteLine($"⁰{array[0]} | ¹{array[1]} | ²{array[2]}");
        Console.WriteLine("————————————");
        Console.WriteLine($"³{array[3]} | ⁴{array[4]} | ⁵{array[5]}");
        Console.WriteLine("————————————");
        Console.WriteLine($"⁶{array[6]} | ⁷{array[7]} | ⁸{array[8]}");
      }
    }

    public static void PlayerChose(int x, char[] arrayslots)
    {
      arrayslots[x] = 'X';
    }
    public static void MachineChose(int x, char[]arrayslots)
    {
      arrayslots[x] = 'O';
    }
    
  }

}
