using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestConsole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.SecureWebServiceSoapClient xx = new ServiceReference1.SecureWebServiceSoapClient();

            ServiceReference1.Authentication AuthHeader = new ServiceReference1.Authentication();
            AuthHeader.User = "Hello";
            AuthHeader.Password = "Hello";

            //xx.ClientCredentials.UserName.UserName = "hello";
            //xx.ClientCredentials.UserName.Password = "hello";
            xx.ValidUser(AuthHeader);
        }
    }
}
