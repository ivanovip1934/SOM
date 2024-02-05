using System.Management.Automation;

namespace SOM
{
    public partial class Form1 : Form
    {
        public PSCredential cred;
        private List<User> ls_users;
        public string loginname = @"dp.mosreg.ru\MezhetskiySV";
        private TypeSearch typeSearch;
        private User tmp_user;
        public Form1()
        {
            InitializeComponent();
            this.textBox_SearchBase.Text = Properties.Settings.Default.search_base;
            this.textBox_fullDNSnameCD.Text = Properties.Settings.Default.dns_adress;
            this.textBox_fullloginname.Text = Properties.Settings.Default.login_name;
            this.button_savesettings.Enabled = false; 

        }



        private void button_StartSearch_Click(object sender, EventArgs e)
        {
            string shablon = textBox_Shablon.Text.Trim();
            if (shablon.Length > 0)
            {
                button_StartSearch.Text = "Идет поиск";
                ls_users = HelperFunc.SearchUser(cred, shablon, typeSearch);
                ls_users.Sort();
            }
            else
            {
                MessageBox.Show("Шаблон поиска пустой");
            }
            button_StartSearch.Text = "Повторить поиск";


            //this.listBox_Users.Items.Clear();            
            //this.listBox_Users.Items.AddRange(ls_users.Select(x => x.UserName).ToArray());
            //this.listBox_Users.SelectedIndex = 0;
            //this.label_countusers.Text = ls_users.Count.ToString();
            //this.label_countusers.Visible = true;
            //this.listPC1.Items.Clear();
            //this.listPC1.Items.AddRange(dicPC.Select(x => x.Key).ToArray());
            //this.labelTextAllPC.Text = listPC1.Items.Count.ToString();
            //this.labelTextAllPC.Visible = true;

            this.dataGrV_ShowGroups.Rows.Clear();
            this.listBox_Users.Items.Clear();
            this.dataGrV_ShowUsers.Rows.Clear();

            var query = ls_users.OrderBy(x => x.UserName).
                GroupBy(x => new { x.UserName, x.Hash},
                    (User, users) => new {Hash=User.Hash,  UserName = User.UserName, Count = users.Count() }).ToList();

                
            foreach (var item in query)
            {
                this.dataGrV_ShowUsers.Rows.Add(item.Hash, item.UserName, item.Count);
            }
            if (this.dataGrV_ShowUsers.Rows.Count > 0)
            {
                this.dataGrV_ShowUsers.Rows[0].Selected = true; 
            }

            

        }

        private void radioButton_FIO_CheckedChanged(object sender, EventArgs e)
        {
            button_StartSearch.Text = radioButton_FIO.Checked ? "Поиск по ФИО": "Поиск по username";
            typeSearch = radioButton_FIO.Checked ? TypeSearch.FIO : TypeSearch.UserName;
            
            
        }

        private void radioButton_Username_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button_authorization_Click(object sender, EventArgs e)
        {
            new GetCredential(this).ShowDialog();
            this.button_StartSearch.Enabled = true;
            this.radioButton_FIO.Enabled = true;
            this.radioButton_Username.Enabled = true;
            this.textBox_Shablon.Enabled = true;    

        }

        private void dataGrV_ShowUsers_SelectionChanged(object sender, EventArgs e)
        {
            int tmp_hash= 0;
            foreach (DataGridViewRow row in dataGrV_ShowUsers.SelectedRows) {
                tmp_hash = (int)(row.Cells["Hash"].Value);
            }
            
                this.listBox_Users.Items.Clear();
                this.listBox_Users.Items.AddRange(ls_users.Where(x => x.Hash == tmp_hash).Select(x => x.SamAccountName).ToArray());
                if (this.listBox_Users.Items.Count>0) {
                    this.listBox_Users.SelectedIndex = 0;
                }
                
                this.label_countusers.Text = ls_users.Count.ToString();
                this.label_countusers.Visible = true;
            

            
            

        }

        private void listBox_Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Users.SelectedIndex != -1)
            {
                tmp_user = ls_users.Where(x => x.SamAccountName == this.listBox_Users.SelectedItem.ToString()).FirstOrDefault();

                this.label_FIO.Text = tmp_user.UserName;
                this.label_login.Text = tmp_user.SamAccountName;
                this.label_whenCreated.Text = tmp_user.WhenCreated.ToString("yyyy, dd MMMM");
                this.label_DistinguishedName.Text = tmp_user.DistinguishedName;
                this.label_lastlogondate.Text=tmp_user.LastLogonDate.ToString("yyyy, dd MMMM");
                this.label_passwordlastset.Text = tmp_user.PasswordLastSet.ToString("yyyy, dd MMMM");
                this.label_passwordexpired.Text = tmp_user.PasswordExpired ? "ДА" : "НЕТ";
                this.label_enabled.Text = tmp_user.Enabled ? "ДА" : "НЕТ";

                this.label_FIO.Visible = true;
                this.label_login.Visible=true; 
                this.label_whenCreated.Visible=true;
                this.label_DistinguishedName.Visible=true;
                this.label_lastlogondate.Visible = true;
                this.label_enabled.Visible = true;
                this.label_passwordlastset.Visible = true;
                this.label_passwordexpired.Visible = true;

                
                
                this.dataGrV_ShowGroups.Rows.Clear();


                foreach ( KeyValuePair<string,string> item in tmp_user.MemberOf  )
                {
                    this.dataGrV_ShowGroups.Rows.Add(item.Key, item.Value);
                }
                

            }


        }

        private void textBox_fullDNSnameCD_TextChanged(object sender, EventArgs e)
        {
            this.button_savesettings.Enabled = true;   
        }

        private void textBox_SearchBase_TextChanged(object sender, EventArgs e)
        {
            this.button_savesettings.Enabled = true;
        }

        private void textBox_fullloginname_TextChanged(object sender, EventArgs e)
        {
            this.button_savesettings.Enabled = true;
        }

        private void button_savesettings_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.dns_adress = textBox_fullDNSnameCD.Text;
            Properties.Settings.Default.search_base= textBox_SearchBase.Text;   
            Properties.Settings.Default.login_name= textBox_fullloginname.Text;
            Properties.Settings.Default.Save();
            this.button_savesettings.Enabled=false;

        }

        private void label_enabled_TextChanged(object sender, EventArgs e)
        {
            if (this.label_enabled.Text == "ДА")
            {
                this.label_enabled.ForeColor = System.Drawing.Color.Green;
            }
            else {
                this.label_enabled.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void label_passwordexpired_TextChanged(object sender, EventArgs e)
        {
            if (this.label_passwordexpired.Text == "НЕТ")
            {
                this.label_passwordexpired.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                this.label_passwordexpired.ForeColor = System.Drawing.Color.Red;
            }

        }



        //private void ShowUser(ListBox listBox) {

        //    if (listBox.SelectedIndex != -1) { 
        //      this.tmp_user =  


        //    }
        //}



    }
}