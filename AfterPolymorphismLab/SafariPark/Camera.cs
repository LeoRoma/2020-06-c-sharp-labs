using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
	class Camera : IShootable
	{
		private string _brand;
		public Camera(string brand)
		{
			_brand = brand;
		}

		public string Shoot()
		{
			return $"Shooting a {ToString()}";
		}

		public override string ToString()
		{
			return $"{base.ToString()} - {_brand}";
		}
	}
}
