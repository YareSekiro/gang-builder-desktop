using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GangBuilderV2
{
    public partial class NewGBBlipsForm : Form
    {
        public NewGBBlipsForm()
        {
            InitializeComponent();
            this.setBoxLabel();
        }

        private void helpBox_Click(object sender, EventArgs e)
        {
            Process.Start("chrome", @"https://wiki.gtanet.work/index.php?title=Blips");
            return;
        }

        private void drawBox_TextChanged(object sender, EventArgs e)
        {
            GangData.BlipsId = drawBox.Text;
        }

        private void colorBox_TextChanged(object sender, EventArgs e)
        {
            GangData.BlipsColor = colorBox.Text;
        }

        private void BlipsXBox_TextChanged(object sender, EventArgs e)
        {
            GangData.BlipPos.X = BlipsXBox.Text;
        }

        private void BlipsYBox_TextChanged(object sender, EventArgs e)
        {
            GangData.BlipPos.Y = BlipsYBox.Text;
        }

        private void BlipsZBox_TextChanged(object sender, EventArgs e)
        {
            GangData.BlipPos.Z = BlipsZBox.Text;
        }

        private void setBoxLabel()
        {
            if (GangData.BlipsId != null)
            {
                drawBox.Text = GangData.BlipsId;
            }
            if (GangData.BlipsColor != null)
            {
                colorBox.Text = GangData.BlipsColor;
            }

            if (GangData.BlipPos.X != null && GangData.BlipPos.Y != null && GangData.BlipPos.Z != null)
            {
                BlipsXBox.Text = GangData.BlipPos.X;
                BlipsYBox.Text = GangData.BlipPos.Y;
                BlipsZBox.Text = GangData.BlipPos.Z;
            }

        }
    }
}
