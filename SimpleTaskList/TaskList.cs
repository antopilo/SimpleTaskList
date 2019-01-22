using System;
using System.Collections.Generic;


namespace SimpleTaskList
{
    public class TaskList
    {
        public string Name;
        public List<TaskItem> Tasks;

        public TaskList()
        {
            Name = "";
            Tasks = new List<TaskItem>();
        }
        public TaskList(string pName)
        {
            Name = pName;
            Tasks = new List<TaskItem>();
        }

        public void AddItem(TaskItem pItem)
        {
            if (pItem is null) return;
            Tasks.Add(pItem);
        }
    }
}
