using System;
namespace TP___POO___08022024
{
	public class Armor
	{
        // ATTRIBUTES
        private string name;
        private int protectionValue;

        // CONSTRCUTOR
        public Armor(string name, int protectionValue)
        {
            this.name = name;
            this.protectionValue = protectionValue;
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

        public int GetProtectionValue()
        {
            return protectionValue;
        }

        public void SetProtectionValue(int newProtectionValue)
        {
            protectionValue = newProtectionValue;
        }
    }
}

