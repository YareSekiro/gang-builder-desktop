namespace GangBuilderV2
{
    partial class FormTransfert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransfert));
            this.panel1 = new System.Windows.Forms.Panel();
            this.folderNameBox = new System.Windows.Forms.TextBox();
            this.folderName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Location = new System.Drawing.Point(100, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 5);
            this.panel1.TabIndex = 7;
            // 
            // folderNameBox
            // 
            this.folderNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.folderNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.folderNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.folderNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderNameBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.folderNameBox.Location = new System.Drawing.Point(305, 204);
            this.folderNameBox.Name = "folderNameBox";
            this.folderNameBox.Size = new System.Drawing.Size(395, 38);
            this.folderNameBox.TabIndex = 5;
            this.folderNameBox.TextChanged += new System.EventHandler(this.folderNameBox_TextChanged);
            // 
            // folderName
            // 
            this.folderName.AutoSize = true;
            this.folderName.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderName.ForeColor = System.Drawing.Color.Gainsboro;
            this.folderName.Location = new System.Drawing.Point(93, 203);
            this.folderName.Name = "folderName";
            this.folderName.Size = new System.Drawing.Size(216, 39);
            this.folderName.TabIndex = 8;
            this.folderName.Text = "FolderName :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(227, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormTransfert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.folderName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.folderNameBox);
            this.Name = "FormTransfert";
            this.Text = "FormTransfert";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox folderNameBox;
        private System.Windows.Forms.Label folderName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}