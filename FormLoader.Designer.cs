namespace GangBuilderV2
{
    partial class FormLoader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoader));
            this.GangBuilderPictureValidate = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tBoxLoader = new System.Windows.Forms.Label();
            this.btnMinimize2 = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GangBuilderPictureValidate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // GangBuilderPictureValidate
            // 
            this.GangBuilderPictureValidate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GangBuilderPictureValidate.Image = ((System.Drawing.Image)(resources.GetObject("GangBuilderPictureValidate.Image")));
            this.GangBuilderPictureValidate.Location = new System.Drawing.Point(149, 300);
            this.GangBuilderPictureValidate.Name = "GangBuilderPictureValidate";
            this.GangBuilderPictureValidate.Size = new System.Drawing.Size(1082, 272);
            this.GangBuilderPictureValidate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GangBuilderPictureValidate.TabIndex = 10;
            this.GangBuilderPictureValidate.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 828);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1358, 22);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // panelSlide
            // 
            this.panelSlide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSlide.BackColor = System.Drawing.Color.Gold;
            this.panelSlide.Location = new System.Drawing.Point(0, 828);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(23, 22);
            this.panelSlide.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tBoxLoader
            // 
            this.tBoxLoader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxLoader.AutoSize = true;
            this.tBoxLoader.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxLoader.ForeColor = System.Drawing.Color.MediumPurple;
            this.tBoxLoader.Location = new System.Drawing.Point(572, 726);
            this.tBoxLoader.Name = "tBoxLoader";
            this.tBoxLoader.Size = new System.Drawing.Size(0, 46);
            this.tBoxLoader.TabIndex = 15;
            // 
            // btnMinimize2
            // 
            this.btnMinimize2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMinimize2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize2.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize2.IconSize = 20;
            this.btnMinimize2.Location = new System.Drawing.Point(1269, 10);
            this.btnMinimize2.Name = "btnMinimize2";
            this.btnMinimize2.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize2.TabIndex = 18;
            this.btnMinimize2.TabStop = false;
            this.btnMinimize2.Click += new System.EventHandler(this.btnMinimize2_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(1301, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.TabIndex = 17;
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
            this.btnExit.Location = new System.Drawing.Point(1331, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 16;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimize2);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1358, 42);
            this.panelTitleBar.TabIndex = 19;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // FormLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1358, 846);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.tBoxLoader);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.GangBuilderPictureValidate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLoader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoader";
            this.Load += new System.EventHandler(this.FormLoader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GangBuilderPictureValidate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnMinimize2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox GangBuilderPictureValidate;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label tBoxLoader;
        private System.Windows.Forms.Timer timer1;

        #endregion
    }
}