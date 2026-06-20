public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        foreach(int i in nums){
            if(map.ContainsKey(i)) map[i]++;
            else map[i] = 1;
        }

        List<int> arr = map.OrderByDescending(v => v.Value).Select(k => k.Key).ToList();
        int[] result = new int[k];
        for(int i = 0; i < k; i++) {
            result[i] = arr[i];
        }

        return result;
    }
}
