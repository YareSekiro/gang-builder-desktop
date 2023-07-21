using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangBuilderV2
{
    class QueryConfig
    {
        //Fields : id, account_name, money, owner
        public static String QueryForAccountData { get; } = "SELECT * FROM addon_account_data WHERE owner = ?steam";
        //Fields : id, inventory_name, name, count, owner
        public static String QueryForPropertyItems { get; } = "SELECT * FROM addon_inventory_items WHERE owner = ?steam";
        //Fields : id, identifier, sender, target_type, target, label, amount
        public static String QueryForBilling { get; } = "SELECT * FROM billing WHERE identifier = ?steam";
        //Fields : id, name, price, rented, owner
        public static String QueryForOwnedProperties { get; } = "SELECT * FROM owned_properties WHERE owner = ?steam";
        //Fields : id, vehicle, owner, state, stored, plate, type, job
        public static String QueryForOwnedBoats { get; } = "SELECT * FROM owned_slz WHERE owner = ?steam";
        //Fields : id, vehicle, owner, stored, state, plate, type, job
        public static String QueryForOwnedVehicles { get; } = "SELECT * FROM owned_vehicles WHERE owner = ?steam";
        //Fields : id, identifier, number, display
        public static String QueryForPhoneUserContacts { get; } = "SELECT * FROM phone_users_contacts WHERE identifier = ?steam";
        //Fields : id, identifier, tattoos
        public static String QueryForPlayerTattoos { get; } = "SELECT * FROM playerTattoos WHERE identifier = ?steam";
        //Fields : identifier, phone_number
        public static String QueryForSim { get; } = "SELECT * FROM sim WHERE identifier = ?steam";
        //Fields : id, item, itemt, count, plate, owned, ammo
        public static String QueryForTruckInventory { get; } = "SELECT * FROM truck_inventory WHERE plate = ?plate";
        //Fields : identifier, license, money, name, skin, org, org_gradeorg, job, job_grade, loadout
        //position, bank, permission_level, group, animal, firstname, lastname, dateofbirth, sex, height
        //last_property, status, vote, is_dead, tattoos, jail, lastdigits, crypted_phone_number, last_connexion
        //phone_number
        public static String QueryForUsers { get; } = "SELECT * FROM users WHERE identifier = ?steam";
        //Fields : id, identifier, name, money
        public static String QueryForUsersAccount { get; } = "SELECT * FROM user_accounts WHERE identifier = ?steam";
        //Fields: id, identifier, item, count
        public static String QueryForUserInventory { get; } = "SELECT * FROM user_inventory WHERE identifier = ?steam";
        //Fields : identifier
        public static String QueryForUserWhitelist { get; } = "SELECT * FROM whitelist WHERE identifier = ?steam";

    }
}
