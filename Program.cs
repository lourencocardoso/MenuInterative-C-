using System;

namespace Menu
{
  class Program
  {
      static void Main(string[] args){
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Seja Bem-vindo ao AppLotes");
        Console.ResetColor();

        Console.WriteLine("usa as setas do teclado ⬆ ⬇ para Navegar no Menu");

        ConsoleKeyInfo key;
        int option = 1;
        bool select = false;
        (int left, int top) = Console.GetCursorPosition();
         string color = "✅ \u001b[32m";
       
       while(!select)
       {
        Console.SetCursorPosition(left, top);
        
        Console.WriteLine($"{(option == 1 ? color : " ")}Option  ler\u001b[0m");
        Console.WriteLine($"{(option == 2 ? color : " ")}Option  esc\u001b[0m");
        Console.WriteLine($"{(option == 3 ? color : " ")}Option  as\u001b[0m");

        key = Console.ReadKey(true);

        switch(key.Key)
        {
          case ConsoleKey.DownArrow:
          option = (option == 3 ? 1 : option + 1);
          break;

          case ConsoleKey.UpArrow:
          option = (option == 1 ? 3 : option - 1);
          break;

          case ConsoleKey.Enter:
          select = true;
          break;
        }
       }
      switch(option){
        case 1: 
        Console.WriteLine("Deseja programar em c#");
        break;
        case 2: 
        Console.WriteLine("Mostra os dados de hoje");
        break;
        case 3: 
        Console.WriteLine("Comandos em c#");
        break;
      }
      
      }
  }
}
