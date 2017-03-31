using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SI
{
    public partial class Form1 : Form
    {
        public bool play = true;
        public Game1 game;

        float time = 0.0f;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSTART_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Display game over text
        public void updateForGameOver()
        {
            buttonSaveScore.Enabled = false;
            buttonSaveScore.Visible = false;
            buttonSTART.Text = "PLAY AGAIN";
            label1.Text = "GAME OVER!";
            label2.Text = "";
            label3.Text = "";
        }

        //Make save time button visible and active, display win text, show time from victory
        public void updateForWin(float t)
        {
            time = t;
            buttonSaveScore.Enabled = true;
            buttonSaveScore.Visible = true;
            buttonSTART.Text = "PLAY AGAIN";
            label1.Text = "YOU WIN!";
            label2.Text = "";
            label3.Text = "Your time: " + t.ToString("0.000") + " seconds.";
        }

        private void buttonINSTRUCTIONS_Click(object sender, EventArgs e)
        {
            label2.Text = " Use the arrow keys to move. \n Press Space to shoot. \n Destroy the invaders before they reach your ship. \n Beware - as you kill them, the invaders will fight back. \n Press Escape to Exit.";
        }

        //Open high score file (or create it if it doesnt exist) on "HIGH SCORES" button click
        private void buttonHighScoreForm_Click(object sender, EventArgs e)
        {
            if (File.Exists("besttimes.txt"))
                Process.Start("notepad.exe", "besttimes.txt");
            else
            {
                File.Create("besttimes.txt");
                Process.Start("notepad.exe", "besttimes.txt");
            }
        }

        //Add time to best times file
        private void buttonSaveScore_Click(object sender, EventArgs e)
        {
            SaveTimes(time);
        }

        //Same method as used in project 5; creates a file if it doesnt exist and writes the time to it.
        private void SaveTimes(float t)
        {
            if (File.Exists("besttimes.txt"))
            {
                using (StreamWriter writer = new StreamWriter("besttimes.txt", true))
                {
                      writer.WriteLine(t.ToString("0.000") + "\n");         
                }
            }
            else
            {
                File.Create("besttimes.txt");
                SaveTimes(t);
            }
        }
    }
}
