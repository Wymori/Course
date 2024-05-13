namespace DomashneeZadanie.Course.Task3.LogisticPlanner;

internal class Node
{
    public Node(int X, int Y, int Nodename) 
    {
        x = X;
        y = Y;
        nodename = Nodename;

    }
    public int x { get; set; }
    public int y { get; set; }
    public int nodename { get; set; }
}
