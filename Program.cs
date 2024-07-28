namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            int front = queue.Peek();
            Console.WriteLine(front); // Outputs 1

            // The queue still contains all its elements
            while (queue.Count > 0)
            {
                int item = queue.Dequeue();

                Console.WriteLine(item); // Outputs 1, 2, 3
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            while ( stack.Count > 0)
            {
                int item = stack.Pop();
                Console.WriteLine(item); // Output 4,3,2,1
            }




        }
    }
}
