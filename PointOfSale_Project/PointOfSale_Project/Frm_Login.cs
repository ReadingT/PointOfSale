using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_Project
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectionStr.connnectsql();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            DataTable CheckUser = ConnectionStr.executsql("SELECT * FROM TBL_USER WHERE USERNAME='" + txtUserName.Text + "' AND PASSWORD='" + txtPassword.Text + "'");

            if (CheckUser.Rows.Count > 0)
            {
                MessageBox.Show("ยินดีต้อนรับ คุณ" + CheckUser.Rows[0]["USERNAME"] + "เข้าสู่ระบบ" , "ยินดีต้อนรับ", MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Btn_login_Click(sender, e);
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }
    }
}
