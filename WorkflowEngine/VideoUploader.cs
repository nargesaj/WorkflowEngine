using System;

namespace WorkflowEngine
{
    public class VideoUploader : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video...");
        }
    }
}
