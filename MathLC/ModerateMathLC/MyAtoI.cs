using System;

namespace ModerateMathLC
{
    public class MyAtoI
    {
        public static int MyAtoi(string s)
        {
            bool isNegative = false;
            int ret = 0, i = 0;

            if (s.Length == 0)
                return 0;

            while (i < s.Length)
            {
                if (s[i] == ' ') //Progress the loop if whitespace
                {
                    i++;
                }
                else if (s[i] == '-' || s[i] == '+') // break loop and move to next character if sign is found
                {
                    isNegative = s[i] == '-';
                    i++;
                    break;
                }
                else if (char.IsDigit(s[i])) //No sign is found, break loop and process digits
                {
                    break;
                }
                else
                {
                    return 0;
                }
            }

            for(; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    var digit = (s[i]-'0');
                    
                    if(Int32.MaxValue/10 < ret || Int32.MaxValue/10 == ret && Int32.MaxValue %10 < digit)
                        return isNegative ? Int32.MinValue : Int32.MaxValue;
                    
                    ret = (10 * ret) + digit;
                }
                else
                {
                    if (isNegative)
                            ret *= -1;
                    return ret;
                }
            }
            
            if (isNegative)
                ret *= -1;
            return ret;
        }
    }
}