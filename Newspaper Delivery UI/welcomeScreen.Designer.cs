
using System;

namespace Newspaper_Delivery_UI
{
    partial class welcomeScreen
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
            this.components = new System.ComponentModel.Container();
            this.employeeButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.RouteButton = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.UsernameEntry = new System.Windows.Forms.TextBox();
            this.PasswordEntry = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.LoginTimer = new System.Windows.Forms.Timer(this.components);
            this.householdsDataSet = new Newspaper_Delivery_UI.HouseholdsDataSet();
            this.pnlNewCust = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ApartmentField = new System.Windows.Forms.TextBox();
            this.ZipField = new System.Windows.Forms.TextBox();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.ApartmentLabel = new System.Windows.Forms.Label();
            this.LastNameField = new System.Windows.Forms.TextBox();
            this.StNameField = new System.Windows.Forms.TextBox();
            this.StNameLabel = new System.Windows.Forms.Label();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.FNameField = new System.Windows.Forms.TextBox();
            this.StNumberField = new System.Windows.Forms.TextBox();
            this.StreetNumLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.StatusDisplay = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerTimer = new System.Windows.Forms.Timer(this.components);
            this.tableAdapterManager = new Newspaper_Delivery_UI.HouseholdsDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.householdsDataSet)).BeginInit();
            this.pnlNewCust.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeButton
            // 
            this.employeeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeButton.BackColor = System.Drawing.Color.Transparent;
            this.employeeButton.FlatAppearance.BorderSize = 0;
            this.employeeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.employeeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.employeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeButton.Font = new System.Drawing.Font("Unispace", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.employeeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.employeeButton.Location = new System.Drawing.Point(0, 112);
            this.employeeButton.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(231, 56);
            this.employeeButton.TabIndex = 5;
            this.employeeButton.Text = "Couriers";
            this.employeeButton.UseVisualStyleBackColor = false;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerButton.BackColor = System.Drawing.Color.Transparent;
            this.customerButton.FlatAppearance.BorderSize = 0;
            this.customerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.customerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.customerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerButton.Font = new System.Drawing.Font("Unispace", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customerButton.ImageKey = "(none)";
            this.customerButton.Location = new System.Drawing.Point(0, 0);
            this.customerButton.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(231, 56);
            this.customerButton.TabIndex = 0;
            this.customerButton.Text = "Add Customer";
            this.customerButton.UseVisualStyleBackColor = false;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.customerButton);
            this.flowLayoutPanel1.Controls.Add(this.SearchButton);
            this.flowLayoutPanel1.Controls.Add(this.employeeButton);
            this.flowLayoutPanel1.Controls.Add(this.RouteButton);
            this.flowLayoutPanel1.Controls.Add(this.btnManage);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 149);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(231, 654);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Unispace", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchButton.ImageKey = "(none)";
            this.SearchButton.Location = new System.Drawing.Point(0, 56);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(231, 56);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Payment";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RouteButton
            // 
            this.RouteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RouteButton.BackColor = System.Drawing.Color.Transparent;
            this.RouteButton.FlatAppearance.BorderSize = 0;
            this.RouteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.RouteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.RouteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RouteButton.Font = new System.Drawing.Font("Unispace", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RouteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RouteButton.Location = new System.Drawing.Point(0, 168);
            this.RouteButton.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.RouteButton.Name = "RouteButton";
            this.RouteButton.Size = new System.Drawing.Size(231, 56);
            this.RouteButton.TabIndex = 7;
            this.RouteButton.Text = "Route";
            this.RouteButton.UseVisualStyleBackColor = false;
            // 
            // btnManage
            // 
            this.btnManage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManage.BackColor = System.Drawing.Color.Transparent;
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.btnManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Unispace", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnManage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnManage.Location = new System.Drawing.Point(0, 224);
            this.btnManage.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(231, 56);
            this.btnManage.TabIndex = 9;
            this.btnManage.Text = "Management";
            this.btnManage.UseVisualStyleBackColor = false;
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.LoginPanel.Controls.Add(this.UsernameEntry);
            this.LoginPanel.Controls.Add(this.PasswordEntry);
            this.LoginPanel.Controls.Add(this.PasswordLabel);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.IDLabel);
            this.LoginPanel.Location = new System.Drawing.Point(234, 149);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(845, 654);
            this.LoginPanel.TabIndex = 11;
            // 
            // UsernameEntry
            // 
            this.UsernameEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.UsernameEntry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameEntry.Font = new System.Drawing.Font("Unispace", 12F);
            this.UsernameEntry.Location = new System.Drawing.Point(416, 172);
            this.UsernameEntry.Margin = new System.Windows.Forms.Padding(0);
            this.UsernameEntry.Name = "UsernameEntry";
            this.UsernameEntry.Size = new System.Drawing.Size(189, 20);
            this.UsernameEntry.TabIndex = 0;
            // 
            // PasswordEntry
            // 
            this.PasswordEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.PasswordEntry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordEntry.Font = new System.Drawing.Font("Unispace", 12F);
            this.PasswordEntry.Location = new System.Drawing.Point(416, 209);
            this.PasswordEntry.Margin = new System.Windows.Forms.Padding(0);
            this.PasswordEntry.Name = "PasswordEntry";
            this.PasswordEntry.Size = new System.Drawing.Size(189, 20);
            this.PasswordEntry.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Unispace", 11.25F);
            this.PasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.PasswordLabel.Location = new System.Drawing.Point(324, 209);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(89, 18);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Passcode:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Unispace", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(80, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 216);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome back. Have a great shift!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Unispace", 11.25F);
            this.IDLabel.ForeColor = System.Drawing.Color.Black;
            this.IDLabel.Location = new System.Drawing.Point(297, 174);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(116, 18);
            this.IDLabel.TabIndex = 2;
            this.IDLabel.Text = "Employee ID:";
            // 
            // LoginTimer
            // 
            this.LoginTimer.Interval = 10;
            this.LoginTimer.Tick += new System.EventHandler(this.LoginTimer_Tick);
            // 
            // householdsDataSet
            // 
            this.householdsDataSet.DataSetName = "HouseholdsDataSet";
            this.householdsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlNewCust
            // 
            this.pnlNewCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.pnlNewCust.Controls.Add(this.label3);
            this.pnlNewCust.Controls.Add(this.btnAdd);
            this.pnlNewCust.Controls.Add(this.panel2);
            this.pnlNewCust.Controls.Add(this.label2);
            this.pnlNewCust.Controls.Add(this.ApartmentField);
            this.pnlNewCust.Controls.Add(this.ZipField);
            this.pnlNewCust.Controls.Add(this.ZipLabel);
            this.pnlNewCust.Controls.Add(this.ApartmentLabel);
            this.pnlNewCust.Controls.Add(this.LastNameField);
            this.pnlNewCust.Controls.Add(this.StNameField);
            this.pnlNewCust.Controls.Add(this.StNameLabel);
            this.pnlNewCust.Controls.Add(this.LNameLabel);
            this.pnlNewCust.Controls.Add(this.FNameField);
            this.pnlNewCust.Controls.Add(this.StNumberField);
            this.pnlNewCust.Controls.Add(this.StreetNumLabel);
            this.pnlNewCust.Controls.Add(this.FirstNameLabel);
            this.pnlNewCust.Location = new System.Drawing.Point(234, 149);
            this.pnlNewCust.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNewCust.Name = "pnlNewCust";
            this.pnlNewCust.Size = new System.Drawing.Size(845, 654);
            this.pnlNewCust.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Unispace", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(211, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 53);
            this.label3.TabIndex = 15;
            this.label3.Text = "NOTE!! Only available to people within the 11200 - 11300 area codes! ";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::Newspaper_Delivery_UI.Properties.Resources.add_user;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(51)))), ((int)(((byte)(120)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(51)))), ((int)(((byte)(130)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Unispace", 16F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(528, 301);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 79);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Newspaper_Delivery_UI.Properties.Resources.express_mail;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(294, 415);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 149);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Unispace", 29.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(268, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 53);
            this.label2.TabIndex = 12;
            this.label2.Text = "Add Customer ";
            // 
            // ApartmentField
            // 
            this.ApartmentField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.ApartmentField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApartmentField.Font = new System.Drawing.Font("Unispace", 12F);
            this.ApartmentField.Location = new System.Drawing.Point(203, 301);
            this.ApartmentField.Margin = new System.Windows.Forms.Padding(0);
            this.ApartmentField.Name = "ApartmentField";
            this.ApartmentField.Size = new System.Drawing.Size(189, 20);
            this.ApartmentField.TabIndex = 8;
            // 
            // ZipField
            // 
            this.ZipField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.ZipField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ZipField.Font = new System.Drawing.Font("Unispace", 12F);
            this.ZipField.Location = new System.Drawing.Point(203, 338);
            this.ZipField.Margin = new System.Windows.Forms.Padding(0);
            this.ZipField.Name = "ZipField";
            this.ZipField.Size = new System.Drawing.Size(189, 20);
            this.ZipField.TabIndex = 9;
            this.ZipField.TextChanged += new System.EventHandler(this.ZipField_TextChanged);
            // 
            // ZipLabel
            // 
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Font = new System.Drawing.Font("Unispace", 11.25F);
            this.ZipLabel.ForeColor = System.Drawing.Color.Black;
            this.ZipLabel.Location = new System.Drawing.Point(111, 339);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(89, 18);
            this.ZipLabel.TabIndex = 11;
            this.ZipLabel.Text = "Zip Code:";
            // 
            // ApartmentLabel
            // 
            this.ApartmentLabel.AutoSize = true;
            this.ApartmentLabel.Font = new System.Drawing.Font("Unispace", 11.25F);
            this.ApartmentLabel.ForeColor = System.Drawing.Color.Black;
            this.ApartmentLabel.Location = new System.Drawing.Point(102, 302);
            this.ApartmentLabel.Name = "ApartmentLabel";
            this.ApartmentLabel.Size = new System.Drawing.Size(98, 18);
            this.ApartmentLabel.TabIndex = 10;
            this.ApartmentLabel.Text = "Apartment:";
            // 
            // LastNameField
            // 
            this.LastNameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.LastNameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameField.Font = new System.Drawing.Font("Unispace", 12F);
            this.LastNameField.Location = new System.Drawing.Point(528, 229);
            this.LastNameField.Margin = new System.Windows.Forms.Padding(0);
            this.LastNameField.Name = "LastNameField";
            this.LastNameField.Size = new System.Drawing.Size(189, 20);
            this.LastNameField.TabIndex = 4;
            this.LastNameField.TextChanged += new System.EventHandler(this.LastNameField_TextChanged);
            // 
            // StNameField
            // 
            this.StNameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.StNameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StNameField.Font = new System.Drawing.Font("Unispace", 12F);
            this.StNameField.Location = new System.Drawing.Point(528, 264);
            this.StNameField.Margin = new System.Windows.Forms.Padding(0);
            this.StNameField.Name = "StNameField";
            this.StNameField.Size = new System.Drawing.Size(189, 20);
            this.StNameField.TabIndex = 5;
            // 
            // StNameLabel
            // 
            this.StNameLabel.AutoSize = true;
            this.StNameLabel.Font = new System.Drawing.Font("Unispace", 11.25F);
            this.StNameLabel.ForeColor = System.Drawing.Color.Black;
            this.StNameLabel.Location = new System.Drawing.Point(409, 264);
            this.StNameLabel.Name = "StNameLabel";
            this.StNameLabel.Size = new System.Drawing.Size(116, 18);
            this.StNameLabel.TabIndex = 7;
            this.StNameLabel.Text = "Street Name:";
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Font = new System.Drawing.Font("Unispace", 11.25F);
            this.LNameLabel.ForeColor = System.Drawing.Color.Black;
            this.LNameLabel.Location = new System.Drawing.Point(427, 231);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(98, 18);
            this.LNameLabel.TabIndex = 6;
            this.LNameLabel.Text = "Last Name:";
            // 
            // FNameField
            // 
            this.FNameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.FNameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FNameField.Font = new System.Drawing.Font("Unispace", 12F);
            this.FNameField.Location = new System.Drawing.Point(203, 227);
            this.FNameField.Margin = new System.Windows.Forms.Padding(0);
            this.FNameField.Name = "FNameField";
            this.FNameField.Size = new System.Drawing.Size(189, 20);
            this.FNameField.TabIndex = 0;
            this.FNameField.TextChanged += new System.EventHandler(this.FNameField_TextChanged);
            // 
            // StNumberField
            // 
            this.StNumberField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.StNumberField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StNumberField.Font = new System.Drawing.Font("Unispace", 12F);
            this.StNumberField.Location = new System.Drawing.Point(203, 264);
            this.StNumberField.Margin = new System.Windows.Forms.Padding(0);
            this.StNumberField.Name = "StNumberField";
            this.StNumberField.Size = new System.Drawing.Size(189, 20);
            this.StNumberField.TabIndex = 1;
            this.StNumberField.TextChanged += new System.EventHandler(this.StNumberField_TextChanged);
            // 
            // StreetNumLabel
            // 
            this.StreetNumLabel.AutoSize = true;
            this.StreetNumLabel.Font = new System.Drawing.Font("Unispace", 11.25F);
            this.StreetNumLabel.ForeColor = System.Drawing.Color.Black;
            this.StreetNumLabel.Location = new System.Drawing.Point(66, 266);
            this.StreetNumLabel.Name = "StreetNumLabel";
            this.StreetNumLabel.Size = new System.Drawing.Size(134, 18);
            this.StreetNumLabel.TabIndex = 3;
            this.StreetNumLabel.Text = "Street Number:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Unispace", 11.25F);
            this.FirstNameLabel.ForeColor = System.Drawing.Color.Black;
            this.FirstNameLabel.Location = new System.Drawing.Point(93, 228);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(107, 18);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.StatusDisplay);
            this.pnlSearch.Controls.Add(this.btnPay);
            this.pnlSearch.Controls.Add(this.label4);
            this.pnlSearch.Controls.Add(this.StatusLabel);
            this.pnlSearch.Controls.Add(this.label5);
            this.pnlSearch.Controls.Add(this.textBox1);
            this.pnlSearch.Controls.Add(this.label6);
            this.pnlSearch.Controls.Add(this.textBox2);
            this.pnlSearch.Location = new System.Drawing.Point(234, 149);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(845, 660);
            this.pnlSearch.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::Newspaper_Delivery_UI.Properties.Resources.search_64;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(51)))), ((int)(((byte)(120)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(51)))), ((int)(((byte)(130)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Unispace", 16F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(707, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 62);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // StatusDisplay
            // 
            this.StatusDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.StatusDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusDisplay.Font = new System.Drawing.Font("Unispace", 12F);
            this.StatusDisplay.Location = new System.Drawing.Point(501, 87);
            this.StatusDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.StatusDisplay.Name = "StatusDisplay";
            this.StatusDisplay.ReadOnly = true;
            this.StatusDisplay.Size = new System.Drawing.Size(189, 20);
            this.StatusDisplay.TabIndex = 15;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BackgroundImage = global::Newspaper_Delivery_UI.Properties.Resources.credit_64;
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(51)))), ((int)(((byte)(120)))));
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(51)))), ((int)(((byte)(130)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Unispace", 16F);
            this.btnPay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPay.Location = new System.Drawing.Point(767, 45);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(54, 62);
            this.btnPay.TabIndex = 14;
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Impact", 29F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 57);
            this.label4.TabIndex = 12;
            this.label4.Text = "Search";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Unispace", 11.25F);
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel.Location = new System.Drawing.Point(355, 89);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(143, 18);
            this.StatusLabel.TabIndex = 16;
            this.StatusLabel.Text = "Payment Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Unispace", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(34, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Name:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Unispace", 12F);
            this.textBox1.Location = new System.Drawing.Point(135, 73);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Unispace", 11.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(25, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "First Name:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Unispace", 12F);
            this.textBox2.Location = new System.Drawing.Point(135, 104);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(189, 20);
            this.textBox2.TabIndex = 4;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "Address";
            this.addressBindingSource.DataSource = this.householdsDataSet;
            // 
            // CustomerTimer
            // 
            this.CustomerTimer.Interval = 10;
            this.CustomerTimer.Tick += new System.EventHandler(this.CustomerTimer_Tick);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CouriersTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Newspaper_Delivery_UI.HouseholdsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Newspaper_Delivery_UI.Properties.Resources.flash;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 149);
            this.panel1.TabIndex = 8;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = global::Newspaper_Delivery_UI.Properties.Resources.ic_close_black_24dp_2x;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(1026, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(53, 56);
            this.exitButton.TabIndex = 3;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SearchTimer
            // 
            this.SearchTimer.Interval = 10;
            this.SearchTimer.Tick += new System.EventHandler(this.SearchTimer_Tick);
            // 
            // welcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(94)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 806);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlNewCust);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.exitButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "welcomeScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.welcomeScreen_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.householdsDataSet)).EndInit();
            this.pnlNewCust.ResumeLayout(false);
            this.pnlNewCust.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            
            this.ResumeLayout(false);

        }




        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.TextBox UsernameEntry;
        private System.Windows.Forms.TextBox PasswordEntry;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer LoginTimer;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button RouteButton;
        private System.Windows.Forms.Panel pnlNewCust;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ZipLabel;
        private System.Windows.Forms.Label ApartmentLabel;
        private System.Windows.Forms.TextBox StNameField;
        private System.Windows.Forms.Label StNameLabel;
        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.Label StreetNumLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private HouseholdsDataSet householdsDataSet;
        private System.Windows.Forms.BindingSource addressBindingSource;
      
        private HouseholdsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ApartmentField;
        private System.Windows.Forms.TextBox ZipField;
        private System.Windows.Forms.TextBox LastNameField;
        private System.Windows.Forms.TextBox FNameField;
        private System.Windows.Forms.TextBox StNumberField;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Timer CustomerTimer;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox StatusDisplay;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer SearchTimer;
    }
}

