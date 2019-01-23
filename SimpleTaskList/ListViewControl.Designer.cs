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
            this.taskList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskList.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskList.FormattingEnabled = true;
            this.taskList.Location = new System.Drawing.Point(0, 0);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(325, 346);
            this.taskList.TabIndex = 1;
            this.taskList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.taskList_ItemCheck);
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
