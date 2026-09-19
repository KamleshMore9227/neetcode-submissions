public class Solution {
    public bool IsPalindrome(string s) {
        var length = s.Length;
        var start = 0;
        var end = length - 1;

        while(start < end){
            if(!isValidLetter(s[start])){
                start++;
                // Console.WriteLine("first condition");
                continue;
            }
            else if(!isValidLetter(s[end])){
                end--;
                // Console.WriteLine("second condition");
                continue;
            }

            if(char.ToLower(s[start]) != char.ToLower(s[end])){
                // Console.WriteLine("main condition");
                return false;
            }

            
            // Console.WriteLine("time to update vars");

            start++;
            end--;

        }

        return true;

    }

    private bool isValidLetter(char c){
        return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');
    }
}
