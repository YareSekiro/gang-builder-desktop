using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GangBuilderV2
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void Hydrate(Object v)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Estarossa Dbconnect = new Estarossa();
            var dico = new Dictionary<string, object>
            {
                {"yes", "starfalah" },
                {"oui", "kefta" },
                {"zebio", 415 }
            };

            var resultHandlerV2 =
                new List<Dictionary<string, object>>(
            new Dictionary<string, object>[] { }
            );

            resultHandlerV2.Add(dico);
            foreach(Dictionary<string, object> z in resultHandlerV2)
            {
                foreach(KeyValuePair<string, object> k in z)
                {
                    W($"{k.Key} | {k.Value}");
                }
            }
            //Dictionary<string, List<Object>> Dico = new Dictionary<string, List<Object>>();
            //Dico.Add("id", new List<Object>(new string[] { "salam", "aleykoum" }));
            //Dico.Add("account_name", new List<Object>(new string[] { "bank", "blackmoney" }));
            //Dico.Add("money", new List<Object>(new string[] { "1500", "4500" }));

            //AccountData _account = new AccountData(Dico);
            //_account.Account_name.ForEach(W);
            //_account.Money.ForEach(W);
            //_account.Id.ForEach(W);



            

            //Estarossa _e = new Estarossa();
            //var data = _e.GetData("SELECT * FROM test", )


            // TODO: 22 Septembre 2020 a 00h34
            // TODO: Essayer la selection sur une table avec un nombre de lignes limités : OK
            // TODO: Changer les id de connexion MYSQL et testé avec les vrais donnés
            // TODO: Mettre en place le design une fois que tout est bon

            // TODO: Changer les List<object> dans les différentes classes par object parce qu'il y'aura seulement
            // un attribut de chaque et non pas une liste.

            // TODO: Changer dans PlayerData les attributs: Il s'agit d'une liste de classe et non pas d'une seule
            // Car un joueur peut avoir plusieurs factures, plusieurs comptes etc.

            // TODO: Modifier la fonction de lecture ligne par ligne dans Estarossa.cs







        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            //Estarossa _estarossa = new Estarossa();
            //var zebio = _estarossa.GetData(
            //    "SELECT * FROM commands WHERE owner = ?yolo",
            //    new List<string>(new string[] { "?yolo" }),
            //    new List<object>(new object[] { "Alucard Mouss" }),
            //    1
            //    );

            //foreach(KeyValuePair<string, List<object>> _k in zebio)
            //{
            //    W($"=== [{_k.Key}] ===");
            //    _k.Value.ForEach(W);
            //}
  
        }

        private void W(Object texte)
        {
            Console.WriteLine(texte);
        }
    }
}
