public class Solution {
    //O(nLogn)
    public bool hasDuplicate(int[] nums) {        
        
        //O(nLogn)
        Array.Sort(nums);

        //O(n)
        for(int i = 0; i < nums.Length - 1; i++){
            if (nums[i] == nums[i+1]){
                return true;
            }
        }
        return false;
    }
}