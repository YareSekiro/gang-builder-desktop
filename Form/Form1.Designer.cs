namespace GangBuilderV2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GangBuilderPanel = new System.Windows.Forms.Panel();
            this.version = new System.Windows.Forms.Label();
            this.BlipsBtn = new FontAwesome.Sharp.IconButton();
            this.BossBtn = new FontAwesome.Sharp.IconButton();
            this.VPanel = new System.Windows.Forms.Panel();
            this.VData = new FontAwesome.Sharp.IconButton();
            this.VDelete = new FontAwesome.Sharp.IconButton();
            this.VSpawn = new FontAwesome.Sharp.IconButton();
            this.VMenu = new FontAwesome.Sharp.IconButton();
            this.VehicleBtn = new FontAwesome.Sharp.IconButton();
            this.CloakroomBtn = new FontAwesome.Sharp.IconButton();
            this.ArmoryBtn = new FontAwesome.Sharp.IconButton();
            this.OrgExtraDetailBtn = new FontAwesome.Sharp.IconButton();
            this.GangBuilderLogoPanel = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.homeChildLabel = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Made = new System.Windows.Forms.Label();
            this.labelLoader = new System.Windows.Forms.Label();
            this.panelGBLoading = new System.Windows.Forms.Panel();
            this.panelContainLoading = new System.Windows.Forms.FlowLayoutPanel();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.GangBuilderPanel.SuspendLayout();
            this.VPanel.SuspendLayout();
            this.GangBuilderLogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // GangBuilderPanel
            // 
            this.GangBuilderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.GangBuilderPanel.Controls.Add(this.version);
            this.GangBuilderPanel.Controls.Add(this.BlipsBtn);
            this.GangBuilderPanel.Controls.Add(this.BossBtn);
            this.GangBuilderPanel.Controls.Add(this.VPanel);
            this.GangBuilderPanel.Controls.Add(this.VehicleBtn);
            this.GangBuilderPanel.Controls.Add(this.CloakroomBtn);
            this.GangBuilderPanel.Controls.Add(this.ArmoryBtn);
            this.GangBuilderPanel.Controls.Add(this.OrgExtraDetailBtn);
            this.GangBuilderPanel.Controls.Add(this.GangBuilderLogoPanel);
            this.GangBuilderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.GangBuilderPanel.Location = new System.Drawing.Point(0, 0);
            this.GangBuilderPanel.Name = "GangBuilderPanel";
            this.GangBuilderPanel.Size = new System.Drawing.Size(280, 830);
            this.GangBuilderPanel.TabIndex = 0;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Arrakis", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.Color.Red;
            this.version.Location = new System.Drawing.Point(34, 779);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(227, 42);
            this.version.TabIndex = 16;
            this.version.Text = "V3.0-ALPHA";
            // 
            // BlipsBtn
            // 
            this.BlipsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlipsBtn.FlatAppearance.BorderSize = 0;
            this.BlipsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlipsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BlipsBtn.Font = new System.Drawing.Font("Arrakis", 20F);
            this.BlipsBtn.ForeColor = System.Drawing.Color.LightPink;
            this.BlipsBtn.IconChar = FontAwesome.Sharp.IconChar.Marker;
            this.BlipsBtn.IconColor = System.Drawing.Color.LightPink;
            this.BlipsBtn.IconSize = 46;
            this.BlipsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BlipsBtn.Location = new System.Drawing.Point(0, 685);
            this.BlipsBtn.Name = "BlipsBtn";
            this.BlipsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.BlipsBtn.Rotation = 0D;
            this.BlipsBtn.Size = new System.Drawing.Size(280, 60);
            this.BlipsBtn.TabIndex = 13;
            this.BlipsBtn.Text = "Blips";
            this.BlipsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BlipsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BlipsBtn.UseVisualStyleBackColor = true;
            this.BlipsBtn.Click += new System.EventHandler(this.BlipsBtn_Click);
            // 
            // BossBtn
            // 
            this.BossBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BossBtn.FlatAppearance.BorderSize = 0;
            this.BossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BossBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BossBtn.Font = new System.Drawing.Font("Arrakis", 20F);
            this.BossBtn.ForeColor = System.Drawing.Color.LightPink;
            this.BossBtn.IconChar = FontAwesome.Sharp.IconChar.Dna;
            this.BossBtn.IconColor = System.Drawing.Color.LightPink;
            this.BossBtn.IconSize = 46;
            this.BossBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BossBtn.Location = new System.Drawing.Point(0, 625);
            this.BossBtn.Name = "BossBtn";
            this.BossBtn.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.BossBtn.Rotation = 0D;
            this.BossBtn.Size = new System.Drawing.Size(280, 60);
            this.BossBtn.TabIndex = 12;
            this.BossBtn.Text = "Boss";
            this.BossBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BossBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BossBtn.UseVisualStyleBackColor = true;
            this.BossBtn.Click += new System.EventHandler(this.BossBtn_Click);
            // 
            // VPanel
            // 
            this.VPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.VPanel.Controls.Add(this.VData);
            this.VPanel.Controls.Add(this.VDelete);
            this.VPanel.Controls.Add(this.VSpawn);
            this.VPanel.Controls.Add(this.VMenu);
            this.VPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.VPanel.Location = new System.Drawing.Point(0, 385);
            this.VPanel.Name = "VPanel";
            this.VPanel.Size = new System.Drawing.Size(280, 240);
            this.VPanel.TabIndex = 11;
            // 
            // VData
            // 
            this.VData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.VData.Dock = System.Windows.Forms.DockStyle.Top;
            this.VData.FlatAppearance.BorderSize = 0;
            this.VData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VData.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.VData.Font = new System.Drawing.Font("Arrakis", 15F);
            this.VData.ForeColor = System.Drawing.Color.Gold;
            this.VData.IconChar = FontAwesome.Sharp.IconChar.StickerMule;
            this.VData.IconColor = System.Drawing.Color.Gold;
            this.VData.IconSize = 46;
            this.VData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VData.Location = new System.Drawing.Point(0, 180);
            this.VData.Name = "VData";
            this.VData.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.VData.Rotation = 0D;
            this.VData.Size = new System.Drawing.Size(280, 60);
            this.VData.TabIndex = 8;
            this.VData.Text = "Vehicle data";
            this.VData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VData.UseVisualStyleBackColor = false;
            this.VData.Click += new System.EventHandler(this.VData_Click);
            // 
            // VDelete
            // 
            this.VDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.VDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.VDelete.FlatAppearance.BorderSize = 0;
            this.VDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.VDelete.Font = new System.Drawing.Font("Arrakis", 15F);
            this.VDelete.ForeColor = System.Drawing.Color.Gold;
            this.VDelete.IconChar = FontAwesome.Sharp.IconChar.StickerMule;
            this.VDelete.IconColor = System.Drawing.Color.Gold;
            this.VDelete.IconSize = 46;
            this.VDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VDelete.Location = new System.Drawing.Point(0, 120);
            this.VDelete.Name = "VDelete";
            this.VDelete.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.VDelete.Rotation = 0D;
            this.VDelete.Size = new System.Drawing.Size(280, 60);
            this.VDelete.TabIndex = 7;
            this.VDelete.Text = "Delete point";
            this.VDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VDelete.UseVisualStyleBackColor = false;
            this.VDelete.Click += new System.EventHandler(this.VDelete_Click);
            // 
            // VSpawn
            // 
            this.VSpawn.Dock = System.Windows.Forms.DockStyle.Top;
            this.VSpawn.FlatAppearance.BorderSize = 0;
            this.VSpawn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VSpawn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.VSpawn.Font = new System.Drawing.Font("Arrakis", 15F);
            this.VSpawn.ForeColor = System.Drawing.Color.Gold;
            this.VSpawn.IconChar = FontAwesome.Sharp.IconChar.StickerMule;
            this.VSpawn.IconColor = System.Drawing.Color.Gold;
            this.VSpawn.IconSize = 46;
            this.VSpawn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VSpawn.Location = new System.Drawing.Point(0, 60);
            this.VSpawn.Name = "VSpawn";
            this.VSpawn.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.VSpawn.Rotation = 0D;
            this.VSpawn.Size = new System.Drawing.Size(280, 60);
            this.VSpawn.TabIndex = 6;
            this.VSpawn.Text = "Spawn point";
            this.VSpawn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VSpawn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VSpawn.UseVisualStyleBackColor = true;
            this.VSpawn.Click += new System.EventHandler(this.VSpawn_Click);
            // 
            // VMenu
            // 
            this.VMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.VMenu.FlatAppearance.BorderSize = 0;
            this.VMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.VMenu.Font = new System.Drawing.Font("Arrakis", 15F);
            this.VMenu.ForeColor = System.Drawing.Color.Gold;
            this.VMenu.IconChar = FontAwesome.Sharp.IconChar.StickerMule;
            this.VMenu.IconColor = System.Drawing.Color.Gold;
            this.VMenu.IconSize = 46;
            this.VMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VMenu.Location = new System.Drawing.Point(0, 0);
            this.VMenu.Name = "VMenu";
            this.VMenu.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.VMenu.Rotation = 0D;
            this.VMenu.Size = new System.Drawing.Size(280, 60);
            this.VMenu.TabIndex = 5;
            this.VMenu.Text = "Menu";
            this.VMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VMenu.UseVisualStyleBackColor = true;
            this.VMenu.Click += new System.EventHandler(this.VMenu_Click);
            // 
            // VehicleBtn
            // 
            this.VehicleBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.VehicleBtn.FlatAppearance.BorderSize = 0;
            this.VehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VehicleBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.VehicleBtn.Font = new System.Drawing.Font("Arrakis", 20F);
            this.VehicleBtn.ForeColor = System.Drawing.Color.LightPink;
            this.VehicleBtn.IconChar = FontAwesome.Sharp.IconChar.StickerMule;
            this.VehicleBtn.IconColor = System.Drawing.Color.LightPink;
            this.VehicleBtn.IconSize = 46;
            this.VehicleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VehicleBtn.Location = new System.Drawing.Point(0, 325);
            this.VehicleBtn.Name = "VehicleBtn";
            this.VehicleBtn.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.VehicleBtn.Rotation = 0D;
            this.VehicleBtn.Size = new System.Drawing.Size(280, 60);
            this.VehicleBtn.TabIndex = 4;
            this.VehicleBtn.Text = "Vehicle";
            this.VehicleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VehicleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VehicleBtn.UseVisualStyleBackColor = true;
            this.VehicleBtn.Click += new System.EventHandler(this.VehicleBtn_Click);
            // 
            // CloakroomBtn
            // 
            this.CloakroomBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloakroomBtn.FlatAppearance.BorderSize = 0;
            this.CloakroomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloakroomBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CloakroomBtn.Font = new System.Drawing.Font("Arrakis", 20F);
            this.CloakroomBtn.ForeColor = System.Drawing.Color.LightPink;
            this.CloakroomBtn.IconChar = FontAwesome.Sharp.IconChar.Smoking;
            this.CloakroomBtn.IconColor = System.Drawing.Color.LightPink;
            this.CloakroomBtn.IconSize = 46;
            this.CloakroomBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloakroomBtn.Location = new System.Drawing.Point(0, 265);
            this.CloakroomBtn.Name = "CloakroomBtn";
            this.CloakroomBtn.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.CloakroomBtn.Rotation = 0D;
            this.CloakroomBtn.Size = new System.Drawing.Size(280, 60);
            this.CloakroomBtn.TabIndex = 3;
            this.CloakroomBtn.Text = "Cloakroom";
            this.CloakroomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloakroomBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CloakroomBtn.UseVisualStyleBackColor = true;
            this.CloakroomBtn.Click += new System.EventHandler(this.CloakroomBtn_Click);
            // 
            // ArmoryBtn
            // 
            this.ArmoryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ArmoryBtn.FlatAppearance.BorderSize = 0;
            this.ArmoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArmoryBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ArmoryBtn.Font = new System.Drawing.Font("Arrakis", 20F);
            this.ArmoryBtn.ForeColor = System.Drawing.Color.LightPink;
            this.ArmoryBtn.IconChar = FontAwesome.Sharp.IconChar.Binoculars;
            this.ArmoryBtn.IconColor = System.Drawing.Color.LightPink;
            this.ArmoryBtn.IconSize = 46;
            this.ArmoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ArmoryBtn.Location = new System.Drawing.Point(0, 205);
            this.ArmoryBtn.Name = "ArmoryBtn";
            this.ArmoryBtn.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.ArmoryBtn.Rotation = 0D;
            this.ArmoryBtn.Size = new System.Drawing.Size(280, 60);
            this.ArmoryBtn.TabIndex = 2;
            this.ArmoryBtn.Text = "Armory";
            this.ArmoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ArmoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ArmoryBtn.UseVisualStyleBackColor = true;
            this.ArmoryBtn.Click += new System.EventHandler(this.ArmoryBtn_Click);
            // 
            // OrgExtraDetailBtn
            // 
            this.OrgExtraDetailBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrgExtraDetailBtn.FlatAppearance.BorderSize = 0;
            this.OrgExtraDetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrgExtraDetailBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.OrgExtraDetailBtn.Font = new System.Drawing.Font("Arrakis", 20F);
            this.OrgExtraDetailBtn.ForeColor = System.Drawing.Color.LightPink;
            this.OrgExtraDetailBtn.IconChar = FontAwesome.Sharp.IconChar.UserNinja;
            this.OrgExtraDetailBtn.IconColor = System.Drawing.Color.LightPink;
            this.OrgExtraDetailBtn.IconSize = 46;
            this.OrgExtraDetailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrgExtraDetailBtn.Location = new System.Drawing.Point(0, 145);
            this.OrgExtraDetailBtn.Name = "OrgExtraDetailBtn";
            this.OrgExtraDetailBtn.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.OrgExtraDetailBtn.Rotation = 0D;
            this.OrgExtraDetailBtn.Size = new System.Drawing.Size(280, 60);
            this.OrgExtraDetailBtn.TabIndex = 1;
            this.OrgExtraDetailBtn.Text = "Name";
            this.OrgExtraDetailBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrgExtraDetailBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OrgExtraDetailBtn.UseVisualStyleBackColor = true;
            this.OrgExtraDetailBtn.Click += new System.EventHandler(this.OrgExtraDetailBtn_Click);
            // 
            // GangBuilderLogoPanel
            // 
            this.GangBuilderLogoPanel.Controls.Add(this.btnHome);
            this.GangBuilderLogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GangBuilderLogoPanel.Location = new System.Drawing.Point(0, 0);
            this.GangBuilderLogoPanel.Name = "GangBuilderLogoPanel";
            this.GangBuilderLogoPanel.Size = new System.Drawing.Size(280, 145);
            this.GangBuilderLogoPanel.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(26, 19);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(190, 99);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.homeChildLabel);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(280, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1078, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(988, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(1020, 7);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(1050, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // homeChildLabel
            // 
            this.homeChildLabel.AutoSize = true;
            this.homeChildLabel.Font = new System.Drawing.Font("INFECTED", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeChildLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.homeChildLabel.Location = new System.Drawing.Point(77, 21);
            this.homeChildLabel.Name = "homeChildLabel";
            this.homeChildLabel.Size = new System.Drawing.Size(91, 48);
            this.homeChildLabel.TabIndex = 1;
            this.homeChildLabel.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconSize = 50;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(19, 19);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(52, 50);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(280, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1078, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.panelDesktop.Controls.Add(this.saveBtn);
            this.panelDesktop.Controls.Add(this.Made);
            this.panelDesktop.Controls.Add(this.labelLoader);
            this.panelDesktop.Controls.Add(this.panelGBLoading);
            this.panelDesktop.Controls.Add(this.panelContainLoading);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(280, 89);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1078, 741);
            this.panelDesktop.TabIndex = 3;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.White;
            this.saveBtn.CheckedState.Parent = this.saveBtn;
            this.saveBtn.CustomImages.Parent = this.saveBtn;
            this.saveBtn.FillColor = System.Drawing.Color.White;
            this.saveBtn.Font = new System.Drawing.Font("Arrakis", 25F);
            this.saveBtn.ForeColor = System.Drawing.Color.LightPink;
            this.saveBtn.HoverState.Parent = this.saveBtn;
            this.saveBtn.Location = new System.Drawing.Point(450, 560);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.ShadowDecoration.Parent = this.saveBtn;
            this.saveBtn.Size = new System.Drawing.Size(206, 60);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.GangBuilderPictureValidate_Click);
            // 
            // Made
            // 
            this.Made.AutoSize = true;
            this.Made.Font = new System.Drawing.Font("Arrakis", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Made.ForeColor = System.Drawing.Color.LightPink;
            this.Made.Location = new System.Drawing.Point(86, 84);
            this.Made.Name = "Made";
            this.Made.Size = new System.Drawing.Size(936, 452);
            this.Made.TabIndex = 15;
            this.Made.Text = "IFIVE GANGBUILDER\r\n     MADE BY MUS\r\n          AKA \r\n      JUN#6666";
            // 
            // labelLoader
            // 
            this.labelLoader.AutoSize = true;
            this.labelLoader.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoader.ForeColor = System.Drawing.Color.BlueViolet;
            this.labelLoader.Location = new System.Drawing.Point(471, 664);
            this.labelLoader.Name = "labelLoader";
            this.labelLoader.Size = new System.Drawing.Size(0, 32);
            this.labelLoader.TabIndex = 14;
            // 
            // panelGBLoading
            // 
            this.panelGBLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelGBLoading.BackColor = System.Drawing.Color.Gold;
            this.panelGBLoading.Location = new System.Drawing.Point(3, 717);
            this.panelGBLoading.Name = "panelGBLoading";
            this.panelGBLoading.Size = new System.Drawing.Size(10, 24);
            this.panelGBLoading.TabIndex = 12;
            // 
            // panelContainLoading
            // 
            this.panelContainLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContainLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.panelContainLoading.Location = new System.Drawing.Point(0, 717);
            this.panelContainLoading.Name = "panelContainLoading";
            this.panelContainLoading.Size = new System.Drawing.Size(1078, 24);
            this.panelContainLoading.TabIndex = 11;
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 10;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 830);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.GangBuilderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GangBuilder";
            this.TopMost = true;
            this.GangBuilderPanel.ResumeLayout(false);
            this.GangBuilderPanel.PerformLayout();
            this.VPanel.ResumeLayout(false);
            this.GangBuilderLogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GangBuilderPanel;
        private System.Windows.Forms.Panel GangBuilderLogoPanel;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label homeChildLabel;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconButton VehicleBtn;
        private FontAwesome.Sharp.IconButton CloakroomBtn;
        private FontAwesome.Sharp.IconButton ArmoryBtn;
        private FontAwesome.Sharp.IconButton OrgExtraDetailBtn;
        private System.Windows.Forms.Panel panelGBLoading;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.FlowLayoutPanel panelContainLoading;
        private System.Windows.Forms.Label labelLoader;
        private FontAwesome.Sharp.IconButton BlipsBtn;
        private FontAwesome.Sharp.IconButton BossBtn;
        private System.Windows.Forms.Panel VPanel;
        private FontAwesome.Sharp.IconButton VData;
        private FontAwesome.Sharp.IconButton VDelete;
        private FontAwesome.Sharp.IconButton VSpawn;
        private FontAwesome.Sharp.IconButton VMenu;
        private System.Windows.Forms.Label Made;
        private System.Windows.Forms.Label version;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
    }
}

