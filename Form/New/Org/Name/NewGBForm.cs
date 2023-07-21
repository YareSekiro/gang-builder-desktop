using Guna.UI2.WinForms;
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
    public partial class NewGBForm : Form
    {
        private Form currentChildForm;

        public NewGBForm()
        {
            InitializeComponent();
            this.SetBoxLabel();
        }

        private void SetBoxLabel()
        {
            if (GangData.Name != null)
            {
                OrgDetailNameBox.Text = GangData.Name;
            }

            if (GangData.GradesOrg != null)
            {
                OrgDetailGradeBox.Text = GangData.GradesOrg;
            }
        }

        private void OrgDetailNameBox_TextChanged(object sender, EventArgs e)
        {
            GangData.Name = OrgDetailNameBox.Text;
        }

        private void OrgDetailGradeBox_TextChanged(object sender, EventArgs e)
        {
            GangData.GradesOrg = OrgDetailGradeBox.Text;
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();




        }


        private void ClickEvent(object sender , EventArgs e)
        {

            Guna2Button Btn = (Guna2Button)sender;
            Console.WriteLine(Btn.Name + " clicked");

            if (Btn.Name == "OrgExtraDetailBtn")
            {
                if (currentChildForm != null)
                {
                    currentChildForm.Close();
                }
            }

            if(Btn.Name == "ArmoryBtn")
            {
                this.OpenChildForm(new NewGBArmoryForm());
            }
            if(Btn.Name == "CloakroomBtn")
            {
                this.OpenChildForm(new NewGBCloakroomForm());
            }
            if (Btn.Name == "VehicleBtn")
            {
                this.OpenChildForm(new NewGBVehicleForm());
            }
            if(Btn.Name == "BossBtn")
            {
                this.OpenChildForm(new NewGBBossForm());
            }
            if(Btn.Name == "BlipsBtn")
            {
                this.OpenChildForm(new NewGBBlipsForm());
            }

        }
    }
}
