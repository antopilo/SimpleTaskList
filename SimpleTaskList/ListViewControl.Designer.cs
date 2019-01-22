namespace SimpleTaskList
{
    partial class ListViewControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // taskList
            // 
            this.taskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskList.FormattingEnabled = true;
            this.taskList.Location = new System.Drawing.Point(0, 0);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(325, 346);
            this.taskList.TabIndex = 1;
            // 
            // ListViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.taskList);
            this.Name = "ListViewControl";
            this.Size = new System.Drawing.Size(325, 346);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox taskList;
    }
}
