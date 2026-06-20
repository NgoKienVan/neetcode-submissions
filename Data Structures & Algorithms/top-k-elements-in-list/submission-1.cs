public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

        foreach(int i in nums){
            if (!map.ContainsKey(i)) map.Add(i, new List<int>());
            map[i].Add(i);
        }

        var map2 = map.OrderByDescending(v => v.Value.Count);
        List<int> arr = map2.Select(k => k.Key).ToList();
        int[] result = new int[k];
        for(int i = 0; i < k; i++) {
            result[i] = arr[i];
        }

        return result;
    }
}
