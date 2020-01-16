using System;

namespace MarsRover
{
  public class CantMoveException : Exception
  {
    public CantMoveException() : base()
    {

    }
    public CantMoveException(string message) : base(message)
    {

    }
    public CantMoveException(string message, Exception innerException) : base(message, innerException)
    {

    }
  }
}