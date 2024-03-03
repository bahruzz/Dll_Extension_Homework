

namespace NameSpace_DLL_Static.Models
{
    internal  class Doctor
    {
        public static int ID { get; set; }
        public static string Name { get; set; }

        //public Doctor()
        //{
        //    ID = 400;
        //}

        static Doctor()
        {
            Console.WriteLine("Static constructor");

        }
        public Doctor()
        {
            Console.WriteLine("Non-Static constructor");
        }
    }
}
