namespace ModerateLC
{
    public static class NeedleHaystack
    {
        //Wall clock faster, More memory intensive
        public static int NeedleHaystackWithStringMethods(string needle, string haystack)
        {
            if (haystack.Contains(needle))
            {
                return haystack.IndexOf(needle);;
            }
            else
            {
                return -1;
            }
        }

        public static int NeedleHaystackKMP(string needle, string haystack)
        {
            int nLen = needle.Length;
            int hLen = haystack.Length;

            //Longest Prefix Suffix Array
            int[] lps = new int[nLen];
            int nIndex = 0;
            
            ComputeLPSArray(needle, nLen, lps);

            int hIndex = 0;
            while ((hLen - hIndex) >= (nLen - nIndex))
            {
                if (needle[nIndex] == haystack[hIndex])
                {
                    nIndex++;
                    hIndex++;
                }

                if (nIndex == nLen)
                {
                    return hIndex - nIndex;
                }
                else if (hIndex < hLen && needle[nIndex] != haystack[hIndex])
                {
                    if (nIndex != 0)
                        nIndex = lps[nIndex - 1];
                    else
                        hIndex++;
                }
            }
            
            return -1;
        }

        static void ComputeLPSArray(string needle, int nLen, int[] lps)
        {
            //length of previous longest prefix suffix
            int len = 0;
            int i = 1;
            
            lps[0] = 0;

            while (i < nLen)
            {
                if (needle[i] == needle[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = len;
                        i++;
                    }
                }
            }
        }
    }
}