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
    public partial class FormCloakroom : Form
    {
        public FormCloakroom()
        {
            InitializeComponent();
            SetLabelBox();
        }

        private void CloakRoomXBox_TextChanged(object sender, EventArgs e)
        {
            GangData.CloakRoomPos.X = CloakRoomXBox.Text;
        }

        private void CloakRoomYBox_TextChanged(object sender, EventArgs e)
        {
            GangData.CloakRoomPos.Y = CloakRoomYBox.Text;
        }

        private void CloakRoomZBox_TextChanged(object sender, EventArgs e)
        {
            GangData.CloakRoomPos.Z = CloakRoomZBox.Text;
        }

        private void SetLabelBox()
        {
            if(GangData.CloakRoomPos.X != null && GangData.CloakRoomPos.Y != null && GangData.CloakRoomPos.Z != null)
            {
                CloakRoomXBox.Text = GangData.CloakRoomPos.X;
                CloakRoomYBox.Text = GangData.CloakRoomPos.Y;
                CloakRoomZBox.Text = GangData.CloakRoomPos.Z;
            } else
            {
                CloakRoomXBox.Text = "X coord";
                CloakRoomYBox.Text = "Y coord";
                CloakRoomZBox.Text = "Z coord";
            }

        }

        private void Clear(object sender, MouseEventArgs e)
        {
            TextBox Box = (TextBox)sender;
            Box.Text = "";
        }

    }
}
