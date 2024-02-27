using System;
namespace TP_Roguelike
{
	public interface ITriggerable
	{
		public abstract void Trigger(Characteristics victim, Characteristics opponent);
        public abstract void Trigger(Characteristics character);
    }
}

