using System;
namespace TP_MethodeGenerique
{
	public class PickRandomElement<T>
	{
		public List<T> List = new List<T>();

        public void Add(T item)
		{
			List.Add(item);
		}

		public T GetAndRemove()
		{
            Random random = new Random();
            int randomIndex = random.Next(0, List.Count);
			T valueRemoved = List[randomIndex];
            List.RemoveAt(randomIndex);
			return valueRemoved;
        }

		public void DisplayList()
		{
			Console.Write("[ ");
			foreach (T element in List)
			{
				Console.Write(element + " ");
			}
			Console.WriteLine("]");
		}
	}
}

