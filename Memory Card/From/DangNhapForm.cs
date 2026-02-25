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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string name = txtPlayerName.Text.Trim();
            if (name.Length < 2 || name.Length > 20)
            {
                MessageBox.Show(
                    "Tên phải từ 2 đến 20 ký tự!", 
                    "Lỗi",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
            else if (result == DialogResult.No)
                return;
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            
        }

        private void DangNhapForm_Load(object sender, EventArgs e)
        {

        }
    }
}
