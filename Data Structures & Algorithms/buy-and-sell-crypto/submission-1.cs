public class Solution {
    public int MaxProfit(int[] prices) {
        var lowest = prices[0];
        var maxprofit = 0;

        foreach(int i in prices){
            if(i < lowest){
                lowest = i;
            }

            if(i - lowest > maxprofit){
                maxprofit = i - lowest;
            }
        }

        return maxprofit;
    }
}
