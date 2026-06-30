public class MinStack {
    private Stack<long> stack;
    private long min;

    public MinStack() {
        stack = new Stack<long>();
    }
    
    public void Push(int val) {
        if(stack.Count == 0){
            stack.Push(0);
            min = val;
        }else{
            stack.Push(val - min);
            if(val < min) min = val;
        }
    }
    
    public void Pop() {
        if(stack.Count == 0) return;
        long pop = stack.Pop();
        if(pop < 0) min -= pop;
    }
    
    public int Top() {
        long top = stack.Peek();
        return top > 0 ? (int)(top + min) : (int)(min);
    }
    
    public int GetMin() {
        return (int)(min);
    }
}