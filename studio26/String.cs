using System;
namespace studio26
{
    public class String
    {
        public static bool IsNumeric(string s)
        {
            double i = 0;
            bool result = double.TryParse(s, out i);
            if (result)
            {
                return true;
            }
            return false;
        }
    }
}
