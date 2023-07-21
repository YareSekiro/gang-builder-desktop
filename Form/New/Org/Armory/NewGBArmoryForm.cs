﻿using System;
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
    public partial class NewGBArmoryForm : Form
    {
        public NewGBArmoryForm()
        {
            InitializeComponent();
            this.SetBoxLabel();
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
            if (GangData.ArmoryPos.X != null)
            {
                ArmoryXBox.Text = GangData.ArmoryPos.X;
            }


            if (GangData.ArmoryPos.Y != null)
            {
                ArmoryYBox.Text = GangData.ArmoryPos.Y;
            }


            if (GangData.ArmoryPos.Z != null)
            {
                ArmoryZBox.Text = GangData.ArmoryPos.Z;
            }

        }
    }
}
