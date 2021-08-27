
namespace RemoteChangeServiceAccount
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxCredentials = new System.Windows.Forms.GroupBox();
            this.radioButtonNetworkService = new System.Windows.Forms.RadioButton();
            this.radioButtonSpecificUser = new System.Windows.Forms.RadioButton();
            this.buttonChangeCredentials = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAllPass = new System.Windows.Forms.TextBox();
            this.textBoxAllDomain = new System.Windows.Forms.TextBox();
            this.textBoxAllUser = new System.Windows.Forms.TextBox();
            this.groupBoxManagementServer = new System.Windows.Forms.GroupBox();
            this.radioButtonBasicUser = new System.Windows.Forms.RadioButton();
            this.radioButtonWindowsUser = new System.Windows.Forms.RadioButton();
            this.radioButtonCurrentUser = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMSVer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMSName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMSAddress = new System.Windows.Forms.TextBox();
            this.textBoxMSPass = new System.Windows.Forms.TextBox();
            this.textBoxMSDomain = new System.Windows.Forms.TextBox();
            this.textBoxMSUser = new System.Windows.Forms.TextBox();
            this.buttonGetServices = new System.Windows.Forms.Button();
            this.Get_Servers = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serversDataGridView = new System.Windows.Forms.DataGridView();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBoxServices = new System.Windows.Forms.GroupBox();
            this.servicesDataGridView = new System.Windows.Forms.DataGridView();
            this.ServiceServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAppPools = new System.Windows.Forms.DataGridView();
            this.AppPoolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppPoolUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppPoolState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppPoolSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textBox_Console = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_MaxDegreeOfParallelism = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxCredentials.SuspendLayout();
            this.groupBoxManagementServer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serversDataGridView)).BeginInit();
            this.groupBoxServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppPools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MaxDegreeOfParallelism)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCredentials
            // 
            this.groupBoxCredentials.Controls.Add(this.radioButtonNetworkService);
            this.groupBoxCredentials.Controls.Add(this.radioButtonSpecificUser);
            this.groupBoxCredentials.Controls.Add(this.buttonChangeCredentials);
            this.groupBoxCredentials.Controls.Add(this.label10);
            this.groupBoxCredentials.Controls.Add(this.label11);
            this.groupBoxCredentials.Controls.Add(this.label12);
            this.groupBoxCredentials.Controls.Add(this.textBoxAllPass);
            this.groupBoxCredentials.Controls.Add(this.textBoxAllDomain);
            this.groupBoxCredentials.Controls.Add(this.textBoxAllUser);
            this.groupBoxCredentials.ForeColor = System.Drawing.Color.Snow;
            this.groupBoxCredentials.Location = new System.Drawing.Point(371, 12);
            this.groupBoxCredentials.Name = "groupBoxCredentials";
            this.groupBoxCredentials.Size = new System.Drawing.Size(290, 168);
            this.groupBoxCredentials.TabIndex = 15;
            this.groupBoxCredentials.TabStop = false;
            this.groupBoxCredentials.Text = "Change Credentials";
            // 
            // radioButtonNetworkService
            // 
            this.radioButtonNetworkService.AutoSize = true;
            this.radioButtonNetworkService.Location = new System.Drawing.Point(176, 60);
            this.radioButtonNetworkService.Name = "radioButtonNetworkService";
            this.radioButtonNetworkService.Size = new System.Drawing.Size(104, 17);
            this.radioButtonNetworkService.TabIndex = 4;
            this.radioButtonNetworkService.Text = "Network Service";
            this.radioButtonNetworkService.UseVisualStyleBackColor = true;
            // 
            // radioButtonSpecificUser
            // 
            this.radioButtonSpecificUser.AutoSize = true;
            this.radioButtonSpecificUser.Checked = true;
            this.radioButtonSpecificUser.Location = new System.Drawing.Point(176, 37);
            this.radioButtonSpecificUser.Name = "radioButtonSpecificUser";
            this.radioButtonSpecificUser.Size = new System.Drawing.Size(88, 17);
            this.radioButtonSpecificUser.TabIndex = 3;
            this.radioButtonSpecificUser.TabStop = true;
            this.radioButtonSpecificUser.Text = "Specific User";
            this.radioButtonSpecificUser.UseVisualStyleBackColor = true;
            // 
            // buttonChangeCredentials
            // 
            this.buttonChangeCredentials.Enabled = false;
            this.buttonChangeCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeCredentials.ForeColor = System.Drawing.Color.Snow;
            this.buttonChangeCredentials.Location = new System.Drawing.Point(6, 125);
            this.buttonChangeCredentials.Name = "buttonChangeCredentials";
            this.buttonChangeCredentials.Size = new System.Drawing.Size(275, 30);
            this.buttonChangeCredentials.TabIndex = 5;
            this.buttonChangeCredentials.Text = "Change Credentials";
            this.buttonChangeCredentials.UseVisualStyleBackColor = true;
            this.buttonChangeCredentials.Click += new System.EventHandler(this.buttonAllCredentials_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Pass";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Domain";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "User";
            // 
            // textBoxAllPass
            // 
            this.textBoxAllPass.Location = new System.Drawing.Point(61, 71);
            this.textBoxAllPass.Name = "textBoxAllPass";
            this.textBoxAllPass.PasswordChar = '*';
            this.textBoxAllPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxAllPass.TabIndex = 2;
            // 
            // textBoxAllDomain
            // 
            this.textBoxAllDomain.Location = new System.Drawing.Point(61, 19);
            this.textBoxAllDomain.Name = "textBoxAllDomain";
            this.textBoxAllDomain.Size = new System.Drawing.Size(100, 20);
            this.textBoxAllDomain.TabIndex = 0;
            // 
            // textBoxAllUser
            // 
            this.textBoxAllUser.Location = new System.Drawing.Point(61, 45);
            this.textBoxAllUser.Name = "textBoxAllUser";
            this.textBoxAllUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxAllUser.TabIndex = 1;
            // 
            // groupBoxManagementServer
            // 
            this.groupBoxManagementServer.Controls.Add(this.radioButtonBasicUser);
            this.groupBoxManagementServer.Controls.Add(this.radioButtonWindowsUser);
            this.groupBoxManagementServer.Controls.Add(this.radioButtonCurrentUser);
            this.groupBoxManagementServer.Controls.Add(this.label5);
            this.groupBoxManagementServer.Controls.Add(this.label6);
            this.groupBoxManagementServer.Controls.Add(this.labelMSVer);
            this.groupBoxManagementServer.Controls.Add(this.label7);
            this.groupBoxManagementServer.Controls.Add(this.labelMSName);
            this.groupBoxManagementServer.Controls.Add(this.label8);
            this.groupBoxManagementServer.Controls.Add(this.textBoxMSAddress);
            this.groupBoxManagementServer.Controls.Add(this.textBoxMSPass);
            this.groupBoxManagementServer.Controls.Add(this.textBoxMSDomain);
            this.groupBoxManagementServer.Controls.Add(this.textBoxMSUser);
            this.groupBoxManagementServer.Controls.Add(this.buttonGetServices);
            this.groupBoxManagementServer.Controls.Add(this.Get_Servers);
            this.groupBoxManagementServer.ForeColor = System.Drawing.Color.Snow;
            this.groupBoxManagementServer.Location = new System.Drawing.Point(12, 12);
            this.groupBoxManagementServer.Name = "groupBoxManagementServer";
            this.groupBoxManagementServer.Size = new System.Drawing.Size(342, 168);
            this.groupBoxManagementServer.TabIndex = 17;
            this.groupBoxManagementServer.TabStop = false;
            this.groupBoxManagementServer.Text = "Management Server";
            // 
            // radioButtonBasicUser
            // 
            this.radioButtonBasicUser.AutoSize = true;
            this.radioButtonBasicUser.Location = new System.Drawing.Point(200, 74);
            this.radioButtonBasicUser.Name = "radioButtonBasicUser";
            this.radioButtonBasicUser.Size = new System.Drawing.Size(73, 17);
            this.radioButtonBasicUser.TabIndex = 14;
            this.radioButtonBasicUser.Text = "BasicUser";
            this.radioButtonBasicUser.UseVisualStyleBackColor = true;
            // 
            // radioButtonWindowsUser
            // 
            this.radioButtonWindowsUser.AutoSize = true;
            this.radioButtonWindowsUser.Checked = true;
            this.radioButtonWindowsUser.Location = new System.Drawing.Point(200, 23);
            this.radioButtonWindowsUser.Name = "radioButtonWindowsUser";
            this.radioButtonWindowsUser.Size = new System.Drawing.Size(91, 17);
            this.radioButtonWindowsUser.TabIndex = 14;
            this.radioButtonWindowsUser.TabStop = true;
            this.radioButtonWindowsUser.Text = "WindowsUser";
            this.radioButtonWindowsUser.UseVisualStyleBackColor = true;
            // 
            // radioButtonCurrentUser
            // 
            this.radioButtonCurrentUser.AutoSize = true;
            this.radioButtonCurrentUser.Location = new System.Drawing.Point(200, 50);
            this.radioButtonCurrentUser.Name = "radioButtonCurrentUser";
            this.radioButtonCurrentUser.Size = new System.Drawing.Size(81, 17);
            this.radioButtonCurrentUser.TabIndex = 14;
            this.radioButtonCurrentUser.Text = "CurrentUser";
            this.radioButtonCurrentUser.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pass";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Domain";
            // 
            // labelMSVer
            // 
            this.labelMSVer.AutoSize = true;
            this.labelMSVer.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMSVer.Location = new System.Drawing.Point(253, 102);
            this.labelMSVer.Name = "labelMSVer";
            this.labelMSVer.Size = new System.Drawing.Size(76, 13);
            this.labelMSVer.TabIndex = 13;
            this.labelMSVer.Text = "Server Version";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "User";
            // 
            // labelMSName
            // 
            this.labelMSName.AutoSize = true;
            this.labelMSName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMSName.Location = new System.Drawing.Point(178, 102);
            this.labelMSName.Name = "labelMSName";
            this.labelMSName.Size = new System.Drawing.Size(69, 13);
            this.labelMSName.TabIndex = 13;
            this.labelMSName.Text = "Server Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "IP";
            // 
            // textBoxMSAddress
            // 
            this.textBoxMSAddress.Location = new System.Drawing.Point(72, 22);
            this.textBoxMSAddress.Name = "textBoxMSAddress";
            this.textBoxMSAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxMSAddress.TabIndex = 4;
            // 
            // textBoxMSPass
            // 
            this.textBoxMSPass.Location = new System.Drawing.Point(72, 99);
            this.textBoxMSPass.Name = "textBoxMSPass";
            this.textBoxMSPass.PasswordChar = '*';
            this.textBoxMSPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxMSPass.TabIndex = 5;
            // 
            // textBoxMSDomain
            // 
            this.textBoxMSDomain.Location = new System.Drawing.Point(72, 47);
            this.textBoxMSDomain.Name = "textBoxMSDomain";
            this.textBoxMSDomain.Size = new System.Drawing.Size(100, 20);
            this.textBoxMSDomain.TabIndex = 6;
            // 
            // textBoxMSUser
            // 
            this.textBoxMSUser.Location = new System.Drawing.Point(72, 73);
            this.textBoxMSUser.Name = "textBoxMSUser";
            this.textBoxMSUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxMSUser.TabIndex = 7;
            // 
            // buttonGetServices
            // 
            this.buttonGetServices.Enabled = false;
            this.buttonGetServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetServices.ForeColor = System.Drawing.Color.Snow;
            this.buttonGetServices.Location = new System.Drawing.Point(181, 125);
            this.buttonGetServices.Name = "buttonGetServices";
            this.buttonGetServices.Size = new System.Drawing.Size(143, 30);
            this.buttonGetServices.TabIndex = 3;
            this.buttonGetServices.Text = "Get Services";
            this.buttonGetServices.UseVisualStyleBackColor = true;
            this.buttonGetServices.Click += new System.EventHandler(this.GetServices_Button_Click);
            // 
            // Get_Servers
            // 
            this.Get_Servers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Get_Servers.ForeColor = System.Drawing.Color.Snow;
            this.Get_Servers.Location = new System.Drawing.Point(16, 125);
            this.Get_Servers.Name = "Get_Servers";
            this.Get_Servers.Size = new System.Drawing.Size(143, 30);
            this.Get_Servers.TabIndex = 3;
            this.Get_Servers.Text = "Get Servers";
            this.Get_Servers.UseVisualStyleBackColor = true;
            this.Get_Servers.Click += new System.EventHandler(this.Get_Servers_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.serversDataGridView);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.Snow;
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1004, 147);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servers List";
            // 
            // serversDataGridView
            // 
            this.serversDataGridView.AllowUserToAddRows = false;
            this.serversDataGridView.AllowUserToDeleteRows = false;
            this.serversDataGridView.AllowUserToOrderColumns = true;
            this.serversDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serversDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.serversDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serversDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serversDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DisplayName,
            this.ServerType,
            this.Address,
            this.Domain,
            this.User,
            this.Password,
            this.Selected});
            this.serversDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serversDataGridView.Location = new System.Drawing.Point(3, 16);
            this.serversDataGridView.Name = "serversDataGridView";
            this.serversDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.serversDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.serversDataGridView.Size = new System.Drawing.Size(998, 128);
            this.serversDataGridView.TabIndex = 0;
            // 
            // DisplayName
            // 
            this.DisplayName.HeaderText = "DisplayName";
            this.DisplayName.Name = "DisplayName";
            // 
            // ServerType
            // 
            this.ServerType.HeaderText = "ServerType";
            this.ServerType.Name = "ServerType";
            this.ServerType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Domain
            // 
            this.Domain.HeaderText = "Domain";
            this.Domain.Name = "Domain";
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.Name = "User";
            // 
            // Password
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.Password.DefaultCellStyle = dataGridViewCellStyle1;
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // Selected
            // 
            this.Selected.HeaderText = "Selected";
            this.Selected.Name = "Selected";
            // 
            // groupBoxServices
            // 
            this.groupBoxServices.Controls.Add(this.servicesDataGridView);
            this.groupBoxServices.ForeColor = System.Drawing.Color.Snow;
            this.groupBoxServices.Location = new System.Drawing.Point(12, 339);
            this.groupBoxServices.Name = "groupBoxServices";
            this.groupBoxServices.Size = new System.Drawing.Size(1004, 238);
            this.groupBoxServices.TabIndex = 19;
            this.groupBoxServices.TabStop = false;
            this.groupBoxServices.Text = "Milestone Services";
            // 
            // servicesDataGridView
            // 
            this.servicesDataGridView.AllowUserToAddRows = false;
            this.servicesDataGridView.AllowUserToDeleteRows = false;
            this.servicesDataGridView.AllowUserToResizeRows = false;
            this.servicesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.servicesDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.servicesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.servicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceServer,
            this.ServiceName,
            this.ServiceUserName,
            this.ServiceState,
            this.ServiceSelected});
            this.servicesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servicesDataGridView.Location = new System.Drawing.Point(3, 16);
            this.servicesDataGridView.MultiSelect = false;
            this.servicesDataGridView.Name = "servicesDataGridView";
            this.servicesDataGridView.RowHeadersVisible = false;
            this.servicesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.servicesDataGridView.Size = new System.Drawing.Size(998, 219);
            this.servicesDataGridView.TabIndex = 0;
            // 
            // ServiceServer
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ServiceServer.DefaultCellStyle = dataGridViewCellStyle3;
            this.ServiceServer.HeaderText = "ServiceServer";
            this.ServiceServer.Name = "ServiceServer";
            // 
            // ServiceName
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ServiceName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ServiceName.HeaderText = "ServiceName";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // ServiceUserName
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ServiceUserName.DefaultCellStyle = dataGridViewCellStyle5;
            this.ServiceUserName.FillWeight = 60F;
            this.ServiceUserName.HeaderText = "ServiceUserName";
            this.ServiceUserName.Name = "ServiceUserName";
            this.ServiceUserName.ReadOnly = true;
            // 
            // ServiceState
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ServiceState.DefaultCellStyle = dataGridViewCellStyle6;
            this.ServiceState.FillWeight = 40F;
            this.ServiceState.HeaderText = "ServiceState";
            this.ServiceState.Name = "ServiceState";
            this.ServiceState.ReadOnly = true;
            // 
            // ServiceSelected
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.NullValue = false;
            this.ServiceSelected.DefaultCellStyle = dataGridViewCellStyle7;
            this.ServiceSelected.FillWeight = 15F;
            this.ServiceSelected.HeaderText = " ";
            this.ServiceSelected.Name = "ServiceSelected";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewAppPools);
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(667, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 93);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Milestone AppPools";
            // 
            // dataGridViewAppPools
            // 
            this.dataGridViewAppPools.AllowUserToAddRows = false;
            this.dataGridViewAppPools.AllowUserToDeleteRows = false;
            this.dataGridViewAppPools.AllowUserToResizeRows = false;
            this.dataGridViewAppPools.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAppPools.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewAppPools.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAppPools.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewAppPools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppPools.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppPoolName,
            this.AppPoolUserName,
            this.AppPoolState,
            this.AppPoolSelected});
            this.dataGridViewAppPools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAppPools.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewAppPools.MultiSelect = false;
            this.dataGridViewAppPools.Name = "dataGridViewAppPools";
            this.dataGridViewAppPools.RowHeadersVisible = false;
            this.dataGridViewAppPools.Size = new System.Drawing.Size(340, 74);
            this.dataGridViewAppPools.TabIndex = 0;
            // 
            // AppPoolName
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AppPoolName.DefaultCellStyle = dataGridViewCellStyle8;
            this.AppPoolName.HeaderText = "AppPoolName";
            this.AppPoolName.Name = "AppPoolName";
            this.AppPoolName.ReadOnly = true;
            // 
            // AppPoolUserName
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AppPoolUserName.DefaultCellStyle = dataGridViewCellStyle9;
            this.AppPoolUserName.FillWeight = 60F;
            this.AppPoolUserName.HeaderText = "AppPoolUserName";
            this.AppPoolUserName.Name = "AppPoolUserName";
            this.AppPoolUserName.ReadOnly = true;
            // 
            // AppPoolState
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AppPoolState.DefaultCellStyle = dataGridViewCellStyle10;
            this.AppPoolState.FillWeight = 40F;
            this.AppPoolState.HeaderText = "AppPoolState";
            this.AppPoolState.Name = "AppPoolState";
            this.AppPoolState.ReadOnly = true;
            // 
            // AppPoolSelected
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.NullValue = false;
            this.AppPoolSelected.DefaultCellStyle = dataGridViewCellStyle11;
            this.AppPoolSelected.FillWeight = 15F;
            this.AppPoolSelected.HeaderText = " ";
            this.AppPoolSelected.Name = "AppPoolSelected";
            // 
            // textBox_Console
            // 
            this.textBox_Console.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox_Console.Location = new System.Drawing.Point(9, 583);
            this.textBox_Console.Name = "textBox_Console";
            this.textBox_Console.Size = new System.Drawing.Size(1007, 138);
            this.textBox_Console.TabIndex = 20;
            this.textBox_Console.TabStop = false;
            this.textBox_Console.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(683, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Degree Of Parallelism";
            // 
            // numericUpDown_MaxDegreeOfParallelism
            // 
            this.numericUpDown_MaxDegreeOfParallelism.Location = new System.Drawing.Point(797, 31);
            this.numericUpDown_MaxDegreeOfParallelism.Name = "numericUpDown_MaxDegreeOfParallelism";
            this.numericUpDown_MaxDegreeOfParallelism.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown_MaxDegreeOfParallelism.TabIndex = 24;
            this.numericUpDown_MaxDegreeOfParallelism.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(670, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Change Credentials";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(910, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 25;
            this.button2.Text = "Change Credentials";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1023, 735);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_MaxDegreeOfParallelism);
            this.Controls.Add(this.textBox_Console);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxServices);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxManagementServer);
            this.Controls.Add(this.groupBoxCredentials);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxCredentials.ResumeLayout(false);
            this.groupBoxCredentials.PerformLayout();
            this.groupBoxManagementServer.ResumeLayout(false);
            this.groupBoxManagementServer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serversDataGridView)).EndInit();
            this.groupBoxServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppPools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MaxDegreeOfParallelism)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCredentials;
        private System.Windows.Forms.RadioButton radioButtonNetworkService;
        private System.Windows.Forms.RadioButton radioButtonSpecificUser;
        private System.Windows.Forms.Button buttonChangeCredentials;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAllPass;
        private System.Windows.Forms.TextBox textBoxAllDomain;
        private System.Windows.Forms.TextBox textBoxAllUser;
        private System.Windows.Forms.GroupBox groupBoxManagementServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMSVer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMSName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMSAddress;
        private System.Windows.Forms.TextBox textBoxMSPass;
        private System.Windows.Forms.TextBox textBoxMSDomain;
        private System.Windows.Forms.TextBox textBoxMSUser;
        private System.Windows.Forms.Button Get_Servers;
        private System.Windows.Forms.RadioButton radioButtonBasicUser;
        private System.Windows.Forms.RadioButton radioButtonWindowsUser;
        private System.Windows.Forms.RadioButton radioButtonCurrentUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView serversDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domain;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.GroupBox groupBoxServices;
        private System.Windows.Forms.DataGridView servicesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceState;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ServiceSelected;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewAppPools;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppPoolName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppPoolUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppPoolState;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AppPoolSelected;
        private System.Windows.Forms.RichTextBox textBox_Console;
        private System.Windows.Forms.Button buttonGetServices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_MaxDegreeOfParallelism;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

