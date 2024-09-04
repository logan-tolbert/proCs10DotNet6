using static System.Console;
using static System.DateTime;

namespace StaticDataAndMembers;

public class TimeUtilClass
{
    // Static classes can only contain static members

    public static void PrintTime()
       => WriteLine(Now.ToShortTimeString());

    public static void PrintDate()
        => WriteLine(Today.ToShortDateString());


}
