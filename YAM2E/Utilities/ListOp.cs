using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMP.Utilities;

public static class ListOp
{
    public static void Switch<T>(this List<T> l, int firstIndex, int secondIndex)
    {
        T firstItem = l[firstIndex];
        l[firstIndex] = l[secondIndex];
        l[secondIndex] = firstItem;
    }
}
