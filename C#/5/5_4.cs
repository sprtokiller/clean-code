void NavigateMaze(Cell[,,] maze)
{
    //Set Coordinates
    for (int coordinateX = 0; coordinateX < maze.GetLength(0); coordinateX++)
    {
        for (int coordinateY = 0; coordinateY < maze.GetLength(1); coordinateY++)
        {
            for (int coordinateZ = 0; coordinateZ < maze.GetLength(2); coordinateZ++)
            {
                //Run the maze
                Cell cell = maze[coordinateX, coordinateY, coordinateZ];
                if (cell.IsWall)
                {
                    Console.WriteLine("Encountered wall at (" + coordinateX + ", " + coordinateY + ", " + coordinateZ + ").");
                }
                else if (cell.IsExit)
                {
                    Console.WriteLine("Exit found at (" + coordinateX + ", " + coordinateY + ", " + coordinateZ + ").");
                    return;
                }
                else
                {
                    Console.WriteLine("Moving through (" + coordinateX + ", " + coordinateY + ", " + coordinateZ + ").");
                }
            }
        }
    }
    Console.WriteLine("No exit found in the maze.");
}
