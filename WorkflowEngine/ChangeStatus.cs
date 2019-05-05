using System;

namespace WorkflowEngine
{
    public class ChangeStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changing status...");
        }
    }
}
