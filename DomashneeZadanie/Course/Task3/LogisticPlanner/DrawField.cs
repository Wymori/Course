using System.Linq;

namespace DomashneeZadanie.Course.Task3.LogisticPlanner;
internal class DrawField
{
    public DrawField()
    {
        Map();
    }

    string[,] map = new string[50, 50];
    string[] index = ["0","1","2","3","4","5","6","7","8","9"];
 
    public string[,] Map() 
    {       
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                map[i, j] = " ";
            }
        }
        return map;        
    }

    public void Distance()
    {
        for (int i = 0; i < NodeCreate.maxNodeName; i++)
        { 
            for (int j = NodeCreate.maxNodeName;  j > i; j--)
            {                                       
                 int X1 = NodeCreate.nodeList[i].x;
                 int X2 = NodeCreate.nodeList[j].x;
                 int Y1 = NodeCreate.nodeList[i].y;
                 int Y2 = NodeCreate.nodeList[j].y;
                 DrawMap(X1, Y1, X2, Y2, map);                   
            }                     
        }
    }

    static void DrawMap(int x1, int y1, int x2, int y2, string[,]map)
    {
        int deltaX = Math.Abs(x2 - x1);
        int deltaY = Math.Abs(y2 - y1);
        int stepX = x1 < x2 ? 1 : -1;
        int stepY = y1 < y2 ? 1 : -1;
        int error = deltaX - deltaY;

        while (x1 != x2 || y1 != y2)
        {
            map[x1, y1] = ".";
            int error2 = 2 * error;

            if (error2 > -deltaY)
            {
                error -= deltaY;
                x1 += stepX;
            }

            if (error2 < deltaX)
            {
                error += deltaX;
                y1 += stepY;
            }
        }
        for (int i = 0; i <= NodeCreate.maxNodeName; i++)
        {
            map[NodeCreate.nodeList[i].x, NodeCreate.nodeList[i].y] = NodeCreate.nodeList[i].nodename.ToString();
        }
        for (int y = 0; y <= NodeCreate.maxNodeName; y++)
        {
            for (int i = -2; i < 2; i += 4)
            {
                for (int j = 0; j < 5; j++)
                {
                    map[NodeCreate.nodeList[y].x - i, NodeCreate.nodeList[y].y - i - j] = "#";
                    map[NodeCreate.nodeList[y].x + i, NodeCreate.nodeList[y].y + i + j] = "#";
                    map[NodeCreate.nodeList[y].x + i + j, NodeCreate.nodeList[y].y + i] = "#";
                    map[NodeCreate.nodeList[y].x - i - j, NodeCreate.nodeList[y].y - i] = "#";
                }
            }
        }
    }
   
    public void MapOutput()
    {
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                if (map[i, j] == "#") 
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(map[i, j]);
                }
                if (map[i, j] == ".")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(map[i, j]);
                }
                if (int.TryParse(map[i, j], out int result))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(map[i, j]);
                }
                if (map[i, j] == " ")
                {
                    Console.Write(map[i, j]);
                }
            }
            Console.WriteLine();
        }
    }

}
