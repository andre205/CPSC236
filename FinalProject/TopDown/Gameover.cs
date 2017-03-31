using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopDown
{
    public partial class Gameover : Form
    {
        public bool playagain = true;

        public Gameover()
        {
            InitializeComponent();
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            //PLAY AGIAN
            Close();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //EXIT

            playagain = false;
            Close();
        }


    }
}
