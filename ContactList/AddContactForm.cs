using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string soDienThoai = txtSoDienThoai.Text;

            if (string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(soDienThoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Đã lưu liên hệ: {hoTen} - {soDienThoai}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Đóng Form sau khi lưu
            // them Form de them lien he - Cap nhat lan 2
    }
    }
}
