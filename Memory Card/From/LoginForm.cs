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

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void grpLogin_Enter(object sender, EventArgs e)
        {

        }

        private void lblĐăngNhập_Click(object sender, EventArgs e)
        {

        }
        private void lblPlayerName_Click(object sender, EventArgs e)
        {

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

        

        private void btnPlay_Click(object sender, EventArgs e)
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

            if (playerName.Length < 2 || playerName.Length > 15)
            {
                MessageBox.Show(
                    "Tên phải từ 2 đến 15 ký tự !",
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
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát không ?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
            else if(result == DialogResult.No)
                return;
        }

    }
}
