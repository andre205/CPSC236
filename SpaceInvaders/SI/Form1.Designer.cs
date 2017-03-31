namespace SI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSTART = new System.Windows.Forms.Button();
            this.buttonINSTRUCTIONS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonHighScoreForm = new System.Windows.Forms.Button();
            this.buttonSaveScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSTART
            // 
            this.buttonSTART.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.buttonSTART, "buttonSTART");
            this.buttonSTART.Name = "buttonSTART";
            this.buttonSTART.UseVisualStyleBackColor = false;
            this.buttonSTART.Click += new System.EventHandler(this.buttonSTART_Click);
            // 
            // buttonINSTRUCTIONS
            // 
            this.buttonINSTRUCTIONS.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.buttonINSTRUCTIONS, "buttonINSTRUCTIONS");
            this.buttonINSTRUCTIONS.Name = "buttonINSTRUCTIONS";
            this.buttonINSTRUCTIONS.UseVisualStyleBackColor = false;
            this.buttonINSTRUCTIONS.Click += new System.EventHandler(this.buttonINSTRUCTIONS_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Name = "label1";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Name = "label3";
            // 
            // buttonHighScoreForm
            // 
            this.buttonHighScoreForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.buttonHighScoreForm, "buttonHighScoreForm");
            this.buttonHighScoreForm.Name = "buttonHighScoreForm";
            this.buttonHighScoreForm.UseVisualStyleBackColor = false;
            this.buttonHighScoreForm.Click += new System.EventHandler(this.buttonHighScoreForm_Click);
            // 
            // buttonSaveScore
            // 
            this.buttonSaveScore.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.buttonSaveScore, "buttonSaveScore");
            this.buttonSaveScore.Name = "buttonSaveScore";
            this.buttonSaveScore.UseVisualStyleBackColor = false;
            this.buttonSaveScore.Click += new System.EventHandler(this.buttonSaveScore_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.buttonSaveScore);
            this.Controls.Add(this.buttonHighScoreForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonINSTRUCTIONS);
            this.Controls.Add(this.buttonSTART);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSTART;
        private System.Windows.Forms.Button buttonINSTRUCTIONS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonHighScoreForm;
        private System.Windows.Forms.Button buttonSaveScore;
    }
}