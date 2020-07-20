using ClassesApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
	public class Hunter : Person, IShootable
	{
	
		public IShootable Shooter { get; set; }


		public Hunter(string fName, string lName, IShootable shooter = null) : base(fName, lName)
		{
			Shooter = shooter;
		}

		public Hunter()
		{
		}

		public string Shoot()
		{
			var msg = GetFullName();
			if (Shooter == null)
			{
				msg += " doesn't have a shooter";
			}
			else
			{
				msg += $": { Shooter.Shoot()}";
			}
			return msg;
		}

		public override string ToString()
		{
			var msg = base.ToString();
			if (Shooter != null)
			{
				msg += $" Shooter: {Shooter}";
			}
			return msg;
		}

	}

	//public class MonsterHunter : Hunter
	//{
	//	private string _weapon;
	//	public MonsterHunter(string fName, String lName, string camera, string weapon) : base(fName, lName)		
	//	{
	//		_weapon = weapon;			
	//	}

	//	public sealed override string ToString()

	//	{
	//		return $"{base.ToString()} Weapon: {_weapon}";
	//	}

	//}

}
