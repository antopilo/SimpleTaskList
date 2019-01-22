using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskList
{
    public class TaskItem
    {
        public bool Checked = false;
        public string TaskName;

        public TaskItem()
        {
            TaskName = "";
        }
        public TaskItem(string pName)
        {
            TaskName = pName;
            Checked = false;
        }

    }
}
