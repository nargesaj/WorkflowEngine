using System.Collections.Generic;

namespace WorkflowEngine
{
    public class WorkFlow : IWorkFlow
    {
        private readonly IList<IActivity> _activities;

        public WorkFlow()
        {
            _activities = new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _activities.Remove(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}
