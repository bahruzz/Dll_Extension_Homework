﻿

namespace NameSpace_DLL_Static.Helpers.Extensions
{
    internal  static class TextExtension
    {
        public static int GetLength (this string str)
        {
            return str.Length;
        }
        public static bool CheckCharinText(this string text,char letter)
        {
            return text.Contains(letter);
        }
        public static int CountOfCharInText(this string text,char letter)
        {
            int count= 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == letter)
                {
                    count++;
                }
                
            }
            return count;
            //return text.ToArray().Where(m=>m==letter).Count();
        }

    }

}
