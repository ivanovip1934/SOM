namespace SOM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGrV_ShowGroups = new System.Windows.Forms.DataGridView();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistinquishedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGrV_ShowUsers = new System.Windows.Forms.DataGridView();
            this.HASH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_countusers = new System.Windows.Forms.Label();
            this.button_authorization = new System.Windows.Forms.Button();
            this.radioButton_Username = new System.Windows.Forms.RadioButton();
            this.radioButton_FIO = new System.Windows.Forms.RadioButton();
            this.textBox_Shablon = new System.Windows.Forms.TextBox();
            this.button_StartSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label_passwordexpired = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_passwordlastset = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_enabled = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_lastlogondate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_whenCreated = new System.Windows.Forms.Label();
            this.whenCreated = new System.Windows.Forms.Label();
            this.label_DistinguishedName = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.DistinguishedName = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.label_FIO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Users = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_savesettings = new System.Windows.Forms.Button();
            this.textBox_fullloginname = new System.Windows.Forms.TextBox();
            this.textBox_SearchBase = new System.Windows.Forms.TextBox();
            this.textBox_fullDNSnameCD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrV_ShowGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrV_ShowUsers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1529, 919);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dataGrV_ShowGroups);
            this.tabPage1.Controls.Add(this.dataGrV_ShowUsers);
            this.tabPage1.Controls.Add(this.label_countusers);
            this.tabPage1.Controls.Add(this.button_authorization);
            this.tabPage1.Controls.Add(this.radioButton_Username);
            this.tabPage1.Controls.Add(this.radioButton_FIO);
            this.tabPage1.Controls.Add(this.textBox_Shablon);
            this.tabPage1.Controls.Add(this.button_StartSearch);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.listBox_Users);
            this.tabPage1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1521, 891);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Запросы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Всего найдено:";
            // 
            // dataGrV_ShowGroups
            // 
            this.dataGrV_ShowGroups.AllowUserToAddRows = false;
            this.dataGrV_ShowGroups.AllowUserToDeleteRows = false;
            this.dataGrV_ShowGroups.BackgroundColor = System.Drawing.Color.White;
            this.dataGrV_ShowGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrV_ShowGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupName,
            this.DistinquishedName});
            this.dataGrV_ShowGroups.Location = new System.Drawing.Point(632, 383);
            this.dataGrV_ShowGroups.Name = "dataGrV_ShowGroups";
            this.dataGrV_ShowGroups.RowHeadersVisible = false;
            this.dataGrV_ShowGroups.RowTemplate.Height = 25;
            this.dataGrV_ShowGroups.Size = new System.Drawing.Size(687, 235);
            this.dataGrV_ShowGroups.TabIndex = 10;
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "Имя группы";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.Width = 400;
            // 
            // DistinquishedName
            // 
            this.DistinquishedName.HeaderText = "Полный путь";
            this.DistinquishedName.Name = "DistinquishedName";
            this.DistinquishedName.ReadOnly = true;
            this.DistinquishedName.Width = 2000;
            // 
            // dataGrV_ShowUsers
            // 
            this.dataGrV_ShowUsers.AllowUserToAddRows = false;
            this.dataGrV_ShowUsers.AllowUserToDeleteRows = false;
            this.dataGrV_ShowUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGrV_ShowUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrV_ShowUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HASH,
            this.FIO,
            this.Count});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrV_ShowUsers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrV_ShowUsers.Location = new System.Drawing.Point(224, 28);
            this.dataGrV_ShowUsers.Name = "dataGrV_ShowUsers";
            this.dataGrV_ShowUsers.ReadOnly = true;
            this.dataGrV_ShowUsers.RowHeadersVisible = false;
            this.dataGrV_ShowUsers.RowTemplate.Height = 25;
            this.dataGrV_ShowUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrV_ShowUsers.Size = new System.Drawing.Size(384, 381);
            this.dataGrV_ShowUsers.TabIndex = 9;
            this.dataGrV_ShowUsers.SelectionChanged += new System.EventHandler(this.dataGrV_ShowUsers_SelectionChanged);
            // 
            // HASH
            // 
            this.HASH.HeaderText = "HASH";
            this.HASH.Name = "HASH";
            this.HASH.ReadOnly = true;
            this.HASH.Visible = false;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            this.FIO.Width = 315;
            // 
            // Count
            // 
            this.Count.HeaderText = "Кол-во";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 80;
            // 
            // label_countusers
            // 
            this.label_countusers.AutoSize = true;
            this.label_countusers.Location = new System.Drawing.Point(545, 423);
            this.label_countusers.Name = "label_countusers";
            this.label_countusers.Size = new System.Drawing.Size(63, 19);
            this.label_countusers.TabIndex = 8;
            this.label_countusers.Text = "label1";
            this.label_countusers.Visible = false;
            // 
            // button_authorization
            // 
            this.button_authorization.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_authorization.Location = new System.Drawing.Point(20, 28);
            this.button_authorization.Name = "button_authorization";
            this.button_authorization.Size = new System.Drawing.Size(183, 40);
            this.button_authorization.TabIndex = 7;
            this.button_authorization.Text = "Авторизация";
            this.button_authorization.UseVisualStyleBackColor = true;
            this.button_authorization.Click += new System.EventHandler(this.button_authorization_Click);
            // 
            // radioButton_Username
            // 
            this.radioButton_Username.AutoSize = true;
            this.radioButton_Username.Enabled = false;
            this.radioButton_Username.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_Username.Location = new System.Drawing.Point(19, 332);
            this.radioButton_Username.Name = "radioButton_Username";
            this.radioButton_Username.Size = new System.Drawing.Size(99, 23);
            this.radioButton_Username.TabIndex = 6;
            this.radioButton_Username.Text = "username";
            this.radioButton_Username.UseVisualStyleBackColor = true;
            this.radioButton_Username.CheckedChanged += new System.EventHandler(this.radioButton_Username_CheckedChanged);
            // 
            // radioButton_FIO
            // 
            this.radioButton_FIO.AutoSize = true;
            this.radioButton_FIO.Checked = true;
            this.radioButton_FIO.Enabled = false;
            this.radioButton_FIO.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_FIO.Location = new System.Drawing.Point(20, 297);
            this.radioButton_FIO.Name = "radioButton_FIO";
            this.radioButton_FIO.Size = new System.Drawing.Size(54, 23);
            this.radioButton_FIO.TabIndex = 5;
            this.radioButton_FIO.TabStop = true;
            this.radioButton_FIO.Text = "ФИО";
            this.radioButton_FIO.UseVisualStyleBackColor = true;
            this.radioButton_FIO.CheckedChanged += new System.EventHandler(this.radioButton_FIO_CheckedChanged);
            // 
            // textBox_Shablon
            // 
            this.textBox_Shablon.Enabled = false;
            this.textBox_Shablon.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Shablon.Location = new System.Drawing.Point(15, 383);
            this.textBox_Shablon.Name = "textBox_Shablon";
            this.textBox_Shablon.Size = new System.Drawing.Size(192, 26);
            this.textBox_Shablon.TabIndex = 4;
            // 
            // button_StartSearch
            // 
            this.button_StartSearch.Enabled = false;
            this.button_StartSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_StartSearch.Location = new System.Drawing.Point(15, 423);
            this.button_StartSearch.Name = "button_StartSearch";
            this.button_StartSearch.Size = new System.Drawing.Size(192, 38);
            this.button_StartSearch.TabIndex = 3;
            this.button_StartSearch.Text = "Поиск по ФИО";
            this.button_StartSearch.UseVisualStyleBackColor = true;
            this.button_StartSearch.Click += new System.EventHandler(this.button_StartSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label_passwordexpired);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label_passwordlastset);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label_enabled);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label_lastlogondate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_whenCreated);
            this.groupBox1.Controls.Add(this.whenCreated);
            this.groupBox1.Controls.Add(this.label_DistinguishedName);
            this.groupBox1.Controls.Add(this.label_login);
            this.groupBox1.Controls.Add(this.DistinguishedName);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.label_FIO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(632, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 349);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пользователь";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(7, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 19);
            this.label12.TabIndex = 16;
            this.label12.Text = "Дата смена пароля";
            // 
            // label_passwordexpired
            // 
            this.label_passwordexpired.AutoSize = true;
            this.label_passwordexpired.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_passwordexpired.ForeColor = System.Drawing.Color.Green;
            this.label_passwordexpired.Location = new System.Drawing.Point(210, 151);
            this.label_passwordexpired.Name = "label_passwordexpired";
            this.label_passwordexpired.Size = new System.Drawing.Size(63, 19);
            this.label_passwordexpired.TabIndex = 15;
            this.label_passwordexpired.Text = "label2";
            this.label_passwordexpired.Visible = false;
            this.label_passwordexpired.TextChanged += new System.EventHandler(this.label_passwordexpired_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(7, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Пароль истек";
            // 
            // label_passwordlastset
            // 
            this.label_passwordlastset.AutoSize = true;
            this.label_passwordlastset.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_passwordlastset.Location = new System.Drawing.Point(210, 125);
            this.label_passwordlastset.Name = "label_passwordlastset";
            this.label_passwordlastset.Size = new System.Drawing.Size(63, 19);
            this.label_passwordlastset.TabIndex = 13;
            this.label_passwordlastset.Text = "label2";
            this.label_passwordlastset.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(400, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 19);
            this.label11.TabIndex = 12;
            // 
            // label_enabled
            // 
            this.label_enabled.AutoSize = true;
            this.label_enabled.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_enabled.ForeColor = System.Drawing.Color.Green;
            this.label_enabled.Location = new System.Drawing.Point(210, 175);
            this.label_enabled.Name = "label_enabled";
            this.label_enabled.Size = new System.Drawing.Size(63, 19);
            this.label_enabled.TabIndex = 11;
            this.label_enabled.Text = "label2";
            this.label_enabled.Visible = false;
            this.label_enabled.TextChanged += new System.EventHandler(this.label_enabled_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Учетка активная";
            // 
            // label_lastlogondate
            // 
            this.label_lastlogondate.AutoSize = true;
            this.label_lastlogondate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_lastlogondate.Location = new System.Drawing.Point(210, 101);
            this.label_lastlogondate.Name = "label_lastlogondate";
            this.label_lastlogondate.Size = new System.Drawing.Size(63, 19);
            this.label_lastlogondate.TabIndex = 9;
            this.label_lastlogondate.Text = "label2";
            this.label_lastlogondate.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Последнее время входа";
            // 
            // label_whenCreated
            // 
            this.label_whenCreated.AutoSize = true;
            this.label_whenCreated.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_whenCreated.Location = new System.Drawing.Point(210, 77);
            this.label_whenCreated.Name = "label_whenCreated";
            this.label_whenCreated.Size = new System.Drawing.Size(63, 19);
            this.label_whenCreated.TabIndex = 7;
            this.label_whenCreated.Text = "label2";
            this.label_whenCreated.Visible = false;
            // 
            // whenCreated
            // 
            this.whenCreated.AutoSize = true;
            this.whenCreated.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whenCreated.Location = new System.Drawing.Point(6, 77);
            this.whenCreated.Name = "whenCreated";
            this.whenCreated.Size = new System.Drawing.Size(135, 19);
            this.whenCreated.TabIndex = 6;
            this.whenCreated.Text = "Время создания";
            // 
            // label_DistinguishedName
            // 
            this.label_DistinguishedName.AutoSize = true;
            this.label_DistinguishedName.Location = new System.Drawing.Point(6, 231);
            this.label_DistinguishedName.MaximumSize = new System.Drawing.Size(700, 60);
            this.label_DistinguishedName.Name = "label_DistinguishedName";
            this.label_DistinguishedName.Size = new System.Drawing.Size(63, 19);
            this.label_DistinguishedName.TabIndex = 5;
            this.label_DistinguishedName.Text = "label6";
            this.label_DistinguishedName.Visible = false;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_login.Location = new System.Drawing.Point(210, 48);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(108, 19);
            this.label_login.TabIndex = 4;
            this.label_login.Text = "label_login";
            this.label_login.Visible = false;
            // 
            // DistinguishedName
            // 
            this.DistinguishedName.AutoSize = true;
            this.DistinguishedName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DistinguishedName.Location = new System.Drawing.Point(6, 198);
            this.DistinguishedName.Name = "DistinguishedName";
            this.DistinguishedName.Size = new System.Drawing.Size(162, 19);
            this.DistinguishedName.TabIndex = 3;
            this.DistinguishedName.Text = "DistinguishedName";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(6, 48);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(54, 19);
            this.login.TabIndex = 2;
            this.login.Text = "Login";
            // 
            // label_FIO
            // 
            this.label_FIO.AutoSize = true;
            this.label_FIO.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_FIO.Location = new System.Drawing.Point(210, 22);
            this.label_FIO.Name = "label_FIO";
            this.label_FIO.Size = new System.Drawing.Size(63, 19);
            this.label_FIO.TabIndex = 1;
            this.label_FIO.Text = "label2";
            this.label_FIO.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // listBox_Users
            // 
            this.listBox_Users.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_Users.FormattingEnabled = true;
            this.listBox_Users.ItemHeight = 19;
            this.listBox_Users.Location = new System.Drawing.Point(224, 445);
            this.listBox_Users.Name = "listBox_Users";
            this.listBox_Users.Size = new System.Drawing.Size(384, 175);
            this.listBox_Users.TabIndex = 0;
            this.listBox_Users.SelectedIndexChanged += new System.EventHandler(this.listBox_Users_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_savesettings);
            this.tabPage2.Controls.Add(this.textBox_fullloginname);
            this.tabPage2.Controls.Add(this.textBox_SearchBase);
            this.tabPage2.Controls.Add(this.textBox_fullDNSnameCD);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1521, 891);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настрока";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_savesettings
            // 
            this.button_savesettings.Enabled = false;
            this.button_savesettings.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_savesettings.Location = new System.Drawing.Point(402, 290);
            this.button_savesettings.Name = "button_savesettings";
            this.button_savesettings.Size = new System.Drawing.Size(192, 45);
            this.button_savesettings.TabIndex = 8;
            this.button_savesettings.Text = "Сохранить";
            this.button_savesettings.UseVisualStyleBackColor = true;
            this.button_savesettings.Click += new System.EventHandler(this.button_savesettings_Click);
            // 
            // textBox_fullloginname
            // 
            this.textBox_fullloginname.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_fullloginname.Location = new System.Drawing.Point(485, 212);
            this.textBox_fullloginname.Name = "textBox_fullloginname";
            this.textBox_fullloginname.Size = new System.Drawing.Size(352, 26);
            this.textBox_fullloginname.TabIndex = 7;
            this.textBox_fullloginname.TextChanged += new System.EventHandler(this.textBox_fullloginname_TextChanged);
            // 
            // textBox_SearchBase
            // 
            this.textBox_SearchBase.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_SearchBase.Location = new System.Drawing.Point(485, 147);
            this.textBox_SearchBase.Name = "textBox_SearchBase";
            this.textBox_SearchBase.Size = new System.Drawing.Size(352, 26);
            this.textBox_SearchBase.TabIndex = 6;
            this.textBox_SearchBase.TextChanged += new System.EventHandler(this.textBox_SearchBase_TextChanged);
            // 
            // textBox_fullDNSnameCD
            // 
            this.textBox_fullDNSnameCD.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_fullDNSnameCD.Location = new System.Drawing.Point(485, 83);
            this.textBox_fullDNSnameCD.Name = "textBox_fullDNSnameCD";
            this.textBox_fullDNSnameCD.Size = new System.Drawing.Size(352, 26);
            this.textBox_fullDNSnameCD.TabIndex = 5;
            this.textBox_fullDNSnameCD.TextChanged += new System.EventHandler(this.textBox_fullDNSnameCD_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(105, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Логин пользователя (domainnam\\username)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(105, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Насальный адресс поиска в AD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(105, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Полное DNS имя контроллера домена";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 667);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOM";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrV_ShowGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrV_ShowUsers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBox_Shablon;
        private Button button_StartSearch;
        private GroupBox groupBox1;
        private ListBox listBox_Users;
        private TabPage tabPage2;
        private RadioButton radioButton_Username;
        private RadioButton radioButton_FIO;
        private Button button_authorization;
        private Label label_countusers;
        private Label label_DistinguishedName;
        private Label label_login;
        private Label DistinguishedName;
        private Label login;
        private Label label_FIO;
        private Label label1;
        private Label label_whenCreated;
        private Label whenCreated;
        private DataGridView dataGrV_ShowUsers;
        private DataGridView dataGrV_ShowGroups;
        private DataGridViewTextBoxColumn GroupName;
        private DataGridViewTextBoxColumn DistinquishedName;
        private Label label_enabled;
        private Label label4;
        private Label label_lastlogondate;
        private Label label3;
        private Button button_savesettings;
        private TextBox textBox_fullloginname;
        private TextBox textBox_SearchBase;
        private TextBox textBox_fullDNSnameCD;
        private Label label6;
        private Label label5;
        private Label label2;
        private DataGridViewTextBoxColumn HASH;
        private DataGridViewTextBoxColumn FIO;
        private DataGridViewTextBoxColumn Count;
        private Label label7;
        private Label label12;
        private Label label_passwordexpired;
        private Label label9;
        private Label label_passwordlastset;
        private Label label11;
    }
}