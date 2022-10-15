namespace LinkedListProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To LinkedListProgram");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(76);
            list.Display();
            list.AddingAtParticularPosition(2, 30);
            list.Display();
        }
    }
}
