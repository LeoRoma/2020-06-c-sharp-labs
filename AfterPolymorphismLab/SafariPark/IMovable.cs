using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public interface IMovable
    {
        public string Move();
        string Move(int times);
    }

}
