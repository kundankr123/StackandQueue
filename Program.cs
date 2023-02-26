namespace StackandQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Stack and Queue Master Branch.");

            //Stack<int> stack = new Stack<int>();
            //stack.Push(56);
            //stack.Push(30);
            //stack.Push(70);

            //foreach (int ele in stack)
            //{
            //    Console.WriteLine(ele);
            //}

            //while(stack.Count > 0)
            //{
            //    Console.WriteLine("****************");
            //    Console.WriteLine("Top element : " + stack.Peek());
            //    Console.WriteLine("****************");
            //    stack.Pop();
            //}


            Queue<int> queue = new Queue<int>();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            foreach (int ele in queue)
            {
                Console.WriteLine(ele);
            }

        }
    }
}