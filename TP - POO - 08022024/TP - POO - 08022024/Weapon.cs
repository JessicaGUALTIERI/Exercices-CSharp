using System;
namespace TP___POO___08022024
{
	public class Weapon
	{
        // ATTRIBUTES
        private string name;
		private int attackValue;

		// CONSTRCUTOR
		public Weapon(string name, int attackValue)
		{
			this.name = name;
			this.attackValue = attackValue;
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

		public int GetAttackValue()
		{
			return attackValue;
		}

		public void SetAttackValue(int newAttackValue)
		{
			attackValue = newAttackValue;
		}
	}
}

