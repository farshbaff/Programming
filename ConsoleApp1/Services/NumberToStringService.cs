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
        //if (num == 0)
        //    return "صفر";
        //else if (num == 1)
        //    return "یک";
        //else if (num == 2)
        //    return "دو";
        //else if (num == 3)
        //    return "سه";
        //else if (num == 4)
        //    return "چهار";
        //else if (num == 5)
        //    return "پنج";
        //else if (num == 6)
        //    return "شش";
        //else if (num == 7)
        //    return "هفت";
        //else if (num == 8)
        //    return "هشت";
        //else if (num == 9)
        //    return "نه";

        //return "عدد نامعتبر";

        //2.
        //var result = "عدد نامعتبر";

        //if (num == 0)
        //    result = "صفر";
        //else if (num == 1)
        //    result = "یک";
        //else if (num == 2)
        //    result = "دو";
        //else if (num == 3)
        //    result = "سه";
        //else if (num == 4)
        //    result = "چهار";
        //else if (num == 5)
        //    result = "پنج";
        //else if (num == 6)
        //    result = "شش";
        //else if (num == 7)
        //    result = "هفت";
        //else if (num == 8)
        //    result = "هشت";
        //else if (num == 9)
        //    result = "نه";

        //return result;

        var result = string.Empty;

        switch (num)
        {
            case 0:
                result = "صفر"; break;
            case 1:
                result = "یک"; break;
            case 2:
                result = "دو"; break;
            case 3:
                result = "سه"; break;
            case 4:
                result = "چهار"; break;
            case 5:
                result = "پنج"; break;
            case 6:
                result = "شش"; break;
            case 7:
                result = "هفت"; break;
            case 8:
                result = "هشت"; break;
            case 9:
                result = "نه"; break;
            default:
                result = "عدد نامعتبر"; break;
        }

        return result;
    }
}
