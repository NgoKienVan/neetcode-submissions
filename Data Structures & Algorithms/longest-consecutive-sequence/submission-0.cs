public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> h = new HashSet<int>(nums);
        int max = 0;

        foreach(int num in nums){
            if(!h.Contains(num - 1)){
                int len = 1;
                while(h.Contains(num + len)){
                    len++;
                }

                max = Math.Max(max, len);
            }
        }

        return max;
    }
}
