using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Card.From
{
    public partial class LoginForm : Form
    {
        private string playerName;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grpLogin_Enter(object sender, EventArgs e)
        {

        }

        private void lblĐăngNhập_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text.Trim();

            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên người chơi !",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPlayerName.Focus();
                return;
            }

            if (playerName.Length > 15)
            {
                MessageBox.Show(
                    "Tên không được vượt quá 15 ký tự !",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            //GameSettings.PlayerName = playerName;
            //frmMainMenu menuForm = new frmMainMenu();
            //menuForm.Show();
            //this.Hide();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            //GameSettings.PlayerName = "Guest";
            //GameSettings.IsGuest = true;
            //frmMainMenu mainMenu = new frmMainMenu();
            //mainMenu.Show();
            //this.Hide();
            // Hello
        }
    }
}
