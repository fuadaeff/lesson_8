namespace Saitler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Saitler("salam,necesiniz?"));
        }
        static int Saitler(string text)
        {
            string saitler = "aeiouAEİOU";
            int count = 0;

            foreach (char c in text)
            {
                if (saitler.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
