namespace DomashneeZadanie.Course.Task_2.Sea_war;

internal class Field
{
    public Field()
    {
        Clear();
    }

    private int X;
    private int Y;
    private int Rotate;
    private int[,] _battleField = new int[10, 10];
    private List<int> Sizes = [4, 3, 3, 2, 2, 2, 1, 1, 1, 1];

    private void Clear()
    {
        for (int i = 0; i < _battleField.GetLength(0); i++)
        {
            for (int j = 0; j < _battleField.GetLength(1); j++)
            {
                _battleField[i, j] = 0;
            }
        }
    }

    public void Update()
    {
        int size = Sizes[0];

        for (int i = 0; i < size; i++)
        {
            if (Rotate == 0)
            {
                _battleField[X - i, Y] = 1;
            }
            if (Rotate == 1)
            {
                _battleField[X, Y - i] = 1;
            }
        }
        Sizes.RemoveAt(0);
    }

    public void OutPut()
    {
        for (int y = 0; y < _battleField.GetLength(0); y++)
        {
            for (int x = 0; x < _battleField.GetLength(1); x++)
            {
                if (_battleField[x, y] != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(_battleField[x, y] + " ");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(_battleField[x, y] + " ");
                }
            }
            Console.WriteLine();
        }
    }

    public void Control_Input()
    {
        while (true)
        {
            Console.Write("Введите место расположение корабля X Y Rotate: ");
            string[] input = Console.ReadLine()
                .Split(' ');
            if (input.Length == 3 && int.TryParse(input[0], out X) && int.TryParse(input[1], out Y) &&
                int.TryParse(input[2], out Rotate))
            {
                X--;
                Y--;
                if (X >= 0 && X < 10 &&
                    Y >= 0 && Y < 10 &&
                    (Rotate == 0 || Rotate == 1))
                    if (Rotate == 0 && X + 1 - Sizes[0] >= 0 && RadiusOk(Rotate))
                            break;
                if (Rotate == 1 && Y + 1 - Sizes[0] >= 0 && RadiusOk(Rotate))
                        break;
            }
            Console.WriteLine("n/a");
        }
    }

    private bool RadiusOk(int rotate)
    {
        bool flag = true;
        int maxLen = (Sizes[0] + 2);
        if (rotate == 0)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < maxLen; j++)
                {
                    if ((Y - 1 + i < 0 || Y - 1 + i > 9) || (X + 1 - j > 9 || X + 1 - j < 0))
                        continue;
                    if (_battleField[X + 1 - j, Y - 1 + i] == 1)
                    {
                        flag = false;
                        break;
                    }
                }
            }
        }
        if (rotate == 1)
        {
            for (int i = 0; i < maxLen; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((Y + 1 - i < 0 || Y + 1 - i > 9) || (X - 1 + j > 9 || X - 1 + j < 0))
                        continue;
                    if (_battleField[X - 1 + j, Y + 1 - i] == 1)
                    {
                        flag = false;
                        break;
                    }
                }
            }
        }
        return flag;
    }
}
