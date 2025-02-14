namespace StrongPassword
{
    internal class Program
    {
        static void Main()
        {
            string password = "passWord9876@#";
            Console.WriteLine(IsStrongPassword(password) ? "password is strong." : "password isn't strong.");
        }

        static bool IsStrongPassword(string password)
        {
            if (password.Length < 8)
                return false;
            bool boyuk = false, kicik = false, reqem = false, simvol = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    boyuk = true;
                }
                else if (char.IsLower(c))
                {
                    kicik = true;
                }
                else if (char.IsDigit(c))
                {
                    reqem = true;
                }
                else
                {
                    simvol = true;
                }
            }
            return boyuk && kicik && reqem && simvol;
        }
    }
}
