namespace LinkedListProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To LinkedListProgram");
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Add(56);
            linkedList.Append(30);
            linkedList.Display();
            linkedList.Add(70);
            linkedList.Display();
        }
    }
}
