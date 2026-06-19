public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] s1 = s.ToCharArray();
        char[] t1 = t.ToCharArray();

        if(s1.Length != t1.Length) return false;

        Array.Sort(s1);
        Array.Sort(t1);

        for(int i = 0; i < s1.Length; i++){
            if(s1[i] != t1[i]) return false;
        }
        return true;
    }
}
