public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int imin = 1000;
        int jmin = 1000;
        for(int i = 0; i < nums.Length - 1; i++){
            for(int j = i + 1; j < nums.Length; j++){
                if(nums[i] + nums[j] == target){
                    if(imin > i) imin = i;
                    if(jmin > j) jmin = j;
                }
            }
        }
        return [imin, jmin];
    }
}
