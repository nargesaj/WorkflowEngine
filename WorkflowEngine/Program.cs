using System;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new WorkFlow();
            workflow.Add(new VideoUploader());
            workflow.Add(new CallWebService());
            workflow.Add(new SendEmail());
            workflow.Add(new ChangeStatus());

            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }
    }
}