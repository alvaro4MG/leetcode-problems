// 20. Valid Parentheses (Stack)

// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
// An input string is valid if:
    // Open brackets must be closed by the same type of brackets.
    // Open brackets must be closed in the correct order.
    // Every close bracket has a corresponding open bracket of the same type.

public class Solution {
    public bool IsValid(string s) {
        char[] open = ['(','{','['];
        char[] close = [')','}',']'];
        char tmp;
        Stack<char> stack = new Stack<char>();

        for(int i = 0; i < s.Length; i++){
            if(open.Contains(s[i]) ){
                //pile
                stack.Push(s[i]);
            }else{
                //check stack
                if(stack.Count == 0){
                    return false;
                }
                tmp = stack.Pop();
                if(Array.IndexOf(open, tmp) != Array.IndexOf(close, s[i]) ){
                    return false;
                }
            }
        }

        return (stack.Count == 0);
    }
}