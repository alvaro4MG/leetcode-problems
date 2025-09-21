// 71. Simplify Path (Stack)

// You are given an absolute path for a Unix-style file system, which always begins with a slash '/'. Your task is to transform this absolute path into its simplified canonical path.

// The rules of a Unix-style file system are as follows:
    // A single period '.' represents the current directory.
    // A double period '..' represents the previous/parent directory.
    // Multiple consecutive slashes such as '//' and '///' are treated as a single slash '/'.
    // Any sequence of periods that does not match the rules above should be treated as a valid directory or file name. For example, '...' and '....' are valid directory or file names.
// The simplified canonical path should follow these rules:
    // The path must start with a single slash '/'.
    // Directories within the path must be separated by exactly one slash '/'.
    // The path must not end with a slash '/', unless it is the root directory.
    // The path must not have any single or double periods ('.' and '..') used to denote current or parent directories.
// Return the simplified canonical path.

public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> stack = new Stack<string>();
        string current;
        int index;

        for(int i = 0; i < path.Length; i++){
            if(path[i] == '/'){
                while(i < (path.Length - 1) && path[i+1] == '/'){
                    i++;
                }
                
            }else if(path[i] == '.'){
                
                if((i+1) < path.Length && path[i+1] == '.'){
                    if((i+2) < path.Length && path[i+2] != '/'){
                        //name of folder
                        index = 0;
                        while((i + index) < path.Length && path[i+index] != '/'){
                            index++;
                        }
                        current = path.Substring(i, index);
                        stack.Push(current);
                        i += index;
                    }else{
                        //previous folder (..)
                        if(stack.Count > 0){
                            stack.Pop();
                        }
                        i++;
                    }

                }else{
                    //current folder
                    if(i+1 < path.Length && path[i+1] != '/'){
                        index = 0;
                        while((i + index) < path.Length && path[i+index] != '/'){
                            index++;
                        }
                        current = path.Substring(i, index);
                        stack.Push(current);
                        i += index;
                    }else{
                        i++;
                    }
                    
                }
            }else{
                index = 0;
                while((i + index) < path.Length && path[i+index] != '/'){
                    index++;
                }
                current = path.Substring(i, index);
                stack.Push(current);
                i += (index - 1);
            }
        }
        
        current = "/" + string.Join("/", stack.Reverse());
        return current;
    }
}