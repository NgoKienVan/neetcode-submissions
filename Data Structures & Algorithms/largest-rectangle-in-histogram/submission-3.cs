public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int area = 0;
        Stack<int> stack = new Stack<int>();

        for(int i = 0; i <= heights.Length; i++){
            while(stack.Count > 0 && (i == heights.Length || heights[stack.Peek()] >= heights[i])){
                int height = heights[stack.Pop()];
                int width = stack.Count == 0 ? i : i - stack.Peek() - 1;
                area = Math.Max(area, height * width);
            } 
            stack.Push(i);
        }
        
        return area;
    }
}
