using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOM
{
    public partial class GetCredential : Form
    {
        
        private Form1  mainform;

        public GetCredential(Form1 MainForm)
        {
           
            mainform = MainForm;
            InitializeComponent();
            this.label_login.Text = Properties.Settings.Default.login_name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecureString pass = new SecureString();
            
            string text_box_pass = text_box_password.Text.Trim();
            if (text_box_pass.Length > 0)
            {
                foreach (char ch in text_box_pass.ToCharArray()) { 
                    pass.AppendChar(ch);
                }

                mainform.cred = new PSCredential(Properties.Settings.Default.login_name, pass);
            }
            else {
                MessageBox.Show("Text box pass is null");            
            }

            this.Close();
        }
    }
}
