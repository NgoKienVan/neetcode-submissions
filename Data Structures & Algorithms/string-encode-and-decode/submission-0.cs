public class Solution {

    public string Encode(IList<string> strs) {
        if(strs.Count == 0) return "";

        List<int> sizes = new List<int>();
        StringBuilder result = new StringBuilder();

        foreach(string s in strs){
            sizes.Add(s.Length);
        }

        foreach(int size in sizes){
            result.Append(size).Append(',');
        }

        result.Append('@');

        foreach(string s in strs){
            result.Append(s);
        }

        return result.ToString();
    }

    public List<string> Decode(string s) {
        if(s.Length == 0) return new List<string>();

        List<int> sizes = new List<int>();
        List<string> res = new List<string>();
        int i = 0;

        while(s[i] != '@'){
            int j = i;
            while(s[j] != ','){
                j++;
            }
            sizes.Add(int.Parse(s.Substring(i, j - i)));
            i = j + 1;
        }

        i++;

        foreach(int size in sizes){
            res.Add(s.Substring(i, size));
            i += size;
        }
        return res;
   }
}
