// Q1. LRU Cache

// Design a data structure that follows the constraints of a Least Recently Used (LRU) cache.

// Implement the LRUCache class:
    // LRUCache(int capacity) Initialize the LRU cache with positive size capacity.
    // int get(int key) Return the value of the key if the key exists, otherwise return -1.
    // void put(int key, int value) Update the value of the key if the key exists. Otherwise, add the key-value pair to the cache. If the number of keys exceeds the capacity from this operation, evict the least recently used key.

// The functions get and put must each run in O(1) average time complexity.


public class LFUCache {

    private int maxCap;
    Dictionary<int, int> cache;
    Dictionary<int, int> keyFreq;
    
    Dictionary<int, LinkedList<int>> freqList;
    Dictionary<int, LinkedListNode<int>> nodes;
    int minFreq;

    public LFUCache(int capacity) {
        maxCap = capacity;
        minFreq = 0;

        cache = new Dictionary<int, int>();
        keyFreq = new Dictionary<int, int>();

        freqList = new Dictionary<int, LinkedList<int>>();
        nodes = new Dictionary<int, LinkedListNode<int>>();
    }
    
    public int Get(int key) {
        if (!cache.ContainsKey(key)){
            return -1;
        }

        int value = cache[key];
        int freq = keyFreq[key];
        var node = nodes[key];

        freqList[freq].Remove(node);

        if (freq == minFreq && freqList[freq].Count == 0){
            minFreq++;
        }

        freq++;

        if (!freqList.ContainsKey(freq)){
            freqList[freq] = new LinkedList<int>();
        }


        freqList[freq].AddFirst(node);
        keyFreq[key] = freq;

        return value;
    }
    
    public void Put(int key, int value) {

        if (maxCap == 0){
            return;
        }

        if (cache.ContainsKey(key)){

            cache[key] = value;
            Get(key);  // Reuse exact same logic as Get
            return;
        }


        if (cache.Count == maxCap) {
            int oldKey = freqList[minFreq].Last.Value;

            freqList[minFreq].RemoveLast();
            cache.Remove(oldKey);
            keyFreq.Remove(oldKey);
            nodes.Remove(oldKey);
        }

        var newNode = new LinkedListNode<int>(key);

        cache[key] = value;
        keyFreq[key] = 1;
        nodes[key] = newNode;

        minFreq = 1;

        if (!freqList.ContainsKey(1)){
            freqList[1] = new LinkedList<int>();
        }

        freqList[1].AddFirst(newNode);
    }
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */