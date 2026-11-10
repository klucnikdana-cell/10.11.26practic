namespace _10._11._26_practic_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------TASK1----------\n");
           FileContent fileC = new FileContent();

            Console.WriteLine("Enter file path: ");
            string path = Console.ReadLine();

            fileC.FileContenting(path);

            Console.WriteLine("\n----------TASK2----------\n");
            Array arr = new Array();
            arr.Save();
        }
    }
}
