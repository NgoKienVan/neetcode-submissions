public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> stack = new Stack<int>();
        int[] res = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length; i++){
            int t = temperatures[i];
            while(stack.Count > 0 && t > temperatures[stack.Peek()]){
                int index = stack.Pop();
                res[index] = i - index;
            }
            stack.Push(i);
        }
        return res;
    }
}
