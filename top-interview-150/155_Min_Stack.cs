// 155. Min Stack

// Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
// Implement the MinStack class:
    // MinStack() initializes the stack object.
    // void push(int val) pushes the element val onto the stack.
    // void pop() removes the element on the top of the stack.
    // int top() gets the top element of the stack.
    // int getMin() retrieves the minimum element in the stack.
// You must implement a solution with O(1) time complexity for each function.

public class MinStack {

    private Stack<int> stack;
    private int index;
    private int minimum;

    public MinStack() {
        stack = new Stack<int>();
        index = 0;
        minimum = int.MaxValue;
    }
    
    public void Push(int val) {

        if(index < stack.Count){
            stack[index] = val;
        }else{
            stack.Add(val);
        }
        index++;

        if(val < minimum){
            minimum = val;
        }
    }
    
    public void Pop() {
        index--;

        //check if minimum
    }
    
    public int Top() {
        return stack[index];
    }
    
    public int GetMin() {
        return minimum;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */