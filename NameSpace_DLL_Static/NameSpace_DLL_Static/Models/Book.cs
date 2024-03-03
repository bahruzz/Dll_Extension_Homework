

using NameSpace_DLL_Static.Helpers.Extensions;
using Services;

namespace NameSpace_DLL_Static.Models
{
    internal class Book:Person
    {
        public Book()
        {
            Id = 10;

        }
        static Book()
        {
            int a = 5;
            Console.WriteLine(a.PowerOfNums(2));
        }

    }
}
