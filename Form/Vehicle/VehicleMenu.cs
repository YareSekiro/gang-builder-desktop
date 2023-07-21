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
    public partial class VMenu : Form
    {
        public VMenu()
        {
            InitializeComponent();
            SetContent();
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

        private void SetContent()
        {
            if (GangData.MenuSpawnVehicles.X != null && GangData.MenuSpawnVehicles.Y != null && GangData.MenuSpawnVehicles.Z != null)
            {
                V1XBox.Text = GangData.MenuSpawnVehicles.X;
                V1YBox.Text = GangData.MenuSpawnVehicles.Y;
                V1ZBox.Text = GangData.MenuSpawnVehicles.Z;
            }
            else
            {
                V1XBox.Text = "Menu X";
                V1YBox.Text = "Menu Y";
                V1ZBox.Text = "Menu Z";

            }
        }

        private void Clear(object sender, MouseEventArgs e)
        {
            TextBox Box = (TextBox)sender;
            Box.Text = "";
        }
    }
}
