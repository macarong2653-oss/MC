using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Card.From
{
    public partial class frmMenu : Form
    {
        string playerName;
        public frmMenu(string name)
        {
            InitializeComponent();
            playerName = name;
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblPlayer.Text = "Player: " + playerName;
        }

        private void lblPlayer_Click(object sender, EventArgs e)
        {

        }
    }
}
