// 380. Insert Delete GetRandom O(1)

// Implement the RandomizedSet class:
    // RandomizedSet() Initializes the RandomizedSet object.
    // bool insert(int val) Inserts an item val into the set if not present. Returns true if the item was not present, false otherwise.
    // bool remove(int val) Removes an item val from the set if present. Returns true if the item was present, false otherwise.
    // int getRandom() Returns a random element from the current set of elements (it's guaranteed that at least one element exists when this method is called). Each element must have the same probability of being returned.
// You must implement the functions of the class such that each function works in average O(1) time complexity.

public class RandomizedSet {

    private Dictionary<int, int> map;  // val -> index in list
    private List<int> list;
    private Random rnd;

    public RandomizedSet() {
        map = new Dictionary<int, int>();
        list = new List<int>();
        rnd = new Random();
    }

    public bool Insert(int val) {
        if (map.ContainsKey(val)){
            return false;
        }

        list.Add(val);
        map[val] = list.Count - 1;
        return true;
    }

    public bool Remove(int val) {
        if (!map.ContainsKey(val)){
            return false;
        }

        int index = map[val];
        int last = list[list.Count - 1];

        list[index] = last;
        map[last] = index;

        list.RemoveAt(list.Count - 1);
        map.Remove(val);

        return true;
    }

    public int GetRandom() {
        return list[rnd.Next(list.Count)];
    }
}


/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */