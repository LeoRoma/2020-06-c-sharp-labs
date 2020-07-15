using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    class Hunter : Person
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
    }
}
