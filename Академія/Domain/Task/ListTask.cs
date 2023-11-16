using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Академія.Domain.Task
{
    public class ListTask : INotifyPropertyChanged
    {
        public List<MyTask>? tasks = null;

        public ListTask() 
        {
            tasks = new List<MyTask>();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void AddTask(MyTask task) { tasks?.Add(task); }
        
        public void DeleteTask(MyTask task) { tasks?.Remove(task); }

        public List<MyTask> GetTasks() {  return tasks; }

        protected void OnPropertyChanged(string propetyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propetyName));
        }

        internal void AddTask(System.Threading.Tasks.Task task)
        {
            throw new NotImplementedException();
        }
    }
}
