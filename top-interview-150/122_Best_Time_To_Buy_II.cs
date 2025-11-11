// 122. Best Time to Buy and Sell Stock II

// You are given an array prices where prices[i] is the price of a given stock on the ith day.
// On each day, you may decide to buy and/or sell the stock. You can only hold at most one share of the stock at any time. However, you can sell and buy the stock multiple times on the same day, ensuring you never hold more than one share of the stock.
// Find and return the maximum profit you can achieve.

public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int min = prices[0];

        for(int i = 1; i < prices.Length; i++){
            if(prices[i] < min){
                min = prices[i];
            }else{
                if( (prices[i] - min) > maxProfit){
                    maxProfit = prices[i] - min;
                }
            }
        }

        return maxProfit;
    }
}