namespace Program
{
  class TicTacToe
  {
    public static void Main(string[] agrs)
    {
      int PlayerPickNow = -1;
      char[] slots = {'?','?','?','?','?','?','?','?','?'};
      Console.WriteLine("tic tac toe");
        // !
        // ?
        // ToDO
        // *
      
    
      
      
      //!while ()
      PlayerPickNow = Convert.ToInt32(Console.ReadLine());
      PlayerChose(PlayerPickNow, slots);
      //?Console.Clear();
      Console.WriteLine(WinCondithion(slots, null));
      
    }
      
    public static void printTable( char[] array)

    {
        Console.WriteLine($"⁰{array[0]} | ¹{array[1]} | ²{array[2]}");
        Console.WriteLine("————————————");
        Console.WriteLine($"³{array[3]} | ⁴{array[4]} | ⁵{array[5]}");
        Console.WriteLine("————————————");
        Console.WriteLine($"⁶{array[6]} | ⁷{array[7]} | ⁸{array[8]}");
    }

    public static void PlayerChose(int x, char[] arrayslots)
    {
      arrayslots[x] = 'X';
    }
    public static void MachineChose(int x, char[]arrayslots)
    {
      arrayslots[x] = 'O';
    }
    public static bool WinCondithion(char[] arrays, char? fo)
    {
      /*if (arrays )
      {
        fo = 'X';
        return true;
      }
      else if ( )
      {
        fo = 'O';
        return true;
      }
      else
      {

        return false;
      }*/
      fo = 'b';
      return true;
      

    }
  
  
  }
}




