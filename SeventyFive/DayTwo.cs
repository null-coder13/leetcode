namespace SeventyFive
{
    public class DayTwo
    {

        public bool IsIsomorphic(string s, string t)
        {
            IDictionary<char, List<int>> charDict = new Dictionary<char, List<int>>();

            char[] sArray = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (!charDict.ContainsKey(sArray[i]))
                {
                    charDict.Add(sArray[i], new List<int> { i });
                }
                else
                {
                    charDict[sArray[i]].Add(i);
                }
            }

            bool test = false;

            return false;
        }

        public bool IsSubsequence(string s, string t)
        {
            bool isSub = true;
            int lastIndexOfT = 0;
            for (int i = 0; i < s.Length; i++)
            {
                bool foundChar = false;
                for (int j = lastIndexOfT; j < t.Length; j++)
                {
                    if (s[i] == t[j])
                    {
                        foundChar = true;
                        lastIndexOfT = j + 1;
                        break;
                    }
                }

                if (!foundChar)
                {
                    isSub = false;
                    break;
                }
            }
            return isSub;
        }
    }


}
