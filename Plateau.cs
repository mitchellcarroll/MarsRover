namespace MarsRover
{
  // A simple two-dimensional coordinate grid is mapped to the plateau to aid in rover navigation.
  // Input Instructions: 
  // 1. Assume the southwest corner of the grid is 0,0 (the origin) => minX & minY values
  // 2. The first line of input establishes the exploration grid bounds by indicating the coordinates corresponding to the northeast corner of the plateau. => maxX & minY values
  public class Plateau
  {
    public int minX { get; set; } = 0;
    public int minY { get; set; } = 0;
    public int maxX { get; set; }
    public int maxY { get; set; }
  }
}