namespace GangBuilderV2
{
    partial class FormOrgDetail
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
            this.OrgDetailNameBox = new System.Windows.Forms.TextBox();
            this.NamePicture = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OrgDetailGradeLabel = new FontAwesome.Sharp.IconPictureBox();
            this.OrgDetailGradeBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NamePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgDetailGradeLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // OrgDetailNameBox
            // 
            this.OrgDetailNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrgDetailNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.OrgDetailNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrgDetailNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrgDetailNameBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.OrgDetailNameBox.Location = new System.Drawing.Point(143, 136);
            this.OrgDetailNameBox.Name = "OrgDetailNameBox";
            this.OrgDetailNameBox.Size = new System.Drawing.Size(485, 38);
            this.OrgDetailNameBox.TabIndex = 2;
            this.OrgDetailNameBox.Text = "Name";
            this.OrgDetailNameBox.TextChanged += new System.EventHandler(this.OrgDetailNameBox_TextChanged);
            this.OrgDetailNameBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Clear);
            // 
            // NamePicture
            // 
            this.NamePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NamePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.NamePicture.ForeColor = System.Drawing.Color.Gainsboro;
            this.NamePicture.IconChar = FontAwesome.Sharp.IconChar.UserNinja;
            this.NamePicture.IconColor = System.Drawing.Color.Gainsboro;
            this.NamePicture.IconSize = 45;
            this.NamePicture.Location = new System.Drawing.Point(87, 134);
            this.NamePicture.Name = "NamePicture";
            this.NamePicture.Size = new System.Drawing.Size(45, 45);
            this.NamePicture.TabIndex = 3;
            this.NamePicture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(87, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 5);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(87, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 5);
            this.panel2.TabIndex = 7;
            // 
            // OrgDetailGradeLabel
            // 
            this.OrgDetailGradeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrgDetailGradeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.OrgDetailGradeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.OrgDetailGradeLabel.IconChar = FontAwesome.Sharp.IconChar.YinYang;
            this.OrgDetailGradeLabel.IconColor = System.Drawing.Color.Gainsboro;
            this.OrgDetailGradeLabel.IconSize = 45;
            this.OrgDetailGradeLabel.Location = new System.Drawing.Point(87, 235);
            this.OrgDetailGradeLabel.Name = "OrgDetailGradeLabel";
            this.OrgDetailGradeLabel.Size = new System.Drawing.Size(45, 45);
            this.OrgDetailGradeLabel.TabIndex = 6;
            this.OrgDetailGradeLabel.TabStop = false;
            // 
            // OrgDetailGradeBox
            // 
            this.OrgDetailGradeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrgDetailGradeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.OrgDetailGradeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrgDetailGradeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrgDetailGradeBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.OrgDetailGradeBox.Location = new System.Drawing.Point(143, 237);
            this.OrgDetailGradeBox.Name = "OrgDetailGradeBox";
            this.OrgDetailGradeBox.Size = new System.Drawing.Size(485, 38);
            this.OrgDetailGradeBox.TabIndex = 5;
            this.OrgDetailGradeBox.Text = "Grades";
            this.OrgDetailGradeBox.TextChanged += new System.EventHandler(this.OrgDetailGradeBox_TextChanged);
            this.OrgDetailGradeBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Clear);
            // 
            // FormOrgDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.OrgDetailGradeLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OrgDetailGradeBox);
            this.Controls.Add(this.NamePicture);
            this.Controls.Add(this.OrgDetailNameBox);
            this.Name = "FormOrgDetail";
            this.Text = "Org Detail";
            ((System.ComponentModel.ISupportInitialize)(this.NamePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgDetailGradeLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox OrgDetailNameBox;
        private FontAwesome.Sharp.IconPictureBox NamePicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox OrgDetailGradeLabel;
        private System.Windows.Forms.TextBox OrgDetailGradeBox;
    }
}