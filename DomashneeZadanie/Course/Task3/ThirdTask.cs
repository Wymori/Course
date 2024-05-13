using DomashneeZadanie.Course.Task3.LogisticPlanner;

namespace DomashneeZadanie.Course.Task3;

internal class ThirdTask : CoursesTask
{
    public override Task Invoke()
    {
        NodeCreate nodeCreate = new NodeCreate();   
        UserIO nodeInput = new UserIO();
        DrawField drawField = new DrawField();

        while (NodeCreate.nodeName < NodeCreate.maxNodeName) 
        { 
            nodeInput.Input();
            nodeCreate.CreateNode(UserIO.codeCoordX, UserIO.codeCoordY);
        }
        drawField.Distance();
        drawField.MapOutput();

        return Task.CompletedTask;
    }
}
