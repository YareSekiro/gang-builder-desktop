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
    public partial class FormArmory : Form
    {
        public FormArmory()
        {
            InitializeComponent();
            SetBoxLabel();
        }

        private void ArmoryXBox_TextChanged(object sender, EventArgs e)
        {
            GangData.ArmoryPos.X = ArmoryXBox.Text;
        }

        private void ArmoryYBox_TextChanged(object sender, EventArgs e)
        {
            GangData.ArmoryPos.Y = ArmoryYBox.Text;
        }

        private void ArmoryZBox_TextChanged(object sender, EventArgs e)
        {
            GangData.ArmoryPos.Z = ArmoryZBox.Text;
        }


        private void SetBoxLabel()
        {
            if(GangData.ArmoryPos.X != null)
            {
                ArmoryXBox.Text = GangData.ArmoryPos.X;
            } else
            {
                ArmoryXBox.Text = "Enter X value";
            }
            
            if(GangData.ArmoryPos.Y != null)
            {
                ArmoryYBox.Text = GangData.ArmoryPos.Y;
            } else
            {
                ArmoryYBox.Text = "Enter Y value";
            }

            if(GangData.ArmoryPos.Z != null)
            {
                ArmoryZBox.Text = GangData.ArmoryPos.Z;
            } else
            {
                ArmoryZBox.Text = "Enter Z value";
            }

        }
        private void Clear(object sender, MouseEventArgs e)
        {
            TextBox Box = (TextBox)sender;
            Box.Text = "";
        }

    }
}
