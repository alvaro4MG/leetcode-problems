// 274. H-Index

// Given an array of integers citations where citations[i] is the number of citations a researcher received for their ith paper, return the researcher's h-index.
// According to the definition of h-index on Wikipedia: The h-index is defined as the maximum value of h such that the given researcher has published at least h papers that have each been cited at least h times.

// MORE OPTIMAL SOLUTION

public class Solution {
    public int HIndex(int[] citations) {
        int size = citations.Length;
        int[] count = new int[size+1];
        int i;

        for(i = 0; i < size; i++){
            if(citations[i] < (size+1)){
                count[citations[i]]++;
            }else{
                count[size]++;
            }
        }

        int total = 0;
        while(i > 0){
            total += count[i];
            if(total >= i){
                return i;
            }
            i--;
        }

        return 0;
    }
}