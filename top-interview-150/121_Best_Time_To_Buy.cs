// 121. Best Time to Buy and Sell Stock

// You are given an array prices where prices[i] is the price of a given stock on the ith day.
// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
// Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        //int maxProfitTemp = 0;    //removed for better memory complexity
        int min = prices[0];

        for(int i = 1; i < prices.Length; i++){
            if(prices[i] < min){
                min = prices[i];
            }else{
                //maxProfitTemp = prices[i] - min;
                if( (prices[i] - min) > maxProfit){
                    maxProfit = prices[i] - min;
                }
            }
        }

        return maxProfit;
    }
}