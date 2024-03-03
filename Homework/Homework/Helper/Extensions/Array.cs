using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Helper.Extensions
{
    internal static class Array
    {
        public static int MultipliArrayElements(this int[] array)
        {
            int result = 1;
            foreach (var element in array)
            {
                result *= element;
            }
            return result;
            
        }
    }
}
