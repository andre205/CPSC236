namespace tAndrews_proj05
{
    partial class Form1
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
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.listboxTasks = new System.Windows.Forms.ListBox();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.listboxBugs = new System.Windows.Forms.ListBox();
            this.textboxTaskName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxTaskDue = new System.Windows.Forms.TextBox();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxBugName = new System.Windows.Forms.TextBox();
            this.textboxBugSeverity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddBug = new System.Windows.Forms.Button();
            this.tabcontrol1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tab1);
            this.tabcontrol1.Controls.Add(this.tab2);
            this.tabcontrol1.Location = new System.Drawing.Point(486, 22);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(391, 573);
            this.tabcontrol1.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.listboxTasks);
            this.tab1.Location = new System.Drawing.Point(8, 39);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(375, 526);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Tasks";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // listboxTasks
            // 
            this.listboxTasks.FormattingEnabled = true;
            this.listboxTasks.ItemHeight = 25;
            this.listboxTasks.Location = new System.Drawing.Point(-8, 0);
            this.listboxTasks.Name = "listboxTasks";
            this.listboxTasks.Size = new System.Drawing.Size(383, 529);
            this.listboxTasks.TabIndex = 0;
            this.listboxTasks.SelectedIndexChanged += new System.EventHandler(this.listboxTasks_SelectedIndexChanged);
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.listboxBugs);
            this.tab2.Location = new System.Drawing.Point(8, 39);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(375, 526);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Bugs";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // listboxBugs
            // 
            this.listboxBugs.FormattingEnabled = true;
            this.listboxBugs.ItemHeight = 25;
            this.listboxBugs.Location = new System.Drawing.Point(0, 0);
            this.listboxBugs.Name = "listboxBugs";
            this.listboxBugs.Size = new System.Drawing.Size(383, 529);
            this.listboxBugs.TabIndex = 1;
            // 
            // textboxTaskName
            // 
            this.textboxTaskName.Location = new System.Drawing.Point(34, 100);
            this.textboxTaskName.Name = "textboxTaskName";
            this.textboxTaskName.Size = new System.Drawing.Size(325, 31);
            this.textboxTaskName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the task:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter the due date:";
            // 
            // textboxTaskDue
            // 
            this.textboxTaskDue.Location = new System.Drawing.Point(34, 181);
            this.textboxTaskDue.Name = "textboxTaskDue";
            this.textboxTaskDue.Size = new System.Drawing.Size(325, 31);
            this.textboxTaskDue.TabIndex = 4;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(34, 232);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(146, 37);
            this.buttonAddTask.TabIndex = 5;
            this.buttonAddTask.Text = "Add Task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter the bug:";
            // 
            // textboxBugName
            // 
            this.textboxBugName.Location = new System.Drawing.Point(34, 402);
            this.textboxBugName.Name = "textboxBugName";
            this.textboxBugName.Size = new System.Drawing.Size(325, 31);
            this.textboxBugName.TabIndex = 7;
            // 
            // textboxBugSeverity
            // 
            this.textboxBugSeverity.Location = new System.Drawing.Point(34, 468);
            this.textboxBugSeverity.Name = "textboxBugSeverity";
            this.textboxBugSeverity.Size = new System.Drawing.Size(325, 31);
            this.textboxBugSeverity.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter the severity:";
            // 
            // buttonAddBug
            // 
            this.buttonAddBug.Location = new System.Drawing.Point(34, 520);
            this.buttonAddBug.Name = "buttonAddBug";
            this.buttonAddBug.Size = new System.Drawing.Size(146, 37);
            this.buttonAddBug.TabIndex = 10;
            this.buttonAddBug.Text = "Add Bug";
            this.buttonAddBug.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 944);
            this.Controls.Add(this.buttonAddBug);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxBugSeverity);
            this.Controls.Add(this.textboxBugName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.textboxTaskDue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxTaskName);
            this.Controls.Add(this.tabcontrol1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabcontrol1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.ListBox listboxTasks;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.ListBox listboxBugs;
        private System.Windows.Forms.TextBox textboxTaskName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxTaskDue;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxBugName;
        private System.Windows.Forms.TextBox textboxBugSeverity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddBug;
    }
}

