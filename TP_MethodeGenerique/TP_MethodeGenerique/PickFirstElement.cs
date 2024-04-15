using System;
namespace TP_MethodeGenerique
{
	public class PickFirstElement<T>
	{
        public List<T> List = new List<T>();

        public void Add(T item)
        {
            List.Add(item);
        }

        public T GetAndRemove()
        {
            T valueRemoved = List[0];
            List.RemoveAt(0);
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



