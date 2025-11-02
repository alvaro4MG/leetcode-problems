// 70. Cilmbing Stairs

// You are climbing a staircase. It takes n steps to reach the top.
// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

public class Solution
{

    private Dictionary<int, int> memory = new Dictionary<int, int>();

    public int ClimbStairs(int n)
    {

        if (n <= 2)
        {
            return n;
        }
        if (memory.ContainsKey(n))
        {
            return memory[n];
        }

        int result = ClimbStairs(n - 1) + ClimbStairs(n - 2);

        memory[n] = result;

        return result;

    }
}