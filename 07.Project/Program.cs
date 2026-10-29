namespace _07.Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
               int num = int.Parse(Console.ReadLine());
                s = s + num;
            }
            Console.WriteLine(s);
        }
    }
}
