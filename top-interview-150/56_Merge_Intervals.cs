// 56. Merge Intervals (Intervals)

// Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.

public class Solution {

    private void Sort(int[][] intervals){
        int[] aux;
        
        for (int i = 0; i < (intervals.GetLength(0) - 1); i++) {
            for (int j = 0; j < (intervals.GetLength(0) - i - 1); j++) {
                if (intervals[j][0] > intervals[j + 1][0]) {
                    aux = intervals[j];
                    intervals[j] = intervals[j + 1];
                    intervals[j + 1] = aux;
                }
            }
        }

    }

    public int[][] Merge(int[][] intervals) {

        if(intervals.GetLength(0) < 2){
            return intervals;
        }

        List<int[]> lista = new List<int[]>();
        //Sort(intervals);
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));


        int start = intervals[0][0];
        int end = intervals[0][1];

        for(int i = 0; i < intervals.GetLength(0); i++){
            
            if(intervals[i][0] <= end){
                end = Math.Max(end, intervals[i][1]);
            }else{
                lista.Add(new int[] { start, end });
                start = intervals[i][0];
                end = intervals[i][1];
            }
            

        }
        lista.Add(new int[] { start, end });

        return lista.ToArray();
    }
}