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
    public partial class VehicleDelete : Form
    {
        public VehicleDelete()
        {
            InitializeComponent();
            setContent();
        }

        private void V3XBox_TextChanged(object sender, EventArgs e)
        {
            GangData.VehiculeDeleterPoint.X = V3XBox.Text;
        }

        private void V3YBox_TextChanged(object sender, EventArgs e)
        {
            GangData.VehiculeDeleterPoint.Y = V3YBox.Text;

        }

        private void V3ZBox_TextChanged(object sender, EventArgs e)
        {
            GangData.VehiculeDeleterPoint.Z = V3ZBox.Text;

        }

        private void setContent()
        {
            if (GangData.VehiculeDeleterPoint.X != null &&
                GangData.VehiculeDeleterPoint.Y != null &&
                GangData.VehiculeDeleterPoint.Z != null)
            {
                V3XBox.Text = GangData.VehiculeDeleterPoint.X;
                V3YBox.Text = GangData.VehiculeDeleterPoint.Y;
                V3ZBox.Text = GangData.VehiculeDeleterPoint.Z;
            }
            else
            {
                V3XBox.Text = "Delete X";
                V3YBox.Text = "Delete Y";
                V3ZBox.Text = "Delete Z";
            }
        }

        private void Clear(object sender, MouseEventArgs e)
        {
            TextBox Box = (TextBox)sender;
            Box.Text = "";
        }
    }
}
