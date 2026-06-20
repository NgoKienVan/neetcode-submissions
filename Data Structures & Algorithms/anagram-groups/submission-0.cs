public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> hashmap = new Dictionary<string, List<string>>();

        foreach(string s in strs){
            char[] c = s.ToCharArray();
            Array.Sort(c);
            string key = new string(c);

            if(!hashmap.ContainsKey(key)) hashmap.Add(key, new List<string>());
        
            hashmap[key].Add(s);
        }

        return hashmap.Values.ToList();
    }
}
