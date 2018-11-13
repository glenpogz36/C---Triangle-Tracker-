using System;
using System.Collections.Generic;

namespace TriangleTracker {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter side one of your triangle: ");
      string stringSideOne = Console.ReadLine();
      int sideOne = int.Parse(stringSideOne);

      Console.WriteLine("Enter side two of your triangle: ");
      string stringSideTwo = Console.ReadLine();
      int sideTwo = int.Parse(stringSideTwo);

      Console.WriteLine("Enter side three of your triangle: ");
      string stringSideThree = Console.ReadLine();
      int sideThree = int.Parse(stringSideThree);

      Console.WriteLine(Triangles.TriangleType(sideOne, sideTwo, sideThree));
      
       
      
    }
  }

}