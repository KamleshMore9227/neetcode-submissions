public class Solution {
    public int MaxProfit(int[] prices) {
        var max = 0;

        for(int i = 0; i < prices.Length; i++){
            for(int j = i + 1; j < prices.Length; j++){
                if(prices[j] - prices[i] > max){
                    max = prices[j] - prices[i];
                }
            }
        }

        return max;
    }
}
