

namespace Homework.Helper.Extensions
{
    internal static class Login
    {
        public static bool CheckCharinEmail(this string text, char letter)
        {
            return text.Contains(letter);
        }


        public static bool GetPasswordLength(this string password)
        {
            if (password.Length > 8)
            {
                return true;
            }
            return false;
        }
    }
}
