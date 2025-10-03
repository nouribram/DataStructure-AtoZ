/*
========================================
 Introduction to Data Structures
========================================
- Definition: A systematic way of organizing, storing, and retrieving data efficiently.
- Why Data?
  * Efficiency → reduces execution time
  * Memory Optimization → saves space
  * Scalability → supports real-world applications
- Categories:
  1. Primitive DS – int, float, char, bool
  2. Non-Primitive DS – Arrays, Lists, Stacks, Queues, Trees, Graphs, Hashing

========================================
Classification of Data Structures
========================================
- Linear Structures: Array, Linked List, Stack, Queue
- Non-Linear Structures: Trees, Graphs
- Hash-based: Hash Table / Hash Map

========================================
Arrays
========================================
- Definition: Collection of homogeneous elements in contiguous memory.
- Operations:
  * Access O(1), Search O(n), Insert/Delete O(n)
- Advantages: Easy random access, cache-friendly
- Disadvantages: Fixed size, costly insert/delete
- Uses: Lookup tables, matrices, leaderboards

========================================
 Linked List
========================================
- Definition: Nodes with data + pointer to next/prev.
- Types: Singly, Doubly, Circular
- Operations: Traversal O(n), Insert/Delete O(1) if pointer known
- Advantages: Dynamic size, efficient insertion/deletion
- Disadvantages: Extra memory for pointers, no random access
- Uses: Music playlists, image galleries, undo/redo

========================================
Slide 5 – Stack (LIFO)
========================================
- Definition: Last In, First Out
- Operations: Push, Pop, Peek (all O(1))
- Applications:
  * Function calls (call stack)
  * Undo/Redo in editors
  * Expression evaluation
- Analogy: Stack of plates

========================================
 Queue (FIFO)
========================================
- Definition: First In, First Out
- Operations: Enqueue, Dequeue (O(1))
- Types: Simple, Circular, Deque, Priority
- Applications:
  * CPU scheduling
  * Ticket booking systems
  * BFS in graphs

========================================
 Trees
========================================
- Definition: Hierarchical structure with root and children.
- Terminologies: Root, Parent, Child, Leaf, Height, Depth
- Types: Binary Tree, BST, AVL, Heap, B-Tree
- Complexity: Balanced BST → O(log n)
- Applications: File systems, Databases, Routing, AI decision trees

========================================
 Graphs
========================================
- Definition: Set of vertices connected by edges.
- Types: Directed/Undirected, Weighted/Unweighted
- Representation: Adjacency Matrix, Adjacency List
- Algorithms: BFS, DFS
- Applications: Social networks, Google Maps, Web Crawling

========================================
 Hashing & Conclusion
========================================
- Definition: Maps keys → values using hash functions.
- Operations: Insert, Search, Delete O(1) average
- Collision Handling: Chaining, Open Addressing
- Applications: Databases, Passwords, Caching (DNS)
- Conclusion:
  * Data Structures are backbone of efficient coding.
  * Choosing right DS = Fast + Scalable solutions.
  * Master path: Arrays → Lists → Stacks/Queues → Trees → Graphs → Hashing

*/
