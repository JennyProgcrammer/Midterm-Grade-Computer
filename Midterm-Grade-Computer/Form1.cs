using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marinay___Lab_Activity_1F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string passWord = textBoxPassword.Text;

            if (userName == "Jennymarinay03" && passWord == "12345678")
            {
                MessageBox.Show("Log-In Successful!");
                Form2 form = new Form2();
                form.Visible = true;
                this.Hide();
            }
            else { MessageBox.Show("Inavlid Credentials, Please Try Again!"); }

        }
    }
}
