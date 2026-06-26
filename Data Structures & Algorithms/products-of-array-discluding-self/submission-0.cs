public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int p = 1;
        int zCount = 0;

        foreach(int n in nums){
            if(n != 0) p *= n;
            else zCount++;
        }

        if(zCount > 1) return new int[nums.Length];

        int[] res = new int[nums.Length];
        
        for(int i = 0; i < nums.Length; i++){
            if(zCount > 0){
                if(nums[i] == 0) res[i] = p;
                else res[i] = 0;
            }
            else res[i] = p / nums[i];
        }

        return res;
    }
}
