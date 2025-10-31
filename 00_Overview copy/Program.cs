/*
  Introduction to Data Structures in C#
  Data structures are ways of organizing and storing data so that operations 
  like access, search, insertion, and deletion can be performed efficiently.

  Every program relies on data structures — from simple arrays to complex trees and graphs.
*/

using System;
using System.Collections.Generic;

namespace CSharpTutorial
{
    class DataStructures_Introduction
    {
        static void Main(string[] args)
        {
            /*
              WHAT IS A DATA STRUCTURE?
              --------------------------
              A data structure is a way to organize, manage, and store data efficiently 
              so it can be used effectively.
            */

            Console.WriteLine("Data Structures organize data for efficient use.\n");

            /*
              WHY ARE DATA STRUCTURES IMPORTANT?
              ----------------------------------
              Efficiency — Speeds up data operations.
              Reusability — Reusable patterns for solving problems.
              Manageability — Easier to handle large or complex data.
              Optimization — Reduces time and memory usage.
            */

            Console.WriteLine("Key Benefits of Data Structures:");
            Console.WriteLine("- Efficiency");
            Console.WriteLine("- Reusability");
            Console.WriteLine("- Manageability");
            Console.WriteLine("- Optimization");
            Console.WriteLine("-----------------------------");

            /*
              BASIC TYPES OF DATA STRUCTURES
              ------------------------------
              1. Primitive Data Structures  → int, float, bool, char
              2. Non-Primitive Data Structures:
                 a. Linear (Array, List, Stack, Queue)
                 b. Non-Linear (Tree, Graph)
                 c. Hash-based (Dictionary, HashSet)
            */

            Console.WriteLine("Main Types of Data Structures:");
            Console.WriteLine("1. Primitive (int, float, bool, etc.)");
            Console.WriteLine("2. Non-Primitive:");
            Console.WriteLine("   a. Linear: Array, List, Stack, Queue");
            Console.WriteLine("   b. Non-Linear: Tree, Graph");
            Console.WriteLine("   c. Hash-based: Dictionary, HashSet");
            Console.WriteLine("-----------------------------");

            /*
              EXAMPLES OF COMMON DATA STRUCTURES IN C#
              ----------------------------------------
            */

            // 1Array — Fixed-size collection
            int[] numbers = { 10, 20, 30, 40 };
            Console.WriteLine("Array Example:");
            foreach (int n in numbers)
                Console.WriteLine(n);

            Console.WriteLine("-----------------------------");

            // List<T> — Dynamic-size collection
            List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };
            fruits.Add("Orange");
            Console.WriteLine("List Example:");
            foreach (string fruit in fruits)
                Console.WriteLine(fruit);

            Console.WriteLine("-----------------------------");

            // Stack<T> — Last In, First Out (LIFO)
            Stack<string> stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            Console.WriteLine("Stack Example:");
            Console.WriteLine("Top Element: " + stack.Peek());
            Console.WriteLine("Removed: " + stack.Pop());

            Console.WriteLine("-----------------------------");

            // Queue<T> — First In, First Out (FIFO)
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine("Queue Example:");
            Console.WriteLine("First Element: " + queue.Peek());
            Console.WriteLine("Dequeued: " + queue.Dequeue());

            Console.WriteLine("-----------------------------");

            // Dictionary<TKey, TValue> — Key-value storage
            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                { "Alice", 25 },
                { "Bob", 30 },
                { "Charlie", 28 }
            };
            Console.WriteLine("Dictionary Example:");
            foreach (var pair in ages)
                Console.WriteLine(pair.Key + " → " + pair.Value);

            Console.WriteLine("-----------------------------");

            /*
              CHOOSING THE RIGHT DATA STRUCTURE
              ---------------------------------
              Use Arrays → When size is fixed.
              Use Lists → When size changes frequently.
              Use Stacks/Queues → For specific order control.
              Use Dictionaries → For quick lookups by key.
              Use Trees/Graphs → For hierarchical or networked data.
            */

            Console.WriteLine("Choose data structures based on your problem needs!");
        }
    }
}

/*
  SUMMARY:
  ----------
  Data Structure = Organized way to store and manage data.
  Two main types: Primitive and Non-Primitive.
  Examples: Array, List, Stack, Queue, Dictionary.
  Efficient programs depend on choosing the right data structure.
*/
