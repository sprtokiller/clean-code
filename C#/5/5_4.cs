void NavigateMaze(Cell[,,] maze)
{
    int lengthX = maze.GetLength(0);
    int lengthY = maze.GetLength(1);
    int lengthZ = maze.GetLength(2);

    for (int x = 0; x < lengthX; x++)
    {
        for (int y = 0; y < lengthY; y++)
        {
            for (int z = 0; z < lengthZ; z++)
            {
                Cell cell = maze[x, y, z];

                if (cell.IsWall)
                {
                    Console.WriteLine($"Encountered wall at ({x}, {y}, {z}).");
                    continue;
                }

                if (cell.IsExit)
                {
                    Console.WriteLine($"Exit found at ({x}, {y}, {z}).");
                    return;
                }

                Console.WriteLine($"Moving through ({x}, {y}, {z}).");
            }
        }
    }

    Console.WriteLine("No exit found in the maze.");
}
