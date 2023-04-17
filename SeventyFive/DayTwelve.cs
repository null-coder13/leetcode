namespace SeventyFive
{
    public class DayTwelve
    {

        // # 438. Find All Anagrams in a String
        public IList<int> FindAnagrams(string s, string p)
        {
            if (s.Length < p.Length) return new List<int>();

            Dictionary<char, int> pMap = CreateDictionary(p);

            List<int> indexes = new List<int>();

            for (int i = 0; i < s.Length; i++)
            {
                Dictionary<char, int> window = CreateDictionary(s.Substring(i, p.Length));
                if (Compare(pMap, window)) indexes.Add(i);
            }

            return indexes;
        }

        public Dictionary<char, int> CreateDictionary(string s)
        {
            Dictionary<char, int> newdict = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (newdict.ContainsKey(s[i]))
                {
                    newdict[s[i]] += 1;
                }
                else 
                {
                    newdict.Add(s[i], 1);
                }
            }
            return newdict;
        }

        public bool Compare(Dictionary<char, int> p, Dictionary<char,int> window)
        {
            if (p.Count != window.Count) return false;

            foreach(KeyValuePair<char, int> v in p)
            {
                if (!window.ContainsKey(v.Key)) return false;
                if (window[v.Key] != v.Value) return false;
            }
            return true;
        }
    }


}
