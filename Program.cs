using System;

namespace AulasDescomplica
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      for (int i = 0; i < 5; i++)
      {
        int nota1 = int.Parse(Console.ReadLine());
        int nota2 = int.Parse(Console.ReadLine());

        float media = (nota1 + 2 * nota2) / 3;

        if (media>=6)
        {
          Console.WriteLine("Passou");
        }
        else
        {
          Console.WriteLine("não passou");
        }
      }
 
    }
  }
}