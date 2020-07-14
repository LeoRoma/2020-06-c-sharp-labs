using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SafariPark
{
    public struct Point3D
    {
        //Struct is a value type data type to compare to class, it helps to store some volatile value, wehre we don't store them permantely
        public int x, y, z;
        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        
    }
}
