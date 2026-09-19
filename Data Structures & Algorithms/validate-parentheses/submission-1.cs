public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();

        foreach(char c in s){
            if(isStarterBracket(c)){
                stack.Push(c);
            }
            else{
                if(stack.Count > 0 && 
                ((stack.Peek() == '(' && c == ')') || 
                (stack.Peek() == '{' && c == '}') ||
                (stack.Peek() == '[' && c == ']')) 
                ){
                    stack.Pop();
                }
                else{
                    return false;
                }
            }
        }

        return stack.Count == 0;

    }

    private bool isStarterBracket(char c){
        return c == '(' || c == '{' || c == '[';
    }
}
