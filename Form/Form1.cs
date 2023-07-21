using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace GangBuilderV2
{
    public partial class Form1 : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        private GangBuilderData _gangBuilderData;

        private int WMaxeSize = 1078;
        private int xIndex = 0;



        public GangBuilderData GangBuilderObject
        {
            get { return _gangBuilderData; }
            set { _gangBuilderData = value; }
        }


        //Constructor
        public Form1()
        {

            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            GangBuilderPanel.Controls.Add(leftBorderBtn);
            HidePanelLoading();
            FirstHide();

            //Form

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void HidePanelLoading()
        {
            panelContainLoading.Visible = false;
            panelGBLoading.Visible = false;
            labelLoader.Visible = false;
        }

        private void ShowPanelLoading()
        {
            
            panelGBLoading.Visible = true;
            panelContainLoading.Visible = true;
            
            labelLoader.Visible = true;
            timerLoading.Start();
        }

        private void ChainLoad()
        {
            if (xIndex < 7 )
            {
                string[] FileName = { "Dir", "Manifest", "Config", "Client", "Server", "Locales", "Sql" };
                Console.WriteLine("[ChainLoad][Debug][Start] - " + xIndex);
                panelGBLoading.Width += 3;
                if (panelGBLoading.Width > (WMaxeSize / 4)) labelLoader.Text = string.Format("{0} creation in progress..", FileName[xIndex]);
                if (panelGBLoading.Width > (WMaxeSize / 2)) labelLoader.Text = string.Format("{0} writing in progress..", FileName[xIndex]);
                if (panelGBLoading.Width > (WMaxeSize / 1.5)) labelLoader.Text = "Initialisation..";

                if (panelGBLoading.Width > (WMaxeSize))
                {
                    panelGBLoading.Width = 0;
                    xIndex++;
                    if (xIndex == 7)
                    {
                        Console.WriteLine("[ChainLoad][Debug][EndF] - " + xIndex);
                        timerLoading.Stop();
                        labelLoader.Text = "All data has been created.";
                        
                        return;
                    }
                }
            }
            else
            {
                timerLoading.Stop();
                return;
            }


        }

        private void FirstHide()
        {
            VMenu.Visible = false;
            VSpawn.Visible = false;
            VDelete.Visible = false;
            VData.Visible =  false;
            VPanel.Visible = false;
        }
        private void HideOrShowVehiclePanel()
        {
            VMenu.Visible = (VMenu.Visible ? false : true);
            VSpawn.Visible = (VSpawn.Visible ? false : true);
            VDelete.Visible = VDelete.Visible ? false : true;
            VData.Visible = VData.Visible ? false : true;
            VPanel.Visible = (VPanel.Visible ? false : true);

        }

        //Structs

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {

                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(20, 20, 20);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border button

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon current child form

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;




            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                //Button
                currentBtn.BackColor = Color.FromArgb(20, 20, 20);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;


            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
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
            homeChildLabel.Text = childForm.Text;
            
            


        }

        private void OrgExtraDetailBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormOrgDetail());

        }

        private void ArmoryBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormArmory());
        }

        private void CloakroomBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormCloakroom());
        }

        private void VehicleBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            //OpenChildForm(new FormVehicle());
            HideOrShowVehiclePanel();

        }

        private void BossBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormBoss());
        }

        private void BlipsBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FormBlips());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }

            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            homeChildLabel.Text = "Home";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GangBuilderPictureValidate_Click(object sender, EventArgs e)
        {
            if (GangData.Name != null)
            {
                ShowPanelLoading();
                GangBuilderObject = new GangBuilderData(GangData.Name);
                //Make a tab for org grade
                string[] OrgGrade = GangData.GradesOrg.Split(',');
                try
                {
                    //Try To create Dir
                    GangBuilderObject.CreateDir();

                    GangBuilderObject.CreateManifestFile(GangData.Name);

                    GangBuilderObject.CreateConfigFile(
                        GangData.Name,
                        GangData.Vehicules,
                        GangData.CloakRoomPos.ToString(),
                        GangData.ArmoryPos.ToString(),
                        GangData.MenuSpawnVehicles.ToString(),
                        GangData.VehiculesSpawnPoint.ToString(),
                        GangData.VehiculeHeading.ToString(),
                        GangData.VehiculeDeleterPoint.ToString(),
                        GangData.BossPos.ToString()
                        );

                    GangBuilderObject.CreateClientFile(
                        GangData.Name,
                        GangData.BlipPos.ToString(),
                        GangData.BlipsId,
                        GangData.BlipsColor
                        );

                    GangBuilderObject.CreateServerFile(GangData.Name);

                    GangBuilderObject.CreateLocalesFile(GangData.Name);

                    GangBuilderObject.CreateSqlFile(GangData.Name, OrgGrade);

                    return;



                }
                catch (Exception ex)
                {
                    Console.WriteLine("Process failed {0}", ex.Message);
                    return;
                }
            }
            else
            {
                MessageBox.Show("[ERROR] - Values are undefined.");
            }

        }

        private void GangBuilderPictureValidate_MouseHover(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile("img/GangB.png");

        }

        private void GangBuilderPictureValidate_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile("img/GBRose.png");

        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            ChainLoad();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //string Doc = string.Format("{0}\\Desktop\\GangBuilderFinal\\DataToTransfert", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            //if (!Directory.Exists(string.Format("{0}\\Desktop\\GangBuilderFinal\\DataToTransfert", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))))
            //{

            //    Directory.CreateDirectory(string.Format("{0}\\Desktop\\GangBuilderFinal\\DataToTransfert", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)));
            //}

            ////Directory.Move(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Doc);
            OpenChildForm(new FormCloakroom());


        }

        private void VMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new VMenu());
        }

        private void VSpawn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new VehicleSpawn());
        }

        private void VDelete_Click(object sender, EventArgs e)
        {
            OpenChildForm(new VehicleDelete());
        }

        private void VData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new VehicleData());
        }
    }


    //public class GangBuilderData
    //{
    //    public string ConfigData { get; set; }
    //    public string ManifestData { get; set; }
    //    public string ClientData { get; set; }
    //    public string ServerData { get; set; }
    //    public string SqlData { get; set; }

    //    public string ManifestTemplatePath { get; set; }
    //    public string ConfigTemplatePath { get; set; }
    //    public string ClientTemplatePath { get; set; }
    //    public string ServerTemplatePath { get; set; }
    //    public string LocalesTemplatePath { get; set; }
    //    public string SqlTemplatePath { get; set; }
    //    public string BasePath { get; set; }
    //    public string ConfigPath { get; set; }
    //    public string ManifestPath { get; set; }
    //    public string ClientPath { get; set; }
    //    public string ServerPath { get; set; }
    //    public string LocalesPath { get; set; }
    //    public string SqlPath { get; set; }

    //    public string TransfertExistingDataPath { get; set; }

    //    private Encoding UTF8WithoutBom = new UTF8Encoding(false);


    //    public GangBuilderData() { }
    //    public GangBuilderData(string Name)
    //    {
    //        this.ConfigData = string.Empty;
    //        this.ManifestData = string.Empty;
    //        this.ClientData = string.Empty;
    //        this.ServerData = string.Empty;
    //        this.SqlData = string.Empty;

    //        this.ManifestTemplatePath = "template/manifest.txt";
    //        this.ConfigTemplatePath = "template/config.txt";
    //        this.ClientTemplatePath = "template/client.txt";
    //        this.ServerTemplatePath = "template/server.txt";
    //        this.LocalesTemplatePath = "template/fr.txt";
    //        this.SqlTemplatePath = "template/sql.txt";
    //        this.TransfertExistingDataPath = string.Format("{0}\\Desktop\\GangBuilderFinal\\DataToTransfert", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
    //        this.BasePath = string.Format("{0}\\Desktop\\GangBuilderFinal\\esx_{1}", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), Name);
    //        this.ConfigPath = string.Format("{0}\\Desktop\\GangBuilderFinal\\esx_{1}", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), Name);
    //        this.ManifestPath = string.Format("{0}\\Desktop\\GangBuilderFinal\\esx_{1}", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), Name);
    //        this.ClientPath = string.Format("{0}\\Desktop\\GangBuilderFinal\\esx_{1}\\client", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), Name);
    //        this.ServerPath = string.Format("{0}\\Desktop\\GangBuilderFinal\\esx_{1}\\server", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), Name);
    //        this.LocalesPath = string.Format("{0}\\Desktop\\GangBuilderFinal\\esx_{1}\\locales", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), Name);
    //        this.SqlPath = string.Format("{0}\\Desktop\\GangBuilderFinal\\esx_{1}", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), Name);

    //    }

    //    public void CreateDir()
    //    {

    //        bool BaseDirExisted = false, ClientDirExisted = false, ServerDirExisted = false, LocalesDirExisted = false;
    //        try
    //        {
    //            /*
    //             * Check If the differents directory exists
    //             * */
    //            if (Directory.Exists(this.BasePath)) BaseDirExisted = true;
    //            if (Directory.Exists(this.ClientPath)) ClientDirExisted = true;
    //            if (Directory.Exists(this.ServerPath)) ServerDirExisted = true;
    //            if (Directory.Exists(this.LocalesPath)) LocalesDirExisted = true;

    //            //If the directory don't exists , we create it.
    //            if (!BaseDirExisted) { Directory.CreateDirectory(this.BasePath); }
    //            if (!ClientDirExisted) { Directory.CreateDirectory(this.ClientPath); }
    //            if (!ServerDirExisted) { Directory.CreateDirectory(this.ServerPath); }
    //            if (!LocalesDirExisted) { Directory.CreateDirectory(this.LocalesPath); }

    //            Console.WriteLine("[GangBuilder][CreateDir] Dir are successfully created.");




    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("The process failed : {0}", ex.ToString());
    //        }

    //    }

    //    public void CreateManifestFile(string Name)
    //    {
    //        try
    //        {
    //            if (!File.Exists(this.ManifestTemplatePath)) { Console.WriteLine("File [{0}] seem not exist.", this.ManifestTemplatePath); return; }

    //            var ManifestFileData = File.ReadAllText(this.ManifestTemplatePath, UTF8WithoutBom);
    //            ManifestFileData = ManifestFileData.Replace("{", $"%{(int)'{'}").Replace("}", $"%{(int)'}'}");
    //            int idx = 0;
    //            while (ManifestFileData.Contains("GangBuilderDataToReplace" + idx.ToString()))
    //            {
    //                ManifestFileData = ManifestFileData.Replace("GangBuilderDataToReplace" + idx.ToString(), "{" + idx.ToString() + "}");
    //                idx++;
    //            }

    //            ManifestFileData = string.Format(ManifestFileData, Name);

    //            ManifestFileData = ManifestFileData
    //                .Replace
    //                (
    //                $"%{(int)'{'}",
    //                "{"
    //                )
    //                .Replace
    //                (
    //                $"%{(int)'}'}",
    //                "}"
    //                );

    //            File.WriteAllText(string.Format("{0}\\__resource.lua", this.ManifestPath), ManifestFileData, UTF8WithoutBom);

    //            Console.WriteLine("[GangBuilder][ManifestFile] - Created with success.");

    //            WriteInLogFile("ManifestFile created with success.");

    //            return;

    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Exception catched : {0}", ex.Message);
    //            WriteInLogFile(ex.Message);
    //            return;
    //        }




    //    }
    //    public void CreateConfigFile(string Name, List<Vehicule> V, string CloakRoomPos, string ArmoryPos, string VSpawner, string VSpawnPoint, string Heading, string VDeleters, string BossAction)
    //    {
    //        try
    //        {
    //            if (!File.Exists(this.ConfigTemplatePath)) { Console.WriteLine("File [{0}] seem not exist.", this.ConfigTemplatePath); return; }

    //            var ConfigFileData = File.ReadAllText(this.ConfigTemplatePath, UTF8WithoutBom);
    //            ConfigFileData = ConfigFileData.Replace("{", $"%{(int)'{'}").Replace("}", $"%{(int)'}'}");
    //            int idx = 0;
    //            while (ConfigFileData.Contains("GangBuilderDataToReplace" + idx.ToString()))
    //            {
    //                ConfigFileData = ConfigFileData.Replace("GangBuilderDataToReplace" + idx.ToString(), "{" + idx.ToString() + "}");
    //                idx++;
    //            }

    //            ConfigFileData = string.Format(ConfigFileData,
    //                Name,
    //                $"{"{"}{string.Join("},{", V)}{"}"}",
    //                CloakRoomPos,
    //                ArmoryPos,
    //                VSpawner,
    //                VSpawnPoint,
    //                Heading,
    //                VDeleters,
    //                BossAction
    //                );

    //            ConfigFileData = ConfigFileData
    //                .Replace
    //                (
    //                $"%{(int)'{'}",
    //                "{"
    //                )
    //                .Replace
    //                (
    //                $"%{(int)'}'}",
    //                "}"
    //                );

    //            File.WriteAllText(string.Format("{0}\\config.lua", this.ConfigPath), ConfigFileData, UTF8WithoutBom);

    //            Console.WriteLine("[GangBuilder][ConfigFile] - Created with success.");

    //            WriteInLogFile("ConfigFile created with success.");

    //            return;

    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Exception catched : {0}", ex.Message);
    //            WriteInLogFile(ex.Message);
    //            return;
    //        }




    //    }

    //    public void CreateClientFile(string Name, string BlipsCoord, string Id, string color)
    //    {
    //        try
    //        {
    //            if (!File.Exists(this.ClientTemplatePath)) { Console.WriteLine("File [{0}] seem not exist.", this.ClientTemplatePath); return; }

    //            var ClientFileData = File.ReadAllText(this.ClientTemplatePath, UTF8WithoutBom);
    //            ClientFileData = ClientFileData.Replace("{", $"%{(int)'{'}").Replace("}", $"%{(int)'}'}");
    //            int idx = 0;
    //            while (ClientFileData.Contains("GangBuilderDataToReplace" + idx.ToString()))
    //            {
    //                ClientFileData = ClientFileData.Replace("GangBuilderDataToReplace" + idx.ToString(), "{" + idx.ToString() + "}");
    //                idx++;
    //            }

    //            ClientFileData = string.Format(ClientFileData, Name, BlipsCoord, Id, color);

    //            ClientFileData = ClientFileData
    //                .Replace
    //                (
    //                $"%{(int)'{'}",
    //                "{"
    //                )
    //                .Replace
    //                (
    //                $"%{(int)'}'}",
    //                "}"
    //                );

    //            File.WriteAllText(string.Format("{0}\\client.lua", this.ClientPath), ClientFileData, UTF8WithoutBom);

    //            Console.WriteLine("[GangBuilder][ClientFile] - Created with success.");

    //            WriteInLogFile("ClientFile created with success.");
    //            return;
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Exception catched : {0}", ex.Message);
    //            WriteInLogFile(ex.Message);
    //        }




    //    }

    //    public void CreateServerFile(string Name)
    //    {
    //        try
    //        {
    //            if (!File.Exists(this.ServerTemplatePath)) { Console.WriteLine("File [{0}] seem not exist.", this.ServerTemplatePath); return; }

    //            var ServerFileData = File.ReadAllText(this.ServerTemplatePath, UTF8WithoutBom);
    //            ServerFileData = ServerFileData.Replace("{", $"%{(int)'{'}").Replace("}", $"%{(int)'}'}");
    //            int idx = 0;
    //            while (ServerFileData.Contains("GangBuilderDataToReplace" + idx.ToString()))
    //            {
    //                ServerFileData = ServerFileData.Replace("GangBuilderDataToReplace" + idx.ToString(), "{" + idx.ToString() + "}");
    //                idx++;
    //            }

    //            ServerFileData = string.Format(ServerFileData, Name);

    //            ServerFileData = ServerFileData
    //                .Replace
    //                (
    //                $"%{(int)'{'}",
    //                "{"
    //                )
    //                .Replace
    //                (
    //                $"%{(int)'}'}",
    //                "}"
    //                );

    //            File.WriteAllText(string.Format("{0}\\server.lua", this.ServerPath), ServerFileData, UTF8WithoutBom);

    //            Console.WriteLine("[GangBuilder][ServerFile] - Created with success.");

    //            WriteInLogFile("ServerFile created with success");

    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Exception catched : {0}", ex.Message);
    //            WriteInLogFile(ex.Message);
    //        }





    //    }

    //    public void CreateLocalesFile(string Name)
    //    {
    //        try
    //        {
    //            if (!File.Exists(this.LocalesTemplatePath)) { Console.WriteLine("File [{0}] seem not exist.", this.LocalesTemplatePath); return; }

    //            var LocalesFileData = File.ReadAllText(this.LocalesTemplatePath, UTF8WithoutBom);
    //            LocalesFileData = LocalesFileData.Replace("{", $"%{(int)'{'}").Replace("}", $"%{(int)'}'}");
    //            int idx = 0;
    //            while (LocalesFileData.Contains("GangBuilderDataToReplace" + idx.ToString()))
    //            {
    //                LocalesFileData = LocalesFileData.Replace("GangBuilderDataToReplace" + idx.ToString(), "{" + idx.ToString() + "}");
    //                idx++;
    //            }

    //            LocalesFileData = string.Format(LocalesFileData, Name);

    //            LocalesFileData = LocalesFileData
    //                .Replace
    //                (
    //                $"%{(int)'{'}",
    //                "{"
    //                )
    //                .Replace
    //                (
    //                $"%{(int)'}'}",
    //                "}"
    //                );

    //            File.WriteAllText(string.Format("{0}\\fr.lua", this.LocalesPath), LocalesFileData, UTF8WithoutBom);

    //            Console.WriteLine("[GangBuilder][LocalesFile] - Created with success.");

    //            WriteInLogFile("LocalesFile created with success");

    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Exception catched : {0}", ex.Message);
    //            WriteInLogFile(ex.Message);
    //        }





    //    }

    //    public void CreateSqlFile(string Name, string[] orgGrade)
    //    {
    //        try
    //        {
    //            if (!File.Exists(this.SqlTemplatePath)) { Console.WriteLine("File [{0}] seem not exist.", this.SqlTemplatePath); return; }

    //            var SqlFileData = File.ReadAllText(this.SqlTemplatePath, UTF8WithoutBom);
    //            SqlFileData = SqlFileData.Replace("{", $"%{(int)'{'}").Replace("}", $"%{(int)'}'}");
    //            int idx = 0;
    //            while (SqlFileData.Contains("GangBuilderDataToReplace" + idx.ToString()))
    //            {
    //                SqlFileData = SqlFileData.Replace("GangBuilderDataToReplace" + idx.ToString(), "{" + idx.ToString() + "}");
    //                idx++;
    //            }

    //            SqlFileData = string.Format(SqlFileData, Name, orgGrade[0], orgGrade[1], orgGrade[2], orgGrade[3], orgGrade[4], orgGrade[5]);

    //            SqlFileData = SqlFileData
    //                .Replace
    //                (
    //                $"%{(int)'{'}",
    //                "{"
    //                )
    //                .Replace
    //                (
    //                $"%{(int)'}'}",
    //                "}"
    //                );

    //            File.WriteAllText(string.Format("{0}\\esx_{1}.sql", this.SqlPath, Name), SqlFileData, UTF8WithoutBom);

    //            Console.WriteLine("[GangBuilder][SqlFile] - Created with success.");

    //            WriteInLogFile("SqlFile created with success.");

    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Exception catched : {0}", ex.Message);
    //            WriteInLogFile(ex.Message);
    //        }



    //    }

    //    public void WriteInLogFile(string msg)
    //    {
    //        try
    //        {
    //            if (!File.Exists("__GangBuilderLog__")) return;

    //            File.AppendAllText("__GangBuilderLog__", string.Format("[{0}][GangBuilderLog][WriteInLogFile] - {1}", this.GetDate(), msg + Environment.NewLine));

    //            return;

    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("[{0}][GangBuilder][WriteInLogFile] - Exception catched : {1}", this.GetDate(), ex.Message);
    //            return;
    //        }


    //    }

    //    public string GetDate()
    //    {

    //        DateTime LocalDate = DateTime.Now;
    //        string culture = "fr-FR";

    //        return LocalDate.ToString(culture);

    //    }




    //}

}
