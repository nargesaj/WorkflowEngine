using System.Collections.Generic;

namespace WorkflowEngine
{
    public interface IWorkFlow
    {
        void Add(IActivity activity);
        void Remove(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }
}
