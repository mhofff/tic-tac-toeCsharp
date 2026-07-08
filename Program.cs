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
        // !
        // ?
        // ToDO
        // *
      PlayerPickNow = Convert.ToInt32(Console.ReadLine());
      PlayerChose(PlayerPickNow, slots);
      Console.Clear();
      while (slots.Any(x => x == '?'))
      {
        Console.WriteLine("");
      }
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
    public static void winGame()
    {
      Console.WriteLine();
      return;
    }
  
  
  }
}




