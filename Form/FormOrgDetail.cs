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
    public partial class FormOrgDetail : Form
    {

        public FormOrgDetail()
        {
            InitializeComponent();
            SetBoxLabel();
        }

        private void OrgDetailNameBox_TextChanged(object sender, EventArgs e)
        {
            GangData.Name = OrgDetailNameBox.Text;     
        }

        private void OrgDetailGradeBox_TextChanged(object sender, EventArgs e)
        {
            GangData.GradesOrg = OrgDetailGradeBox.Text;
        }

        private void SetBoxLabel()
        {
            if (GangData.Name != null)
            {
                OrgDetailNameBox.Text = GangData.Name;
            } else
            {
                OrgDetailNameBox.Text = "Enter Org Name";
            }

            if (GangData.GradesOrg != null)
            {
                OrgDetailGradeBox.Text = GangData.GradesOrg;
            } else
            {
                OrgDetailGradeBox.Text = "Enter grades";
            }
        }

        private void Clear(object sender, MouseEventArgs e)
        {
            TextBox Box = (TextBox)sender;
            Box.Text = "";
        }

    }
}
