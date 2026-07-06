using System.Reflection.PortableExecutable;

namespace Program
{
  class TicTacToe
  {
    public static void Main(string[] agrs)
    {
      char[] slots = {'?','?','?','?','?','?','?','?','?'};
      Console.WriteLine("tic tac toe");
      printTable(slots);
      int PlayerPickNow = -1;
      //while (slots.Any(d => d == '?'))
      //{
        // !
        // ?
        // ToDO
        // *
        //better comments
        // PlayerChose(pickNow);  
        //slots[pickNow] = 'X';
        //first iteration
      PlayerPickNow = Convert.ToInt32(Console.ReadLine());
      PlayerChose(PlayerPickNow, slots);
      if(slots[4] == '?')
      {
        MachineChose(4,slots);
        PlayerPickNow = Convert.ToInt32(Console.ReadLine());
        PlayerChose(PlayerPickNow, slots);

        

      }
      else
      {
        MachineChose(0,slots);
      }
      







      /*if (PlayerPickNow == 0 || PlayerPickNow == 2 || PlayerPickNow == 6 || PlayerPickNow == 8)
      {
        MachineChose(4,slots);
        printTable(slots);
        PlayerPickNow = Convert.ToInt32(Console.ReadLine());
        PlayerChose(PlayerPickNow, slots);
        if (slots[0] == 'X' && slots[6] == 'X')
        {
          MachineChose(3,slots);
          printTable(slots);
          PlayerPickNow = Convert.ToInt32(Console.ReadLine());
          PlayerChose(PlayerPickNow, slots);
          if (PlayerPickNow == 2)
          {
            MachineChose(1,slots);
            printTable(slots);
          }
          
        }


      
        
      }
      else if (PlayerPickNow == 1 || PlayerPickNow == 3 || PlayerPickNow == 5 || PlayerPickNow == 7)
      {
        MachineChose(4, slots);
        printTable(slots);
      }
      else
      {
        MachineChose(0,slots);
        printTable(slots);
      }
      //pickNow = Convert.ToInt32(Console.ReadLine());
      //PlayerChose(pickNow, slots);
      //if (slots[4] == 'O' || slots[0] == 'X' || )



      /*if (slots[0] == '?')
      {
        
      }
      else if (slots[2] == '?')
      {
        
      }
      else if (slots[6] == '?')
      {
        
      }
      else if (slots[8] == '?')
      {
        
      }

        //printTable(slots);
        /*if (pickNow == 0 || pickNow == 2 || pickNow == 6 || pickNow == 8)
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
