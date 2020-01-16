using System;
using System.Linq;

namespace MarsRover
{
  class Program
  {
    static void Main(string[] args)
    {
      Plateau p = getPlateau();
      Rover rover1 = getRover();
      getInstructions(p, rover1);
      Rover rover2 = getRover();
      getInstructions(p, rover2);
      rover1.ShowStatus();
      rover2.ShowStatus();
      Console.ReadKey();
    }

    // Get maxX & maxY from user input
    // create new plateau grid
    private static Plateau getPlateau()
    {
      Plateau p;
      bool result = false;
      int X = 0, Y = 0;
      string input = string.Empty;
      string[] splitted;
      while (result == false)
      {
        Console.WriteLine("Enter the cordinates for the northeastern corner of plateau:");
        input = Console.ReadLine();
        splitted = input.Split(' ', ',');
        result = int.TryParse(splitted[0], out X);
        result = int.TryParse(splitted[1], out Y);
      }

      p = new Plateau()
      {
        minX = 0,
        minY = 0,
        maxX = X,
        maxY = Y
      };
      return p;
    }

    // Get rover’s current position and heading are represented by a triple X Y Z 
    // consisting of its current grid position X Y plus a letter Z corresponding to one of the four cardinal compass points, N E S W.
    // 1. Get rover's current position (X Y Z).
    // 2. Create new Rover instance. 
    private static Rover getRover()
    {
      bool result = false;
      int X = 0, Y = 0;
      Rover rover = null;
      while (result == false)
      {
        Console.WriteLine("Enter the rover's current position & direction the Rover is facing:");
        string input = Console.ReadLine();
        string[] splitted = input.Split(' ', ',');
        result = int.TryParse(splitted[0], out X);
        result = int.TryParse(splitted[1], out Y);
        char directionChar = splitted[2].ToUpper().FirstOrDefault();
        rover = new Rover
        {
          X = X,
          Y = Y
        };

        if (directionChar == 'N')
        {
          rover.D = Direction.N;
        }
        else if (directionChar == 'W')
        {
          rover.D = Direction.W;
        }
        else if (directionChar == 'E')
        {
          rover.D = Direction.E;
        }
        else if (directionChar == 'S')
        {
          rover.D = Direction.S;
        }
        else
        {
          result = false;
        }
      }

      return rover;
    }

    // Gets User input to simulate NASA's instructions for the Rover's movement.
    private static void getInstructions(Plateau p, Rover rover)
    {
      Console.WriteLine("Enter NASA's turn / move instructions:");
      string instruction = Console.ReadLine();

      foreach (var c in instruction)
      {
        rover.Move(c, p);
      }
    }
  }
}
