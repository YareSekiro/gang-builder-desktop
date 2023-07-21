namespace GangBuilderV2
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.HeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.GlobalPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ContentPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.secondLabel = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Label();
            this.firstLabel = new System.Windows.Forms.Label();
            this.installationBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.PanelForButtonPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SettingsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.HomeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PlayerManagementPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.PlayerManagementBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PlayerManagementDesc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PlayerManagementLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.GangBuilderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.GangBuilderBtn = new Guna.UI2.WinForms.Guna2Button();
            this.GangBuilderDesc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GangBuilderLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.GlobalPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.PanelForButtonPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.PlayerManagementPanel.SuspendLayout();
            this.GangBuilderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.iconPictureBox1);
            this.HeaderPanel.Controls.Add(this.guna2HtmlLabel1);
            this.HeaderPanel.Controls.Add(this.btnMinimize);
            this.HeaderPanel.Controls.Add(this.btnMaximize);
            this.HeaderPanel.Controls.Add(this.btnExit);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.ShadowDecoration.Parent = this.HeaderPanel;
            this.HeaderPanel.Size = new System.Drawing.Size(1330, 50);
            this.HeaderPanel.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconSize = 44;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(47, 44);
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(539, 9);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(234, 30);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "iFive - Administrator Tool";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(1245, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(1277, 11);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.TabIndex = 6;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(1307, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 5;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
            // 
            // GlobalPanel
            // 
            this.GlobalPanel.Controls.Add(this.ContentPanel);
            this.GlobalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalPanel.Location = new System.Drawing.Point(0, 50);
            this.GlobalPanel.Name = "GlobalPanel";
            this.GlobalPanel.ShadowDecoration.Parent = this.GlobalPanel;
            this.GlobalPanel.Size = new System.Drawing.Size(1330, 758);
            this.GlobalPanel.TabIndex = 1;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.secondLabel);
            this.ContentPanel.Controls.Add(this.percent);
            this.ContentPanel.Controls.Add(this.firstLabel);
            this.ContentPanel.Controls.Add(this.installationBar);
            this.ContentPanel.Controls.Add(this.PanelForButtonPanel);
            this.ContentPanel.Controls.Add(this.PlayerManagementPanel);
            this.ContentPanel.Controls.Add(this.GangBuilderPanel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.ShadowDecoration.Parent = this.ContentPanel;
            this.ContentPanel.Size = new System.Drawing.Size(1330, 758);
            this.ContentPanel.TabIndex = 4;
            // 
            // secondLabel
            // 
            this.secondLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLabel.ForeColor = System.Drawing.Color.LightPink;
            this.secondLabel.Location = new System.Drawing.Point(706, 689);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(142, 32);
            this.secondLabel.TabIndex = 9;
            this.secondLabel.Text = "complete";
            // 
            // percent
            // 
            this.percent.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.percent.Location = new System.Drawing.Point(648, 689);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(70, 32);
            this.percent.TabIndex = 8;
            this.percent.Text = "0%";
            // 
            // firstLabel
            // 
            this.firstLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLabel.ForeColor = System.Drawing.Color.LightPink;
            this.firstLabel.Location = new System.Drawing.Point(512, 689);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(142, 32);
            this.firstLabel.TabIndex = 7;
            this.firstLabel.Text = "Installation : ";
            // 
            // installationBar
            // 
            this.installationBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.installationBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.installationBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.installationBar.Location = new System.Drawing.Point(0, 738);
            this.installationBar.Name = "installationBar";
            this.installationBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.installationBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.installationBar.ShadowDecoration.Parent = this.installationBar;
            this.installationBar.Size = new System.Drawing.Size(1330, 20);
            this.installationBar.TabIndex = 6;
            this.installationBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // PanelForButtonPanel
            // 
            this.PanelForButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.PanelForButtonPanel.Controls.Add(this.ButtonPanel);
            this.PanelForButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelForButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.PanelForButtonPanel.Name = "PanelForButtonPanel";
            this.PanelForButtonPanel.ShadowDecoration.Parent = this.PanelForButtonPanel;
            this.PanelForButtonPanel.Size = new System.Drawing.Size(1330, 50);
            this.PanelForButtonPanel.TabIndex = 4;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.SettingsBtn);
            this.ButtonPanel.Controls.Add(this.HomeBtn);
            this.ButtonPanel.Location = new System.Drawing.Point(332, 0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.ShadowDecoration.Parent = this.ButtonPanel;
            this.ButtonPanel.Size = new System.Drawing.Size(707, 50);
            this.ButtonPanel.TabIndex = 0;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Animated = true;
            this.SettingsBtn.BorderColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.BorderThickness = 3;
            this.SettingsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.SettingsBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.SettingsBtn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.SettingsBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.SettingsBtn.CheckedState.Parent = this.SettingsBtn;
            this.SettingsBtn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.CustomImages.Parent = this.SettingsBtn;
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsBtn.FillColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.SettingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.SettingsBtn.HoverState.Parent = this.SettingsBtn;
            this.SettingsBtn.Location = new System.Drawing.Point(304, 0);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.ShadowDecoration.Parent = this.SettingsBtn;
            this.SettingsBtn.Size = new System.Drawing.Size(304, 50);
            this.SettingsBtn.TabIndex = 1;
            this.SettingsBtn.Text = "Settings";
            // 
            // HomeBtn
            // 
            this.HomeBtn.Animated = true;
            this.HomeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.HomeBtn.BorderThickness = 3;
            this.HomeBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.HomeBtn.Checked = true;
            this.HomeBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.HomeBtn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.HomeBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.HomeBtn.CheckedState.Parent = this.HomeBtn;
            this.HomeBtn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.HomeBtn.CustomImages.Parent = this.HomeBtn;
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.HomeBtn.FillColor = System.Drawing.Color.Transparent;
            this.HomeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.HomeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.HomeBtn.HoverState.Parent = this.HomeBtn;
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.ShadowDecoration.Parent = this.HomeBtn;
            this.HomeBtn.Size = new System.Drawing.Size(304, 50);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Home";
            // 
            // PlayerManagementPanel
            // 
            this.PlayerManagementPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.PlayerManagementPanel.Controls.Add(this.PlayerManagementBtn);
            this.PlayerManagementPanel.Controls.Add(this.PlayerManagementDesc);
            this.PlayerManagementPanel.Controls.Add(this.PlayerManagementLabel);
            this.PlayerManagementPanel.Controls.Add(this.guna2ImageButton2);
            this.PlayerManagementPanel.Location = new System.Drawing.Point(714, 154);
            this.PlayerManagementPanel.Name = "PlayerManagementPanel";
            this.PlayerManagementPanel.ShadowDecoration.Parent = this.PlayerManagementPanel;
            this.PlayerManagementPanel.Size = new System.Drawing.Size(321, 306);
            this.PlayerManagementPanel.TabIndex = 1;
            // 
            // PlayerManagementBtn
            // 
            this.PlayerManagementBtn.Animated = true;
            this.PlayerManagementBtn.AutoRoundedCorners = true;
            this.PlayerManagementBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlayerManagementBtn.BorderRadius = 21;
            this.PlayerManagementBtn.CheckedState.Parent = this.PlayerManagementBtn;
            this.PlayerManagementBtn.CustomImages.Parent = this.PlayerManagementBtn;
            this.PlayerManagementBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.PlayerManagementBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.PlayerManagementBtn.ForeColor = System.Drawing.Color.White;
            this.PlayerManagementBtn.HoverState.Parent = this.PlayerManagementBtn;
            this.PlayerManagementBtn.Location = new System.Drawing.Point(71, 229);
            this.PlayerManagementBtn.Name = "PlayerManagementBtn";
            this.PlayerManagementBtn.ShadowDecoration.Parent = this.PlayerManagementBtn;
            this.PlayerManagementBtn.Size = new System.Drawing.Size(180, 45);
            this.PlayerManagementBtn.TabIndex = 1;
            this.PlayerManagementBtn.Text = "Run";
            // 
            // PlayerManagementDesc
            // 
            this.PlayerManagementDesc.AutoSize = false;
            this.PlayerManagementDesc.BackColor = System.Drawing.Color.Transparent;
            this.PlayerManagementDesc.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerManagementDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(108)))), ((int)(((byte)(127)))));
            this.PlayerManagementDesc.Location = new System.Drawing.Point(9, 137);
            this.PlayerManagementDesc.Name = "PlayerManagementDesc";
            this.PlayerManagementDesc.Size = new System.Drawing.Size(309, 74);
            this.PlayerManagementDesc.TabIndex = 2;
            this.PlayerManagementDesc.Text = "Wipe , Check player data and more in a few minutes";
            this.PlayerManagementDesc.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerManagementLabel
            // 
            this.PlayerManagementLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerManagementLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerManagementLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.PlayerManagementLabel.Location = new System.Drawing.Point(55, 88);
            this.PlayerManagementLabel.Name = "PlayerManagementLabel";
            this.PlayerManagementLabel.Size = new System.Drawing.Size(210, 33);
            this.PlayerManagementLabel.TabIndex = 1;
            this.PlayerManagementLabel.Text = "Player Management";
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.Location = new System.Drawing.Point(125, 11);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(73, 71);
            this.guna2ImageButton2.TabIndex = 0;
            // 
            // GangBuilderPanel
            // 
            this.GangBuilderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.GangBuilderPanel.Controls.Add(this.saveBtn);
            this.GangBuilderPanel.Controls.Add(this.GangBuilderBtn);
            this.GangBuilderPanel.Controls.Add(this.GangBuilderDesc);
            this.GangBuilderPanel.Controls.Add(this.GangBuilderLabel);
            this.GangBuilderPanel.Controls.Add(this.guna2ImageButton1);
            this.GangBuilderPanel.Location = new System.Drawing.Point(315, 154);
            this.GangBuilderPanel.Name = "GangBuilderPanel";
            this.GangBuilderPanel.ShadowDecoration.Parent = this.GangBuilderPanel;
            this.GangBuilderPanel.Size = new System.Drawing.Size(321, 306);
            this.GangBuilderPanel.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Animated = true;
            this.saveBtn.AutoRoundedCorners = true;
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BorderRadius = 21;
            this.saveBtn.CheckedState.Parent = this.saveBtn;
            this.saveBtn.CustomImages.Parent = this.saveBtn;
            this.saveBtn.Enabled = false;
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.HoverState.Parent = this.saveBtn;
            this.saveBtn.Location = new System.Drawing.Point(189, 229);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.ShadowDecoration.Parent = this.saveBtn;
            this.saveBtn.Size = new System.Drawing.Size(123, 45);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // GangBuilderBtn
            // 
            this.GangBuilderBtn.Animated = true;
            this.GangBuilderBtn.AutoRoundedCorners = true;
            this.GangBuilderBtn.BackColor = System.Drawing.Color.Transparent;
            this.GangBuilderBtn.BorderRadius = 21;
            this.GangBuilderBtn.CheckedState.Parent = this.GangBuilderBtn;
            this.GangBuilderBtn.CustomImages.Parent = this.GangBuilderBtn;
            this.GangBuilderBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(83)))), ((int)(((byte)(192)))));
            this.GangBuilderBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.GangBuilderBtn.ForeColor = System.Drawing.Color.White;
            this.GangBuilderBtn.HoverState.Parent = this.GangBuilderBtn;
            this.GangBuilderBtn.Location = new System.Drawing.Point(3, 229);
            this.GangBuilderBtn.Name = "GangBuilderBtn";
            this.GangBuilderBtn.ShadowDecoration.Parent = this.GangBuilderBtn;
            this.GangBuilderBtn.Size = new System.Drawing.Size(180, 45);
            this.GangBuilderBtn.TabIndex = 1;
            this.GangBuilderBtn.Text = "Run";
            this.GangBuilderBtn.Click += new System.EventHandler(this.GangBuilderBtn_Click);
            // 
            // GangBuilderDesc
            // 
            this.GangBuilderDesc.AutoSize = false;
            this.GangBuilderDesc.BackColor = System.Drawing.Color.Transparent;
            this.GangBuilderDesc.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GangBuilderDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(108)))), ((int)(((byte)(127)))));
            this.GangBuilderDesc.Location = new System.Drawing.Point(3, 149);
            this.GangBuilderDesc.Name = "GangBuilderDesc";
            this.GangBuilderDesc.Size = new System.Drawing.Size(309, 74);
            this.GangBuilderDesc.TabIndex = 2;
            this.GangBuilderDesc.Text = "\r\nCreate an organization in a few clicks";
            this.GangBuilderDesc.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GangBuilderLabel
            // 
            this.GangBuilderLabel.BackColor = System.Drawing.Color.Transparent;
            this.GangBuilderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GangBuilderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.GangBuilderLabel.Location = new System.Drawing.Point(93, 88);
            this.GangBuilderLabel.Name = "GangBuilderLabel";
            this.GangBuilderLabel.Size = new System.Drawing.Size(138, 33);
            this.GangBuilderLabel.TabIndex = 1;
            this.GangBuilderLabel.Text = "Gang Builder";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(125, 11);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(73, 71);
            this.guna2ImageButton1.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.HeaderPanel;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1330, 808);
            this.Controls.Add(this.GlobalPanel);
            this.Controls.Add(this.HeaderPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.GlobalPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.PanelForButtonPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.PlayerManagementPanel.ResumeLayout(false);
            this.PlayerManagementPanel.PerformLayout();
            this.GangBuilderPanel.ResumeLayout(false);
            this.GangBuilderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel HeaderPanel;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Panel GlobalPanel;
        private Guna.UI2.WinForms.Guna2Panel ContentPanel;
        private Guna.UI2.WinForms.Guna2Panel PlayerManagementPanel;
        private Guna.UI2.WinForms.Guna2Button PlayerManagementBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel PlayerManagementDesc;
        private Guna.UI2.WinForms.Guna2HtmlLabel PlayerManagementLabel;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2Panel GangBuilderPanel;
        private Guna.UI2.WinForms.Guna2Button GangBuilderBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel GangBuilderDesc;
        private Guna.UI2.WinForms.Guna2HtmlLabel GangBuilderLabel;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel PanelForButtonPanel;
        private Guna.UI2.WinForms.Guna2Panel ButtonPanel;
        private Guna.UI2.WinForms.Guna2Button HomeBtn;
        private Guna.UI2.WinForms.Guna2Button SettingsBtn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2ProgressBar installationBar;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Timer timer1;
    }
}