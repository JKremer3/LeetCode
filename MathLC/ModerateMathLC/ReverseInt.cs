namespace ModerateMathLC
{
    public static class ReverseInt
    {
        public static int reverseInt(int val)
        {
            int res = 0;

            while (val != 0)
            {
                int tail = val % 10;
                int newRes = res * 10 + tail;
                
                //check for overflow
                if ((newRes - tail) / 10 != res)
                {
                    return 0;
                }

                res = newRes;
                val = val / 10;
            }
            
            return res;
        }
    }
}