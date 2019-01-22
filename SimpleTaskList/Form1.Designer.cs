using System;

namespace SimpleTaskList
{
    partial class SimpleTaskList
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtNewTask = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnRemove = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnOpenList = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TabControler = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNewList = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSaveAs = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(212, 70);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton1.TabIndex = 1;
            this.materialRaisedButton1.Text = "Add task";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // txtNewTask
            // 
            this.txtNewTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewTask.Depth = 0;
            this.txtNewTask.Hint = "";
            this.txtNewTask.Location = new System.Drawing.Point(12, 70);
            this.txtNewTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNewTask.Name = "txtNewTask";
            this.txtNewTask.PasswordChar = '\0';
            this.txtNewTask.SelectedText = "";
            this.txtNewTask.SelectionLength = 0;
            this.txtNewTask.SelectionStart = 0;
            this.txtNewTask.Size = new System.Drawing.Size(172, 23);
            this.txtNewTask.TabIndex = 2;
            this.txtNewTask.UseSystemPasswordChar = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.AutoSize = true;
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Depth = 0;
            this.btnRemove.Location = new System.Drawing.Point(152, 431);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Primary = false;
            this.btnRemove.Size = new System.Drawing.Size(135, 36);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Selected";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // btnOpenList
            // 
            this.btnOpenList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenList.Depth = 0;
            this.btnOpenList.Location = new System.Drawing.Point(15, 431);
            this.btnOpenList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenList.Name = "btnOpenList";
            this.btnOpenList.Primary = true;
            this.btnOpenList.Size = new System.Drawing.Size(130, 36);
            this.btnOpenList.TabIndex = 4;
            this.btnOpenList.Text = "Open List";
            this.btnOpenList.UseVisualStyleBackColor = true;
            this.btnOpenList.Click += new System.EventHandler(this.btnOpenList_Click);
            // 
            // TabControler
            // 
            this.TabControler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControler.Location = new System.Drawing.Point(12, 140);
            this.TabControler.Name = "TabControler";
            this.TabControler.SelectedIndex = 0;
            this.TabControler.Size = new System.Drawing.Size(276, 282);
            this.TabControler.TabIndex = 5;
            this.TabControler.TabIndexChanged += new System.EventHandler(this.TabControler_TabIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(262, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNewList
            // 
            this.btnNewList.AutoSize = true;
            this.btnNewList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewList.Depth = 0;
            this.btnNewList.Location = new System.Drawing.Point(12, 102);
            this.btnNewList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNewList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewList.Name = "btnNewList";
            this.btnNewList.Primary = false;
            this.btnNewList.Size = new System.Drawing.Size(73, 36);
            this.btnNewList.TabIndex = 7;
            this.btnNewList.Text = "New List";
            this.btnNewList.UseVisualStyleBackColor = true;
            this.btnNewList.Click += new System.EventHandler(this.btnNewList_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.AutoSize = true;
            this.btnSaveAs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveAs.Depth = 0;
            this.btnSaveAs.Location = new System.Drawing.Point(93, 102);
            this.btnSaveAs.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveAs.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Primary = false;
            this.btnSaveAs.Size = new System.Drawing.Size(67, 36);
            this.btnSaveAs.TabIndex = 8;
            this.btnSaveAs.Text = "Save as";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // SimpleTaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 479);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnNewList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TabControler);
            this.Controls.Add(this.btnOpenList);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtNewTask);
            this.Controls.Add(this.materialRaisedButton1);
            this.MinimumSize = new System.Drawing.Size(300, 439);
            this.Name = "SimpleTaskList";
            this.Text = "Simple Task List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimpleTaskList_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNewTask;
        private MaterialSkin.Controls.MaterialFlatButton btnRemove;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenList;
        private System.Windows.Forms.TabControl TabControler;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialFlatButton btnNewList;
        private MaterialSkin.Controls.MaterialFlatButton btnSaveAs;
    }
}

