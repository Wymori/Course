using System;

namespace DomashneeZadanie.Course.Task3.LogisticPlanner;

internal class NodeCreate
{
    public NodeCreate()
    {
        maxNodeName = 3;
    }

    public static int nodeName = 0;
    public static int maxNodeName;
    public static List<Node> nodeList = new List<Node>() {new Node(24, 24, 0) };

    public void CreateNode(int X, int Y)
    {
        nodeName++;
        nodeList.Add(new Node(X, Y, nodeName));
    }
}