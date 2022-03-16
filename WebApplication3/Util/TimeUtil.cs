using System.Globalization;

namespace EmptyASPNETCore.Util
{
    public class TimeUtil
    {
        public static List<string> MonthNames => 
            CultureInfo.CurrentCulture.DateTimeFormat.MonthNames.Take(12).ToList();
    }
}
