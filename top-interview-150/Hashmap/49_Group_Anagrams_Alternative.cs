// 49. Group Anagrams

// Given an array of strings strs, group the anagrams together. You can return the answer in any order.

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        IList<IList<string>> result = new List<IList<string>>();
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        //foreach(string word in strs){
        for(int i = 0; i < strs.Length; i++){

            char[] chars = strs[i].ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if(map.TryGetValue(key, out var list)) {
                list.Add(strs[i]);
            }else{
                //List<string> newList = new List<string>{strs[i]};
                //map.Add(key,newList);
                map[key] = new List<string> { strs[i] };
            }


        }

        foreach(var value in map.Values){
            result.Add(value);
        }

        return result;

    }
}