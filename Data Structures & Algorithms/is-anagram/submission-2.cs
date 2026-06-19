public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] s1 = s.ToCharArray();
        char[] t1 = t.ToCharArray();

        // if(s1.Length != t1.Length) return false;

        Array.Sort(s1);
        Array.Sort(t1);

        string s2 = new string(s1);
        string t2 = new string(t1);
        return s2 == t2;
    }
}
