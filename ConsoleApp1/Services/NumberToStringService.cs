using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services;

internal class NumberToStringService
{
    public static string GetNumberStr(int num)
    {
        //1.
        if (num == 0)
            return "صفر";
        else if (num == 1)
            return "یک";
        else if (num == 2)
            return "دو";
        else if (num == 3)
            return "سه";
        else if (num == 4)
            return "چهار";
        else if (num == 5)
            return "پنج";
        else if (num == 6)
            return "شش";
        else if (num == 7)
            return "هفت";
        else if (num == 8)
            return "هشت";
        else if (num == 9)
            return "نه";

        return "عدد نامعتبر";
    }
}
