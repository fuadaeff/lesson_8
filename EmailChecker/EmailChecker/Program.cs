namespace EmailChecker
{
    internal class Program
    {
        static void Main()
        {
            string email = "fabdulla057@gmail.com";
            Console.WriteLine(IsEmail(email) ? "Email is correct" : "Email is incorrect");
        }

        static bool IsEmail(string email)
        {
            if (!email.Contains('@') || !email.Contains('.'))
            {
                return false;
            }
            int EtIndex = email.IndexOf('@');
            int NoqteIndex = email.LastIndexOf('.');
            if (EtIndex <= 0 || EtIndex == email.Length - 1)
            {
                return false;
            }
            if (NoqteIndex < EtIndex + 2 || NoqteIndex == email.Length - 1)
            {
                return false;
            }
            return true;
        }
    }
}
