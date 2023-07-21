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
    public partial class VehicleSpawn : Form
    {
        public VehicleSpawn()
        {
            InitializeComponent();
            SetContent();
        }

        private void V2XBox_TextChanged(object sender, EventArgs e)
        {
            GangData.VehiculesSpawnPoint.X = V2XBox.Text;
        }

        private void V2YBox_TextChanged(object sender, EventArgs e)
        {
            GangData.VehiculesSpawnPoint.Y = V2YBox.Text;

        }

        private void V2ZBox_TextChanged(object sender, EventArgs e)
        {
            GangData.VehiculesSpawnPoint.Z = V2ZBox.Text;

        }

        private void vHeadingBox_TextChanged(object sender, EventArgs e)
        {
            GangData.VehiculeHeading = vHeadingBox.Text;
        }




        private void SetContent()
        {
            if (GangData.VehiculesSpawnPoint.X != null &&
                GangData.VehiculesSpawnPoint.Y != null &&
                GangData.VehiculesSpawnPoint.Z != null)
            {

                V2XBox.Text = GangData.VehiculesSpawnPoint.X;
                V2YBox.Text = GangData.VehiculesSpawnPoint.Y;
                V2ZBox.Text = GangData.VehiculesSpawnPoint.Z;
            }
            else
            {
                V2XBox.Text = "Spawn X";
                V2YBox.Text = "Spawn Y";
                V2ZBox.Text = "Spawn Z";
            }

            if (GangData.VehiculeHeading != null)
            {
                vHeadingBox.Text = GangData.VehiculeHeading;
            }
            else
            {
                vHeadingBox.Text = "heading";
            }
        }

        private void Clear(object sender, MouseEventArgs e)
        {
            TextBox Box = (TextBox)sender;
            Box.Text = "";
        }

    }
}
