// 70. Climbing Stairs

// You are climbing a staircase. It takes n steps to reach the top.
// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

class Solution {
private:
    unordered_map<int, int> mem;

    int climbing(int n){

        if(n <= 2){
            return n;
        }

        if(mem.contains(n)){
            return mem[n];
        }

        int result = climbing(n-1) + climbing(n-2);

        mem[n] = result;

        return result;
    }
public:
    int climbStairs(int n) {

        if(n == 1){
            return 1;
        }

        return climbing(n);
    }
};