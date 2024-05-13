namespace DomashneeZadanie.Course.Task3.LogisticPlanner;

internal class UserIO
{
    private int _vectorX;
    private int _vectorY;
    private double _distance;
    private int _userCoordX = -1;
    private int _userCoordY = -1;
    public static int codeCoordX;
    public static int codeCoordY;

    public (int, int) Input()
    {
        while (NodeCreate.nodeName < NodeCreate.maxNodeName) 
        {
            bool nodeRule = false;
            Console.WriteLine("Введите X Y: ");
            string[] input = Console.ReadLine()
                .Split(' ');
            if (input.Length == 2 && int.TryParse(input[0], out _userCoordX) && int.TryParse(input[1], out _userCoordY))
            {
                codeCoordX = _userCoordX--;
                codeCoordY = _userCoordY--;
                for (int i = 0; i < NodeCreate.nodeName + 1; i++)
                {
                    _vectorX = Math.Abs(NodeCreate.nodeList[i].x - _userCoordX);
                    _vectorY = Math.Abs(NodeCreate.nodeList[i].y - _userCoordY);
                    _distance = Math.Sqrt(Math.Pow(_vectorX, 2) + Math.Pow(_vectorY, 2));
                    if (_distance > 5 && _distance < 11 && _userCoordX > 4 && _userCoordX < 45 && _userCoordY > 4 && _userCoordY < 45)
                        nodeRule = true;                  
                }
                if (nodeRule) { return (codeCoordX, codeCoordY); }
            }
        }
        return (_userCoordX, _userCoordY);
    }
}