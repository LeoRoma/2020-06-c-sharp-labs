using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace SafariPark
{
    public class Hunter : Person
    {
        private string _camera;

        public Hunter(string fName, string lName, string camera = "") : base(fName, lName) //Base rappresent Parent or Superclass
        {
            _camera = camera;
        }

        // Cannot have an argument less in the constructor once is inheritated, unless in the Parent Child already exists one.
        public Hunter()
        {

        }
        
        public string Shoot()
        {
            return $"{GetFullName()} has taken a photo with their {_camera}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Camera {_camera}";
        }
    }

    public class MonsterHunter : Hunter
    {
        private string _weapon;
        public MonsterHunter(string fName, string lName, string camera, string weapon) : base(fName, lName, camera)
        {
            _weapon = weapon;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Weapon {_weapon}";
        }
    }
}
