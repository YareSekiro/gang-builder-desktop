using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangBuilderV2
{
    public class Users
    {
        private List<Object> _identifier;
        private List<Object> _license;
        private List<Object> _money;
        private List<Object> _name;
        private List<Object> _skin;
        private List<Object> _org;
        private List<Object> _org_grade_org;
        private List<Object> _job;
        private List<Object> _job_grade;
        private List<Object> _loadout;
        private List<Object> _position;
        private List<Object> _bank;
        private List<Object> _permission_level;
        private List<Object> _group;
        private List<Object> _animal;
        private List<Object> _firstname;
        private List<Object> _lastname;
        private List<Object> _dateofbirth;
        private List<Object> _sex;
        private List<Object> _height;
        private List<Object> _last_property;
        private List<Object> _status;
        private List<Object> _vote;
        private List<Object> _is_dead;
        private List<Object> _tattoos;
        private List<Object> _jail;
        private List<Object> _lastdigits;
        private List<Object> _crypted_phone_number;
        private List<Object> _last_connexion;
        private List<Object> _phone_number;

                public List<object> Identifier { get => _identifier; set => _identifier = value; }
        public List<object> License { get => _license; set => _license = value; }
        public List<object> Money { get => _money; set => _money = value; }
        public List<object> Name { get => _name; set => _name = value; }
        public List<object> Skin { get => _skin; set => _skin = value; }
        public List<object> Org { get => _org; set => _org = value; }
        public List<object> Org_grade_org { get => _org_grade_org; set => _org_grade_org = value; }
        public List<object> Job { get => _job; set => _job = value; }
        public List<object> Job_grade { get => _job_grade; set => _job_grade = value; }
        public List<object> Loadout { get => _loadout; set => _loadout = value; }
        public List<object> Position { get => _position; set => _position = value; }
        public List<object> Bank { get => _bank; set => _bank = value; }
        public List<object> Permission_level { get => _permission_level; set => _permission_level = value; }
        public List<object> Group { get => _group; set => _group = value; }
        public List<object> Animal { get => _animal; set => _animal = value; }
        public List<object> Firstname { get => _firstname; set => _firstname = value; }
        public List<object> Lastname { get => _lastname; set => _lastname = value; }
        public List<object> Dateofbirth { get => _dateofbirth; set => _dateofbirth = value; }
        public List<object> Sex { get => _sex; set => _sex = value; }
        public List<object> Height { get => _height; set => _height = value; }
        public List<object> Last_property { get => _last_property; set => _last_property = value; }
        public List<object> Status { get => _status; set => _status = value; }
        public List<object> Vote { get => _vote; set => _vote = value; }
        public List<object> Is_dead { get => _is_dead; set => _is_dead = value; }
        public List<object> Tattoos { get => _tattoos; set => _tattoos = value; }
        public List<object> Jail { get => _jail; set => _jail = value; }
        public List<object> Lastdigits { get => _lastdigits; set => _lastdigits = value; }
        public List<object> Crypted_phone_number { get => _crypted_phone_number; set => _crypted_phone_number = value; }
        public List<object> Last_connexion { get => _last_connexion; set => _last_connexion = value; }
        public List<object> Phone_number { get => _phone_number; set => _phone_number = value; }



        public Users(Dictionary<string, List<Object>> _d)
        {
            this.Hydrate(_d);
        }


        private void Hydrate(Dictionary<string, List<Object>> _d)
        {
            foreach (KeyValuePair<string, List<Object>> _k in _d)
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
