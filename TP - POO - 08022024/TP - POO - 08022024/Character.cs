using System;
namespace TP___POO___08022024
{
	public class Character
	{
		// ATTRIBUTES
		private string name;
		private int healthPoints;
		private Weapon weapon;
		private Armor armor;

		// CONSTRUCTOR
		public Character(string name, int healthPoints, Weapon weapon, Armor armor)
		{
			this.name = name;
			this.healthPoints = healthPoints;
			this.weapon = weapon;
			this.armor = armor;
		}

        // GETTERS AND SETTERS
        public string GetName()
		{
			return name;
		}

		public void SetName(string newName)
		{
			name = newName;
		}

		public int GetHealthPoints()
		{
			return healthPoints;
		}

		public void SetHealthPoints(int newHealthPoints)
		{
			healthPoints = newHealthPoints;
		}

		public Weapon GetWeapon()
		{
			return weapon;
		}

		public void SetWeapon(Weapon newWeapon)
		{
			weapon = newWeapon;
		}

		public Armor GetArmor()
		{
			return armor;
		}

		public void SetArmor(Armor newArmor)
		{
			armor = newArmor;
		}

		// METHODS
		public void Attacked(Character opponent)
		{
			Weapon opponentWeapon = opponent.GetWeapon();
			int opponentDamage = opponentWeapon.GetAttackValue();
			int armorValue = armor.GetProtectionValue();
			healthPoints -= opponentDamage - armorValue;
			if (healthPoints <= 0)
			{
				Console.WriteLine("\nOh no !!!! " + this.name + " has been killed by " + opponent.GetName() + " !");
			} else
			{
                Console.WriteLine("\n" + name + " is getting attacked by " + opponent.GetName() + " !\n\t-" + (opponentDamage - armorValue) + "hp. " + name + " has now " + healthPoints + "hp remaining...");
            }
        }

		public void Display(Character character)
		{
			string name = character.GetName();
			int healthPoints = character.GetHealthPoints();
			string weaponName = weapon.GetName();
			int weaponDamage = weapon.GetAttackValue();
			int armorValue = armor.GetProtectionValue();
            Console.WriteLine(name + " (" + healthPoints + "hp) has the weapon \"" + weaponName
            + "\" (dealing " + weaponDamage + "dmg) and is protected by an armor from " + armorValue + "dmg !");
		}
	}
}

