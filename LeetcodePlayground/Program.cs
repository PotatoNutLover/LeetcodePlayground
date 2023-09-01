namespace LeetcodePlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new CountingBits().CountBits(5);

            foreach (int i in mas)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}