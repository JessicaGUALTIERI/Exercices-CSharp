using System;
namespace TP_Roguelike
{
	public class Characteristics
	{
        public int HealthPoints { get; set; }
        public int Attack { get; set; }
        public int Speed { get; set; }

        public Characteristics(int initHealthPoints, int initAttack, int initSpeed)
        {
            HealthPoints = initHealthPoints;
            Attack = initAttack;
            Speed = initSpeed;
        }
	}
}

