using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangBuilderV2
{
    public class GangData
    {

        public static string Name { get; set; }
        public static XYZPos ArmoryPos { get; set; } = new XYZPos();
        public static XYZPos CloakRoomPos { get; set; } = new XYZPos();
        public static List<Vehicule> Vehicules { get; set; } = new List<Vehicule>() { new Vehicule(), new Vehicule(), new Vehicule() };
        public static XYZPos MenuSpawnVehicles { get; set; } = new XYZPos();
        public static XYZPos VehiculesSpawnPoint { get; set; } = new XYZPos();
        public static string VehiculeHeading { get; set; }
        public static XYZPos VehiculeDeleterPoint { get; set; } = new XYZPos();
        public static XYZPos BossPos { get; set; } = new XYZPos();
        //public string[] GradesOrg { get; set; }
        public static string GradesOrg { get; set; }
        public static XYZPos BlipPos { get; set; } = new XYZPos();
        
        public static string BlipsColor { get; set; }
        public static string BlipsId { get; set; }

        public static string FolderName { get; set; }









    }

    public class XYZPos
    {
        public string X;
        public string Y;
        public string Z;


        public override string ToString()
        {
            return string.Format("x={0},y={1},z={2}", X, Y, Z);
        }

    }

    public class Vehicule
    {
        public string VName { get; set; }
        public string VLabel { get; set; }

        public Vehicule() { }

        public override string ToString()
        {
            return string.Format("name = '{0}' , label = '{1}'", VName, VLabel);
        }
    }


}
