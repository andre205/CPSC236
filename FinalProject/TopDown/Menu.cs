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
    public partial class Menu : Form
    {
        public bool play = true;
        public bool tut = false;

        public Menu()
        {
            InitializeComponent();
        }

        private void button_tut_Click(object sender, EventArgs e)
        {
            //"TUTORIAL"
            tut = true;
            Close();
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            //"ONE"
            Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            //EXIT
            play = false;
            Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

    }
}
