using System;
namespace TP___POO___08022024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 Consigne :
                 Créer trois classes : 
                    'character' :
                        - attributs : 'name', 'hp', 'weapon', 'armor'
                        - méthodes : 'attack', 'display'
                    'weapons' :
                        - attributs : 'name', 'attackValue'
                    'armor' :
                        - attributs : 'name', 'protectionValue'
            */

            Weapon axe = new Weapon("Darius' Axe", 25);
            Weapon bow = new Weapon("Ashe's Bow", 40);

            Armor bigArmor = new Armor("Tank's armor", 25);
            Armor littleArmor = new Armor("ADC's armor", 5);

            Character toplaner = new Character("Darius", 100, axe, bigArmor);
            Character adc = new Character("Ashe", 60, bow, littleArmor);

            adc.Display(adc);
            toplaner.Display(toplaner);
            Console.WriteLine();

            while (adc.GetHealthPoints() > 0 && toplaner.GetHealthPoints() > 0)
            {
                adc.Attacked(toplaner);
                if (adc.GetHealthPoints() > 0)
                {
                    toplaner.Attacked(adc);
                }
            }
        }
    }
}