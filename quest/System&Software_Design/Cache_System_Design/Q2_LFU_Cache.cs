// Q1. LRU Cache

// Design a data structure that follows the constraints of a Least Recently Used (LRU) cache.

// Implement the LRUCache class:
    // LRUCache(int capacity) Initialize the LRU cache with positive size capacity.
    // int get(int key) Return the value of the key if the key exists, otherwise return -1.
    // void put(int key, int value) Update the value of the key if the key exists. Otherwise, add the key-value pair to the cache. If the number of keys exceeds the capacity from this operation, evict the least recently used key.

// The functions get and put must each run in O(1) average time complexity.


public class LFUCache {

    private int maxCap;
    Dictionary<int, LinkedListNode<(int key, int value)>> cache;
    LinkedList<(int key, int value)> usageOrder;

    public LFUCache(int capacity) {
        maxCap = capacity;
        cache = new Dictionary<int, LinkedListNode<(int key, int value)>>();
        usageOrder = new LinkedList<(int key, int value)>();
    }
    
    public int Get(int key) {
        
        if(cache.ContainsKey(key)){
            // Adjust value of LFU before return value
            var node = cache[key];
            usageOrder.Remove(node);
            usageOrder.AddFirst(node);

            return node.Value.value;
        }

        return -1;
    }
    
    public void Put(int key, int value) {

        if (cache.ContainsKey(key)){
            var node = cache[key];
            node.Value = (key, value);
            usageOrder.Remove(node);
            usageOrder.AddFirst(node);
            return;
        }

        if (cache.Count == maxCap){
            cache.Remove(usageOrder.Last.Value.key);
            usageOrder.RemoveLast();
        }

        var newNode = new LinkedListNode<(int,int)>((key, value));
        cache.Add(key, newNode);
        usageOrder.AddFirst(newNode);
    }
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */