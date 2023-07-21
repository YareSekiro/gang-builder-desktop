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
    public partial class VehicleData : Form
    {
        public VehicleData()
        {
            InitializeComponent();
            setContent();
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



        private void setContent()
        {
            if (GangData.Vehicules[0].VName != null &&
                GangData.Vehicules[1].VName != null &&
                GangData.Vehicules[2].VName != null)
            {

                V1NameBox.Text = GangData.Vehicules[0].VName;
                V2NameBox.Text = GangData.Vehicules[1].VName;
                V3NameBox.Text = GangData.Vehicules[2].VName;

            }
            else
            {
                V1NameBox.Text = "Name (spawn name)";
                V2NameBox.Text = "Name (spawn name)";
                V3NameBox.Text = "Name (spawn name)";
            }

            if (GangData.Vehicules[0].VLabel != null &&
                GangData.Vehicules[1].VLabel != null &&
                GangData.Vehicules[2].VLabel != null)
            {
                V1LabelBox.Text = GangData.Vehicules[0].VLabel;
                V2LabelBox.Text = GangData.Vehicules[1].VLabel;
                V3LabelBox.Text = GangData.Vehicules[2].VLabel;
            }
            else
            {

                V1LabelBox.Text = "Label";
                V2LabelBox.Text = "Label";
                V3LabelBox.Text = "Label";

            }
        }

        private void Clear(object sender, MouseEventArgs e)
        {
            TextBox Box = (TextBox)sender;
            Box.Text = "";
        }
    }



}
