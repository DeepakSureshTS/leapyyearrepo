using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUser.Text;
            password = txtPass.Text;
        if (username=="admin" && password=="admin")
            {
                MessageBox.Show("Suceessfull login");
            }
        else
            {
                MessageBox.Show("error");
            }
        }
    }
}
