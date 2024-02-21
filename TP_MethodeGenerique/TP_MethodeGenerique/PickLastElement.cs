using System;
namespace TP_MethodeGenerique
{
	public class PickLastElement<T>
	{
        public List<T> List = new List<T>();

        public void Add(T item)
        {
            List.Add(item);
        }

        public T GetAndRemove()
        {
            T valueRemoved = List[List.Count - 1];
            List.RemoveAt(List.Count - 1);
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

