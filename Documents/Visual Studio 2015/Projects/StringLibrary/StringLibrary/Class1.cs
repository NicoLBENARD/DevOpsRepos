using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLibrary
{
    public static bool StartsWithUpper(this String str)
    {
        if (String.IsNullOrWhiteSpace(str))
            return false;

        Char ch = str[0];
        return Char.IsUpper(ch);
    }
}
}
    