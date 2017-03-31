namespace TopDown
{
    partial class Menu
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
            this.button_tut = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_tut
            // 
            this.button_tut.BackColor = System.Drawing.SystemColors.ControlText;
            this.button_tut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tut.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tut.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_tut.Location = new System.Drawing.Point(12, 357);
            this.button_tut.Name = "button_tut";
            this.button_tut.Size = new System.Drawing.Size(472, 137);
            this.button_tut.TabIndex = 0;
            this.button_tut.Text = "TUTORIAL";
            this.button_tut.UseVisualStyleBackColor = false;
            this.button_tut.Click += new System.EventHandler(this.button_tut_Click);
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.SystemColors.ControlText;
            this.button_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_play.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_play.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_play.Location = new System.Drawing.Point(12, 196);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(960, 137);
            this.button_play.TabIndex = 1;
            this.button_play.Text = "PLAY";
            this.button_play.UseVisualStyleBackColor = false;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.ControlText;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_exit.Location = new System.Drawing.Point(509, 357);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(463, 137);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "EXIT";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(953, 117);
            this.label1.TabIndex = 3;
            this.label1.Text = "-TYLER ANDREWS FINAL- ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(984, 527);
            this.ControlBox = false;
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.button_tut);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_tut;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label1;
    }
}