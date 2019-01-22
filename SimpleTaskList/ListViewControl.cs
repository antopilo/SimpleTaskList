using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTaskList
{
    public partial class ListViewControl : UserControl
    {
        public CheckedListBox ListBox;
        public TaskList TaskList;

        public ListViewControl(TaskList pList)
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            ListBox = taskList;
            TaskList = pList;

            int idx = 0;
            foreach (var item in TaskList.Tasks)
            {
                bool isChecked = item.Checked;
                ListBox.Items.Add(item.TaskName);
                ListBox.SetItemChecked(idx, isChecked);
                idx++;
            }
        }


    }
}
