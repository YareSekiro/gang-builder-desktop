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
    public partial class FormVehicle : Form
    {
        public FormVehicle()
        {
            InitializeComponent();
            setContent();
        }


        private void V1XBox_TextChanged(object sender, EventArgs e)
        {
            GangData.MenuSpawnVehicles.X = V1XBox.Text;
        }

        private void V1YBox_TextChanged(object sender, EventArgs e)
        {
            GangData.MenuSpawnVehicles.Y = V1YBox.Text;

        }

        private void V1ZBox_TextChanged(object sender, EventArgs e)
        {
            GangData.MenuSpawnVehicles.Z = V1ZBox.Text;

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

        private void V1NameBox_TextChanged(object sender, EventArgs e)
        {
            GangData.Vehicules[0].VName = V1NameBox.Text;
        }

        private void V1LabelBox_TextChanged(object sender, EventArgs e)
        {
            GangData.Vehicules[0].VLabel = V1LabelBox.Text;
        }

        private void V2NameBox_TextChanged(object sender, EventArgs e)
        {
            GangData.Vehicules[1].VName = V2NameBox.Text;
        }

        private void V2LabelBox_TextChanged(object sender, EventArgs e)
        {
            GangData.Vehicules[1].VLabel = V2LabelBox.Text;
        }

        private void V3NameBox_TextChanged(object sender, EventArgs e)
        {
            GangData.Vehicules[2].VName = V3NameBox.Text;
        }

        private void V3LabelBox_TextChanged(object sender, EventArgs e)
        {
            GangData.Vehicules[2].VLabel = V3LabelBox.Text;
        }


        private void vHeadingBox_TextChanged(object sender, EventArgs e)
        {
            GangData.VehiculeHeading = vHeadingBox.Text;
        }

        private void setContent()
        {

            if (GangData.MenuSpawnVehicles.X != null && GangData.MenuSpawnVehicles.Y != null && GangData.MenuSpawnVehicles.Z != null)
            {
                V1XBox.Text = GangData.MenuSpawnVehicles.X;
                V1YBox.Text = GangData.MenuSpawnVehicles.Y;
                V1ZBox.Text = GangData.MenuSpawnVehicles.Z;
            } else
            {
                V1XBox.Text = "Menu X";
                V1YBox.Text = "Menu Y";
                V1ZBox.Text = "Menu Z";

            }


            if (GangData.VehiculesSpawnPoint.X != null &&
                GangData.VehiculesSpawnPoint.Y != null &&
                GangData.VehiculesSpawnPoint.Z != null)
            {

                V2XBox.Text = GangData.VehiculesSpawnPoint.X;
                V2YBox.Text = GangData.VehiculesSpawnPoint.Y;
                V2ZBox.Text = GangData.VehiculesSpawnPoint.Z;
            } else
            {
                V2XBox.Text = "Spawn X";
                V2YBox.Text = "Spawn Y";
                V2ZBox.Text = "Spawn Z";
            }

            if (GangData.VehiculeDeleterPoint.X != null &&
                GangData.VehiculeDeleterPoint.Y != null &&
                GangData.VehiculeDeleterPoint.Z != null)
            {
                V3XBox.Text = GangData.VehiculeDeleterPoint.X;
                V3YBox.Text = GangData.VehiculeDeleterPoint.Y;
                V3ZBox.Text = GangData.VehiculeDeleterPoint.Z;
            } else
            {
                V3XBox.Text = "Delete X";
                V3YBox.Text = "Delete Y";
                V3ZBox.Text = "Delete Z";
            }

            if (GangData.Vehicules[0].VName != null &&
                GangData.Vehicules[1].VName != null &&
                GangData.Vehicules[2].VName != null)
            {

                V1NameBox.Text = GangData.Vehicules[0].VName;
                V2NameBox.Text = GangData.Vehicules[1].VName;
                V3NameBox.Text = GangData.Vehicules[2].VName;

            } else
            {
                V1NameBox.Text = "v name";
                V2NameBox.Text = "v name";
                V3NameBox.Text = "v name";
            }

            if (GangData.Vehicules[0].VLabel != null &&
                GangData.Vehicules[1].VLabel != null &&
                GangData.Vehicules[2].VLabel != null)
            {
                V1LabelBox.Text = GangData.Vehicules[0].VLabel;
                V2LabelBox.Text = GangData.Vehicules[1].VLabel;
                V3LabelBox.Text = GangData.Vehicules[2].VLabel;
            } else
            {

                V1LabelBox.Text = "v label";
                V2LabelBox.Text = "v label";
                V3LabelBox.Text = "v label";

            }


            if(GangData.VehiculeHeading != null)
            {
                vHeadingBox.Text = GangData.VehiculeHeading;
            } else
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
