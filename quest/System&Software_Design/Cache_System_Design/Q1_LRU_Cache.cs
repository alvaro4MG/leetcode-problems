// Q1. LRU Cache

// Design a data structure that follows the constraints of a Least Recently Used (LRU) cache.

// Implement the LRUCache class:
    // LRUCache(int capacity) Initialize the LRU cache with positive size capacity.
    // int get(int key) Return the value of the key if the key exists, otherwise return -1.
    // void put(int key, int value) Update the value of the key if the key exists. Otherwise, add the key-value pair to the cache. If the number of keys exceeds the capacity from this operation, evict the least recently used key.

// The functions get and put must each run in O(1) average time complexity.


public class LRUCache {

    private int maxCap;
    Dictionary<int, LinkedListNode<(int key, int value)>> cache;
    LinkedList<(int key, int value)> usageOrder;

    public LRUCache(int capacity) {
        maxCap = capacity;
        cache = new Dictionary<int, LinkedListNode<(int key, int value)>>();
    }
    
    public int Get(int key) {
        
        
        return -1;
    }
    
    public void Put(int key, int value) {
        
        cache.Add(key, new LinkedListNode<(int key, int value)>((key, value)));

    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */