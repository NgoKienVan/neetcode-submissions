public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        for(int i = 0; i < numbers.Length - 1; i++){
            for(int j = i + 1; j < numbers.Length; j++){
                if(numbers[i] + numbers[j] == target){
                    i++;
                    j++;
                    return [i, j];
                }
            }
        }
        return [];
    }
}
