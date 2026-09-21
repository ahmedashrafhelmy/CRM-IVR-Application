namespace siebel.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string org = "";
            string old = "";
            string neww = "";
            Console.Write("please enter your name: ");
            org = Console.ReadLine();
            Console.Write("please enter your name: ");
            old = Console.ReadLine();
            Console.Write("please enter your name: ");
            neww = Console.ReadLine();
            string replacess = org.Replace($"{old}", $"{neww}", StringComparison.OrdinalIgnoreCase); 

            Console.WriteLine(replacess);





        }
    }
}
