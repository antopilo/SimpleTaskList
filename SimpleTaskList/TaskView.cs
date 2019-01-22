using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using MaterialSkin;
using MaterialSkin.Controls;

/*
TODO: SystemTray
 */
namespace SimpleTaskList
{
    public partial class SimpleTaskList : MaterialForm
    {
        TaskList CurrentList;
        string SavePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + "newList.xml";

        public SimpleTaskList()
        {
            InitializeComponent();

            // Theme
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.DoubleBuffered = true;
            LoadFile(SavePath);
        }

        // add new task,
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (CurrentList == null) newList();
            var taskName = txtNewTask.Text;
            if (taskName == "")
                return;

            TaskItem newItem = new TaskItem(taskName);
            CurrentList.AddItem(newItem);

            bool isChecked = newItem.Checked;
            GetListControl().ListBox.Items.Add(newItem.TaskName);

        }

        // Load file.
        private void LoadFile(string pPath)
        {
            // Loading file.
            if(!Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + "newList.xml"))
            {
                newList();
            }
                
            CurrentList = Helper.Serialization.Deserialize<TaskList>(pPath);

            // Adding tab.
            string Name = pPath.Split('\\')[pPath.Split('\\').Length - 1].Split('.')[0];
            TabPage newTab = new TabPage(Name);
            newTab.Controls.Add(new ListViewControl(CurrentList) {
                Dock = DockStyle.Fill
            });

            TabControler.TabPages.Add(newTab);
            TabControler.SelectedTab = newTab;

            int idx = 0;
            foreach (TaskItem item in CurrentList.Tasks)
            {
                bool isChecked = item.Checked;
                GetListControl().ListBox.Items.Add(item.TaskName);
                GetListControl().ListBox.SetItemChecked(idx, isChecked);
            }
        }

        private void SaveAs()
        {
            // Open dialog

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
                saveFileDialog.Filter = "XML files(*.xml) | *.xml";
                saveFileDialog.FilterIndex = 0;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = saveFileDialog.FileName;
                }
                else return;
            }

            XmlSerializer x = new XmlSerializer(CurrentList.GetType());
            using (var sw = new StreamWriter(filePath))
            {
                x.Serialize(sw, CurrentList);
            }
        }
        private void SaveAll()
        {
            if (TabControler.SelectedTab == null) return;

            foreach (var controls in TabControler.SelectedTab.Controls)
            {
                if (controls is ListViewControl)
                {
                    XmlSerializer x = new XmlSerializer(CurrentList.GetType());
                    using (var sw = new StreamWriter(SavePath))
                    {
                        x.Serialize(sw, (controls as ListViewControl).TaskList);
                    }
                }
                    ;
            }
        }

        // Saving
        private void Save()
        {
            XmlSerializer x = new XmlSerializer(CurrentList.GetType());
            using (var sw = new StreamWriter(SavePath))
            {
                x.Serialize(sw, CurrentList);
            }
        }


        private void SimpleTaskList_FormClosing(Object sender, FormClosingEventArgs e)
        {
            SaveAll();
        }


        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (GetListControl().ListBox.SelectedItem == null)
                return;

            GetListControl().ListBox.Items.Remove(GetListControl().ListBox.SelectedItem);
        }


        /// <summary>
        /// Search for the ListViewControl inside a the current tab.
        /// </summary>
        /// <returns></returns>
        private ListViewControl GetListControl()
        {
            foreach (var controls in TabControler.SelectedTab.Controls)
            {
                if (controls is ListViewControl)
                    return controls as ListViewControl;
            }
            throw new Exception("The control doesnt have a ListViewControl.");
        }


        private void taskList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bool isChecked = e.NewValue == CheckState.Checked ? true : false;
            CurrentList.Tasks[e.Index].Checked = isChecked;
        }


        private void btnOpenList_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
                openFileDialog.Filter = "XML files(*.xml) | *.xml";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    LoadFile(filePath);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();
            TabControler.TabPages.Remove(TabControler.SelectedTab);
        }


        private void newList()
        {
            // Loading file.
            CurrentList = new TaskList("new List");

            // Adding tab.
            TabPage newTab = new TabPage("new List");
            newTab.Controls.Add(new ListViewControl(CurrentList)
            {
                Dock = DockStyle.Fill
            });

            TabControler.TabPages.Add(newTab);
            TabControler.SelectedTab = newTab;

        }
        private void btnNewList_Click(object sender, EventArgs e)
            => newList();

        private void TabControler_TabIndexChanged(object sender, EventArgs e)
        {
            CurrentList = GetListControl().TaskList;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }
    }

}
