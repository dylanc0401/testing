using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void bntPrevClick(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0)
                tabControl1.SelectedIndex--;
        }

        private void btnNextClick(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex < tabControl1.TabPages.Count)
                tabControl1.SelectedIndex++;
        }

        private void num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            float n1 = float.Parse(num1.Text);
            float n2 = float.Parse(num2.Text);
            float sum = n1 + n2;
            lblResult.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float n1 = float.Parse(num1.Text);
            float n2 = float.Parse(num2.Text);
            float r = n1 / n2;
            lblResult.Text = r.ToString();
        }
    }
}

