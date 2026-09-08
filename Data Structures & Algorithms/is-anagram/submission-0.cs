public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] counts1 = new int[26];
        int[] counts2 = new int[26];

        foreach (char c in s){
            counts1[c -'a']++;
        }

        foreach (char c in t){
            counts2[c -'a']++;
        }

        for (int i = 0; i < 26; i++){
            if(counts1[i] != counts2[i]){
                return false;
            }
        }

        return true;
    }
}
