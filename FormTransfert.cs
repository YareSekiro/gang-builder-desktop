using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GangBuilderV2
{
    public partial class FormTransfert : Form
    {
        public FormTransfert()
        {
            InitializeComponent();
            //Test("doc/test.txt", 29);
        }

        private void folderNameBox_TextChanged(object sender, EventArgs e)
        {
            GangData.FolderName = folderNameBox.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string Doc = string.Format("{0}\\Desktop\\GangBuilderFinal\\DataToTransfert", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            string MyDoc = string.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), GangData.FolderName);
            if (!Directory.Exists(string.Format("{0}\\Desktop\\GangBuilderFinal\\DataToTransfert", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))))
            {

                Directory.CreateDirectory(string.Format("{0}\\Desktop\\GangBuilderFinal\\DataToTransfert", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)));
            }

            Directory.Move(MyDoc, Doc);
            string TotalDir = string.Format("{0}\\{1}", Doc, GangData.FolderName);
            ReadExistingData(TotalDir, GangData.FolderName);
        }

        private void ReadExistingData(string dir, string dirName)
        {
            string[] extract = dirName.Split('_');
            string OrgName = extract[1];
            string configDir = string.Format("{0}\\config\\config.lua");
            if (!File.Exists(configDir)) return;

            string cloakRoomContent = File.ReadLines(configDir).Skip(31).First();




        }


        private string[] ReadConfigPos(string dir, int lineToSkip)
        {
            string content = File.ReadLines(dir).Skip(lineToSkip).First().Replace('{', ' ').Replace('}', ' ').Trim() ;

            string[] toExplode = content.Split(',');
            string[] XPos = toExplode[0].Split('=');
            string[] YPos = toExplode[1].Split('=');
            string[] ZPos = toExplode[2].Split('=');

            string[] Data = { XPos[1].Trim(), YPos[1].Trim(), ZPos[1].Trim() };
            
            return Data;
        }

        private string ReadHeading(string dir, int lineToSkip)
        {
            string content = File.ReadLines(dir).Skip(lineToSkip).First();
            string[] Heading = content.Split('=');
            string H = Heading[1].Replace(',', ' ').Trim();
            return H;

        }

        private string[] GetVehicule(string dir, int lineToSkip)
        {
            string content = File.ReadLines(dir).Skip(lineToSkip).First().Replace("{", "");
            char[] sep = { '}', ',', '=' };
            string[] data = content.Split(sep);
            string[] Name = { "", "", "" };
            string[] Label = { "", "", "" };
            string[][] V = new string[3][];
            int idxN = 0;
            int idxL = 0;
            bool isName = false;
            bool isLabel = false;
            foreach (string s in data)
            {


                if (isName)
                {
                    Name[idxN] = s.Replace("'", "");
                    isName = false;
                    idxN++;
                }
                if (isLabel)
                {
                    Label[idxL] = s.Replace("'", "");
                    isLabel = false;
                    idxL++;
                }

                Console.WriteLine(s.Trim());
                if (s.Trim() == "name") isName = true;
                if (s.Trim() == "label") isLabel = true;


            }

            V[0] = Name;
            V[1] = Label;

            foreach (string n in Name)
                Console.WriteLine(string.Format("Name : {0}", n));

            foreach (string l in Label)
                Console.WriteLine(string.Format("Label : {0}", l));

            return Name;
        }

        private void SetCloakRoomPos(string[] Pos)
        {
            GangData.CloakRoomPos.X = Pos[0];
            GangData.CloakRoomPos.Y = Pos[1];
            GangData.CloakRoomPos.Z = Pos[2];
        }

        private void SetArmoriesPos(string[] Pos)
        {
            GangData.ArmoryPos.X = Pos[0];
            GangData.ArmoryPos.Y = Pos[1];
            GangData.ArmoryPos.Z = Pos[2];
        }

        private void SetBossPos(string[] Pos)
        {
            GangData.BossPos.X = Pos[0];
            GangData.BossPos.Y = Pos[1];
            GangData.BossPos.Z = Pos[2];
        }

        private void SetBlipsPos(string[] Pos)
        {
            GangData.BlipPos.X = Pos[0];
            GangData.BlipPos.Y = Pos[1];
            GangData.BlipPos.Z = Pos[2];
        }

        private void SetMenuVPos(string[] Pos)
        {
            GangData.MenuSpawnVehicles.X = Pos[0];
            GangData.MenuSpawnVehicles.Y = Pos[1];
            GangData.MenuSpawnVehicles.Z = Pos[2];
        }

        private void SetSpawnPointPos(string[] Pos)
        {
            GangData.VehiculesSpawnPoint.X = Pos[0];
            GangData.VehiculesSpawnPoint.Y = Pos[1];
            GangData.VehiculesSpawnPoint.Z = Pos[2];
        }

        private void SetDeleterPos(string[] Pos)
        {
            GangData.VehiculeDeleterPoint.X = Pos[0];
            GangData.VehiculeDeleterPoint.Y = Pos[1];
            GangData.VehiculeDeleterPoint.Z = Pos[2];
        }

        private void SetHeading(string heading)
        {
            GangData.VehiculeHeading = heading;
        }

        private void SetVehicules(string[] VName, string[] VLabel)
        {
            GangData.Vehicules[0].VName = VName[0];
            GangData.Vehicules[0].VLabel = VLabel[0];
            GangData.Vehicules[1].VName = VName[1];
            GangData.Vehicules[1].VLabel = VLabel[1];
            GangData.Vehicules[2].VLabel = VName[2];
            GangData.Vehicules[2].VLabel = VLabel[2];

        }

    }
}
