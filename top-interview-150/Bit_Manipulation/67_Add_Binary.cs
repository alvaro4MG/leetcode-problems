// 67. Add Binary

// Given two binary strings a and b, return their sum as a binary string.

public class Solution {
    public string AddBinary(string a, string b) {
        int size = Math.Max(a.Length, b.Length);
        bool plusOne = false;
        int sum = 0;
        char[] result = new char[size+1];
        int ia = a.Length - 1;
        int ib = b.Length - 1;

        for (int i = size; i > 0; i--) {
            if (ia >= 0 && a[ia] == '1') sum++;
            if (ib >= 0 && b[ib] == '1') sum++;
            if (plusOne) sum++;

            result[i] = (char)('0' + (sum % 2));
            plusOne = (sum > 1);
            sum = 0;

            ia--;
            ib--;
        }

        if(plusOne){
            result[0] = '1';
        }else{
            result[0] = '0';
        }
        string final = new string(result).TrimStart('0');

        if(final.Length == 0){
            return "0";
        }else{
            return final;
        }

    }
}