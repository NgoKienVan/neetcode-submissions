public class Solution {
    //O(n^2)
    public bool hasDuplicate(int[] nums) {
        int n = nums.Length;
        
        //O(n^2)
        for(int i = 0; i < n-1; i++){
            int min = i;
            for(int j = i + 1; j < n; j++){
                if (nums[min] < nums[j]){
                    min = j;
                }
            }
            int temp = nums[min];
            nums[min] = nums[i];
            nums[i] = temp;
        }

        //O(n)
        for(int i = 0; i < n-1; i++){
            if (nums[i] == nums[i+1]){
                return true;
            }
        }
        return false;
    }
}