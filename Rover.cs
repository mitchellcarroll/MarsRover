using System;

namespace MarsRover
{
  public class Rover
  {
    // current X coordinate of the Rover
    public int X { get; set; }

    // current Y coordinate of Rover
    public int Y { get; set; }

    // Current direction the Rover is facing
    public Direction D { get; set; }

    // NASA remotely controls rovers via instructions consisting of strings of letters. 
    // Possible instruction letters are L, R, and M. 
    // L and R instruct the rover to turn 90 degrees left or right, respectively (without moving from its current spot), 
    // while M instructs the rover to move forward one grid point along its current heading.
    public void Move(char move, Plateau p)
    {
      switch (move)
      {
        case 'L':
          if (D == Direction.N)
          {
            D = Direction.W;
          }
          else if (D == Direction.S)
          {
            D = Direction.E;
          }
          else if (D == Direction.E)
          {
            D = Direction.N;
          }
          else if (D == Direction.W)
          {
            D = Direction.S;
          }
          break;

        case 'R':
          if (D == Direction.N)
          {
            D = Direction.E;
          }
          else if (D == Direction.S)
          {
            D = Direction.W;
          }
          else if (D == Direction.E)
          {
            D = Direction.S;
          }
          else if (D == Direction.W)
          {
            D = Direction.N;
          }
          break;

        case 'M':

          if (D == Direction.N)
          {
            if (Y == p.maxY)
            {
              throw new CantMoveException("Can't move anymore");
            }
            Y++;
          }

          else if (D == Direction.S)
          {
            if (Y == p.minY)
            {
              throw new CantMoveException("Can't move anymore");
            }
            Y--;
          }

          else if (D == Direction.E)
          {
            if (X == p.maxX)
            {
              throw new CantMoveException("Can't move anymore");
            }
            X++;
          }

          else if (D == Direction.W)
          {
            if (X == p.minX)
            {
              throw new CantMoveException("Can't move anymore");
            }
            X--;
          }

          break;


        default:
          break;
      }
    }

    // Output current positioning of the Rover. X Y cordinates and "Z" => direction
    public void ShowStatus()
    {
      Console.WriteLine($"{X} {Y} {D}");
    }
  }
}