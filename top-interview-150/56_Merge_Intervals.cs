// 56. Merge Intervals (Intervals)

// Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.

public class Solution {
    public int[][] Merge(int[][] intervals) {
        int[][] result;
        int ranges = intervals.GetLength(0);    //ir disminuyendo si se quita un rango
        int minRange = 10001;
        int maxRange = -1;

        //List<int[]> lista = new List<int[]>();
        //lista.Add(new int[] { 0, 1 });

        //intervals.Length = [0]*[1];   //para rectangular, todas las filas tienen el mismo tamaño, si varía es jagged y Length da el número de filas
        //intervals.GetLength(0) = [0];
        //intervals.GetLength(1) = [1];

        while(true){
            for(int i = 0; i < intervals.GetLength(0); i++){
                if(intervals[i[0] < minRange]){
                    minRange = intervals[i[0];
                }
            }

            //buscar si está en otro intervalo
            //NO: se añade sin más 
            //SI: mezclarlo
        }

        return result:
    }
}