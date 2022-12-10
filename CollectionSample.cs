using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice
{
    public static class CollectionSample
    {
        public static void Queue()
        {
            var q = new Queue();
            q.Enqueue("First item");
            q.Enqueue("Secound item");

            string? item = null;

            while ((item = (string?)q.Dequeue()) != null)
            {
                Console.WriteLine(item);
                if (q.Count <= 0) break;

            }
        }

        public static void Stack()
        {
            var q = new Stack();
            q.Push("First item");
            q.Push("Secound item");

            string? item = null;

            while ((item = (string?)q.Pop()) != null)
            {
                Console.WriteLine(item);
                if (q.Count <= 0) break;

            }
        }
    }
}
