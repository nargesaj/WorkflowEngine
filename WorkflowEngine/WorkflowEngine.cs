namespace WorkflowEngine
{
    public class WorkflowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach (var activity in workFlow.GetActivities())
                activity.Execute();
        }
    }
}
