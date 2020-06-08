using System;
using System.Collections.Generic;
using System.Text;

namespace BreakfastTesting
{
    public static class ExtensionsList
    {
        public static string Print(this List<Eggs> myList)
        {
            return myList.Count + " eggs";
        }
    }
}
