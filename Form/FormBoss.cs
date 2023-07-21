using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GangBuilderV2
{
    public partial class FormBoss : Form
    {
        public FormBoss()
        {
            InitializeComponent();
            SetBoxLabel();
        }

        private void BossXBox_TextChanged(object sender, EventArgs e)
        {
            GangData.BossPos.X = BossXBox.Text;
        }

        private void BossYBox_TextChanged(object sender, EventArgs e)
        {
            GangData.BossPos.Y = BossYBox.Text;
        }

        private void BossZBox_TextChanged(object sender, EventArgs e)
        {
            GangData.BossPos.Z = BossZBox.Text;
        }

        private void SetBoxLabel()
        {
            if(GangData.BossPos.X != null && GangData.BossPos.Y != null && GangData.BossPos.Z != null)
            {
                BossXBox.Text = GangData.BossPos.X;
                BossYBox.Text = GangData.BossPos.Y;
                BossZBox.Text = GangData.BossPos.Z;
            } else
            {
                BossXBox.Text = "X coord";
                BossYBox.Text = "Y coord";
                BossZBox.Text = "Z coord";
            }

        }

        private void Clear(object sender, MouseEventArgs e)
        {
            TextBox Box = (TextBox)sender;
            Box.Text = "";
        }

    }
}
