# MarsRover

C# Console App using .NET Core 3.1

## Instructions

NASA intends to land robotic rovers on Mars to explore a particularly curious-looking plateau. The rovers must navigate this rectangular plateau in a way so that their on board cameras can get a complete image of the surrounding terrain to send back to Earth.

A simple two-dimensional coordinate grid is mapped to the plateau to aid in rover navigation. Each point on the grid is represented by a pair of numbers X Y which correspond to the number of points East or North, respectively, from the origin. The origin of the grid is represented by 0 0 which corresponds to the southwest corner of the plateau. 0 1 is the point directly north of 0 0, 1 1 is the point immediately east of 0 1, etc. A rover’s current position and heading are represented by a triple X Y Z consisting of its current grid position X Y plus a letter Z corresponding to one of the four cardinal compass points, N E S W. For example, 0 0 N indicates that the rover is in the very southwest corner of the plateau, facing north.

NASA remotely controls rovers via instructions consisting of strings of letters. Possible instruction letters are L, R, and M. L and R instruct the rover to turn 90 degrees left or right, respectively (without moving from its current spot), while M instructs the rover to move forward one grid point along its current heading.

Your task is write an application that takes the test input (instructions from NASA) and provides the expected output (the feedback from the rovers to NASA). Each rover will move in series, i.e. the next rover will not start moving until the one preceding it finishes.

## Input

Assume the southwest corner of the grid is 0,0 (the origin). The first line of input establishes the exploration grid bounds by indicating the coordinates corresponding to the northeast corner of the plateau.

Next, each rover is given its instructions in turn. Each rover’s instructions consists of two lines of strings. The first string confirms the rover’s current position and heading. The second string consists of turn / move instructions.

## Output

Once each rover has received and completely executed its given instructions, it transmits its updated position and heading to NASA.

### Test Input

5 5  
1 2 N  
LMLMLMLMM  
3 3 E  
MMRMMRMRRM  

### Expected Output

1 3 N  
5 1 E

### Room For Improvement

There are two main areas that I would like to improve on.

First, adding tests. I started out with the intention to add tests and then ran into an issue linking my project folder with my test folder. I used VS Code on a Mac and this is probably a simply fix but I felt like I was spending to much time reading unclear documentation on community extension that I decided to move on without them.

The second area that I would like to improve is error handling. I have very basic error handling with the CantMoveException but there are several unhandled exceptions that use the System error handling.

• i.e. `System.IndexOutOfRangeException: Index was outside the bounds of the array.`

Another needed exception is if a user tries to enter the `turn / move` commands that are not valid (L,R, M) then it ignores the command. A better way to handle this is to check the input and then re-prompt the user to try the input again.

Overall, I enjoyed the challenge and think that I can learn C# and improve my overall abilities as a programmer.
