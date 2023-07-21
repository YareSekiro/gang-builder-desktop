using MySql.Data.MySqlClient;
using Renci.SshNet.Messages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GangBuilderV2
{
    public abstract class Estarossa
    {
        private MySqlConnection Omen;

        
        protected void Initialize()
        {
            this.Omen = new MySqlConnection(ConfigurationManager.ConnectionStrings["iFiveId"].ConnectionString);

        }
        /// <summary>
        /// Open the sql connection
        /// </summary>
        /// <returns>
        /// bool
        /// </returns>
        private bool OpenConnection()
        {
            try
            {
                Omen.Open();
                return true;
            }catch(MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.");
                        break;
                    case 1:
                        MessageBox.Show("Invalid username / password");
                        break;
                }

                return false;
            }
        }

        /// <summary>
        /// Close sql connection
        /// </summary>
        /// <returns></returns>
        private bool CloseConnection()
        {
            try
            {
                this.Omen.Close();
                return true;
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        protected List<Dictionary<string, object>> GetDataLinePerLine(string query, List<string> param, List<object> value, object nbLines = null)
        {
            int index = 0;

            try
            {
                List<Dictionary<string, object>> resultSender = null;
                //Si la connection est bien ouverte
                if (this.OpenConnection() == true)
                {
                    //On execute la commande sql
                    var cmd = new MySqlCommand(query, this.Omen);

                    for (int i = 0; i < param.Count; i++)
                    {
                        cmd.Parameters.AddWithValue(param[i], value[i]);
                    }

                    var reader = cmd.ExecuteReader();

                    var resultHandlerV2 =
                        new List<Dictionary<string, object>>(
                            new Dictionary<string, object>[] { }
                            );

                    //On définit les différentes colonnes de la table
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        resultHandlerV2.Add(new Dictionary<string, object>(reader.GetName(i), new object));
                    }

                    //Si il y'a des données
                    if (reader.HasRows)
                    {

                        if (nbLines != null)
                        {

                            //Tant qu'il y'a des données
                            while (reader.Read() && index < (int)nbLines)
                            {
                                //Pour chaque colonnes
                                for (int i = 0; i < reader.FieldCount; i++)
                                {

                                    //On ajoute les données a leurs key respectives
                                    resultHandlerV2[reader.GetName(i)].Add(reader[reader.GetName(i)].ToString());
                                }

                                index++;


                            }
                        }
                        else
                        {
                            while (reader.Read())
                            {
                                //Pour chaque colonnes
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    //On ajoute les données a leurs key respectives
                                    resultHandlerV2[reader.GetName(i)].Add(reader[reader.GetName(i)].ToString());
                                }


                            }
                        }


                    }



                    resultSender = resultHandlerV2;

                }



                this.CloseConnection();

                return resultSender;
            }
            catch (Exception) { Console.WriteLine("Exception"); return new Dictionary<string, List<object>>(); }
        }

        protected Dictionary<string, List<object>> GetData(string query, List<string> param , List<Object> value, object nbLines = null)
        {
            int index = 0;

            try
            {
                Dictionary<string, List<object>> resultSender = null;
                //Si la connection est bien ouverte
                if(this.OpenConnection() == true)
                {
                    //On execute la commande sql
                    var cmd = new MySqlCommand(query, this.Omen);

                    for(int i = 0; i < param.Count; i++)
                    {
                        cmd.Parameters.AddWithValue(param[i], value[i]);
                    }

                    var reader = cmd.ExecuteReader();

                    Dictionary<string, List<object>> resultHandlerV2 = new Dictionary<string, List<object>>();
                    
                    //On définit les différentes colonnes de la table
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        resultHandlerV2.Add(reader.GetName(i), new List<object>());
                    }

                    //Si il y'a des données
                    if (reader.HasRows)
                    {

                        if (nbLines != null)
                        {
                            
                            //Tant qu'il y'a des données
                            while (reader.Read() && index < (int)nbLines)
                            {
                                //Pour chaque colonnes
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    
                                    //On ajoute les données a leurs key respectives
                                    resultHandlerV2[reader.GetName(i)].Add(reader[reader.GetName(i)].ToString());
                                }

                                index++;


                            }
                        }
                        else
                        {
                            while (reader.Read())
                            {
                                //Pour chaque colonnes
                                for(int i = 0; i < reader.FieldCount; i++)
                                {
                                    //On ajoute les données a leurs key respectives
                                    resultHandlerV2[reader.GetName(i)].Add(reader[reader.GetName(i)].ToString());
                                }

                            
                            }
                        }
                        

                    }



                    resultSender = resultHandlerV2;

                }

                

                this.CloseConnection();

                return resultSender;
            }
            catch (Exception) { Console.WriteLine("Exception"); return new Dictionary<string, List<object>>(); }
        }

        protected void ExecuteNonQuery(string sql, List<String> param, List<Object> value)
        {
            if(this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sql, this.Omen);
                for(int i = 0; i < param.Count; i++)
                {
                    cmd.Parameters.AddWithValue(param[i], value[i]);
                }

                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void ResetPlayer(List<string> param, List<Object> value)
        {
            this.ExecuteNonQuery("DELETE FROM addon_account_data WHERE owner = '?steam'", param, value);
            this.ExecuteNonQuery("DELETE FROM addon_inventory_items WHERE owner = '?steam'", param, value);
            this.ExecuteNonQuery("DELETE FROM billing WHERE Identifier = '?steam'", param, value);
            this.ExecuteNonQuery("DELETE FROM characters WHERE Identifier = '?steam'", param, value);
            this.ExecuteNonQuery("DELETE FROM jsfour_atm WHERE Identifier = '?steam'", param, value);
            this.ExecuteNonQuery("DELETE FROM owned_vehicles WHERE owner = '?steam'", param, value);
            this.ExecuteNonQuery("DELETE FROM owned_slz WHERE owner = '?steam'", param, value);
            this.ExecuteNonQuery("DELETE FROM playersTattoos WHERE Identifier = '?steam'", param, value);
            this.ExecuteNonQuery("DELETE FROM treasure WHERE Identifier = '?steam'", param, value);
            this.ExecuteNonQuery("DELETE FROM user_accounts WHERE Identifier = '?steam'", param, value);
            this.ExecuteNonQuery("DELETE FROM user_inventory WHERE Identifier = '?steam'", param, value);
            this.ExecuteNonQuery("DELETE FROM user_licenses WHERE owner = '?steam'", param, value);
            this.ExecuteNonQuery("DELETE FROM users WHERE Identifier = '?steam'", param, value);
            this.ExecuteNonQuery("DELETE FROM owned_properties WHERE owner = '?steam'", param, value);
            this.ExecuteNonQuery("DELETE FROM datastore_data WHERE owner = '?steam'", param, value);
            this.ExecuteNonQuery("DELETE FROM phone_users_contacts WHERE Identifier = '?steam'", param, value);
        }


    }
}
