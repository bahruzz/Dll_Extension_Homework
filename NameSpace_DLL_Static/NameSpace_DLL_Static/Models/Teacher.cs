using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpace_DLL_Static.Models
{
    internal class Teacher
    {

        public static int Count { get; set; } 

        public Teacher()
        {
            Count++;
        }
    }
}
