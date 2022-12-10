using System.Collections;

namespace CollectionsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CollectionSample.Queue();
            CollectionSample.Stack();
            return;
            string[] strings = new string[2];
            strings[0] = "First";
            strings[1] = "Secound";

            Console.WriteLine("string : {0}, {1}" ,strings);

            var arrayList = new ArrayList(2);
            arrayList.Add("First");

            arrayList.AddRange(new string[] { "Secound", "third", "Fourth" });

            Console.WriteLine(arrayList.Count);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}