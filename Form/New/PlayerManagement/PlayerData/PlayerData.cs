using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangBuilderV2
{
    public class PlayerData
    {

        private List<AccountData> _account_data;
        private List<Billing> _billing;
        private List<OwnedBoats> _owned_boats;
        private List<OwnedProperties> _owned_properties;
        private List<OwnedVehicles> _owned_vehicles;
        private List<PhoneUserContacts> _phone_user_contacts;
        private PlayerTattoos _player_tattoos;
        private List<PropertyItems> _property_items;
        private List<Sim> _sim;
        private List<TruckInventory> _truck_inventory;
        private List<UserInventory> _user_inventory;
        private Users _users;
        private List<UserAccount> _user_account;
        private UserWhitelist _user_whiteliste;

        public List<AccountData> Account_data { get => _account_data; set => _account_data = value; }
        public List<Billing> Billing { get => _billing; set => _billing = value; }
        public List<OwnedBoats> Owned_boats { get => _owned_boats; set => _owned_boats = value; }
        public List<OwnedProperties> Owned_properties { get => _owned_properties; set => _owned_properties = value; }
        public List<OwnedVehicles> Owned_vehicles { get => _owned_vehicles; set => _owned_vehicles = value; }
        public List<PhoneUserContacts> Phone_user_contacts { get => _phone_user_contacts; set => _phone_user_contacts = value; }
        public PlayerTattoos Player_tattoos { get => _player_tattoos; set => _player_tattoos = value; }
        public List<PropertyItems> Property_items { get => _property_items; set => _property_items = value; }
        public List<Sim> Sim { get => _sim; set => _sim = value; }
        public List<TruckInventory> Truck_inventory { get => _truck_inventory; set => _truck_inventory = value; }
        public List<UserInventory> User_inventory { get => _user_inventory; set => _user_inventory = value; }
        public Users Users { get => _users; set => _users = value; }
        public List<UserAccount> User_account { get => _user_account; set => _user_account = value; }
        public UserWhitelist User_whiteliste { get => _user_whiteliste; set => _user_whiteliste = value; }
        public PlayerData(Dictionary<string, Object> _d)
        {
            this.Hydrate(_d);
        }



        private void Hydrate(Dictionary<string, Object> _d)
        {
            foreach (KeyValuePair<string, Object> _k in _d)
            {
                Console.WriteLine("Testing method : {0}", Tools.UcFirst(_k.Key).Trim());
                var method = typeof(AccountData).GetProperty(Tools.UcFirst(_k.Key).Trim());
                if (method != null)
                {
                    Console.WriteLine("Method {0} exists", Tools.UcFirst(_k.Key));
                    method.SetValue(this, _k.Value);

                }
            }
        }

    }
}
