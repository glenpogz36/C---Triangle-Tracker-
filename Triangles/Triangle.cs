using System;

namespace TriangleTracker {

class Triangles
{
  private int SideOne;
  private int SideTwo;
  private int SideThree;
  

  public Triangles(int sideOne, int sideTwo, int sideThree) 

    {
    SideOne = sideOne;
    SideTwo = sideTwo;
    SideThree = sideThree;
    }

    public int GetSideOne()
    {
    return SideOne;
    }

    public int GetSideTwo()
    {
    return SideTwo;
    }

    public int GetSideThree()
    {
    return SideThree;
    }

    public static string TriangleType(int sideOne, int sideTwo, int sideThree)
    {
      if (sideOne == sideTwo && sideTwo == sideThree)
      {
          return ("Equilateral");
      }
      else if ((sideOne+sideTwo)<sideThree || (sideTwo+sideThree)<sideOne || (sideOne+sideThree)<sideTwo)
      {
          return ("Not a Triangle");
      }
      else if (sideOne == sideTwo || sideTwo == sideThree || sideOne == sideThree)
      {
          return ("Isosceles");
      }
      else 
      {
          return ("Scalene");
      }

    }

 }       
}