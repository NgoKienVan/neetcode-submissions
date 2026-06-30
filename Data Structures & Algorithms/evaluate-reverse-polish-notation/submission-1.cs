public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        foreach(string s in tokens){
            if(s == "+"){
                stack.Push(stack.Pop() + stack.Pop());
            }else if(s == "-"){
                int n1 = stack.Pop();
                int n2 = stack.Pop();
                stack.Push(n2 - n1);
            }else if(s == "*"){
                stack.Push(stack.Pop() * stack.Pop());
            }else if(s == "/"){
                int n1 = stack.Pop();
                int n2 = stack.Pop();
                stack.Push(n2 / n1);
            }else{
                stack.Push(int.Parse(s));
            }
        }
        return stack.Peek();
    }
}
