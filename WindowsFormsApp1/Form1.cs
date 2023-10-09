using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
  

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HS1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float HS1 = -1;
            bool hs1Bool = float.TryParse(txtHS1.Text, out HS1);
            if (!hs1Bool) 
            {
                    MessageBox.Show("Vui lòng nhập số ở ô Hệ số 1!");
            }
            float HS2 = -1;
            bool hs2Bool = float.TryParse(txtHS2.Text, out HS2);
            if (!hs2Bool)
            {
                MessageBox.Show("Vui lòng nhập số ở ô Hệ số 2!");
            }
            var ketQua = HS1 + HS2;
            txtAns.Text = ketQua.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHS1.Text = "";
            txtHS2.Text = "";
            txtAns.Text = "";
            txtHS1.Focus();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            float HS1 = -1;
            bool hs1Bool = float.TryParse(txtHS1.Text, out HS1);
            if (!hs1Bool)
            {
                MessageBox.Show("Vui lòng nhập số ở ô Hệ số 1!");
            }
            float HS2 = -1;
            bool hs2Bool = float.TryParse(txtHS2.Text, out HS2);
            if (!hs2Bool)
            {
                MessageBox.Show("Vui lòng nhập số ở ô Hệ số 2!");
            }
            var ketQua = HS1 - HS2;
            txtAns.Text = ketQua.ToString();
        }

        private void btnMul_Click_1(object sender, EventArgs e)
        {
            float HS1 = -1;
            bool hs1Bool = float.TryParse(txtHS1.Text, out HS1);
            if (!hs1Bool)
            {
                MessageBox.Show("Vui lòng nhập số ở ô Hệ số 1!");
            }
            float HS2 = -1;
            bool hs2Bool = float.TryParse(txtHS2.Text, out HS2);
            if (!hs2Bool)
            {
                MessageBox.Show("Vui lòng nhập số ở ô Hệ số 2!");
            }
            var ketQua = HS1 * HS2;
            txtAns.Text = ketQua.ToString();
        }

        private void btnDiv_Click_1(object sender, EventArgs e)
        {
            float HS1 = -1;
            bool hs1Bool = float.TryParse(txtHS1.Text, out HS1);
            if (!hs1Bool)
            {
                MessageBox.Show("Vui lòng nhập số ở ô Hệ số 1!");
            }
            float HS2 = -1;
            bool hs2Bool = float.TryParse(txtHS2.Text, out HS2);
            if (!hs2Bool)
            {
                MessageBox.Show("Vui lòng nhập số ở ô Hệ số 2!");
            }
            var ketQua = HS1 / HS2;
            if (HS2 != 0)
            {
                txtAns.Text = ketQua.ToString();
            }
            else
            {
                MessageBox.Show("Không thể chia một số cho 0!");
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtHS1_KeyPress(object sender, KeyPressEventArgs e)
        {
                // Verify that the pressed key isn't CTRL or any non-numeric digit
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
                {
                    e.Handled = true;
                }

                // If you want, you can allow decimal (float) numbers
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
        }

        private void txtHS2_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
                {
                    e.Handled = true;
                }

                // If you want, you can allow decimal (float) numbers
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
        }
    }
}
