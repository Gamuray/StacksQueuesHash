using System;
using System.Collections.Generic;

namespace WassonStackNQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = "";
            Console.WriteLine("Would you like to use stack or queue?" +
                "\nStack" +
                "\nQueue" +
                "\nHashTable" +
                "\nExit");

            while(input != "Exit")
            {
                input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case "STACK":
                        StackedList myStack = new StackedList();

                        Console.WriteLine("This program implements a stack..." +
                            "\nCommands:\n" +
                            "\n1: Push item [name]" +
                            "\n2: Pull next item" +
                            "\n3: Read next item" +
                            "\n4: Read all items" +
                            "\n0: Empty the stack" +
                            "\nX: Stop");

                        while (!input.StartsWith("X"))
                        {
                            input = Console.ReadLine().ToUpper();

                            if (input != null)
                            {
                                switch (input)
                                {

                                    case "1":
                                        Console.WriteLine("\nEnter new name:");
                                        String name = Console.ReadLine();
                                        myStack.pushToStack(name);

                                        break;

                                    case "2":
                                        String pullResult = myStack.pullFromStack();

                                        if (pullResult != null)
                                        {
                                            Console.WriteLine("\nItem " + pullResult + " has been pulled.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nEmpty Stack.");
                                        }

                                        break;

                                    case "3":
                                        String readResult = myStack.pullFromStack();

                                        if (readResult != null)
                                        {
                                            Console.WriteLine("\nNext item is stack: " + readResult);
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nEmpty Stack.");
                                        }

                                        break;

                                    case "4":
                                        Console.WriteLine("\nItems in stack:\n");
                                        if (myStack != null)
                                        {
                                            myStack.readAll();
                                        }
                                        else
                                        {
                                            Console.WriteLine("No stack.");
                                        }

                                        break;

                                    case "0":
                                        myStack.emptyStack();
                                        break;

                                    case "X":
                                        Console.WriteLine("\n\nStopping...\n\n");
                                        break;

                                    default:
                                        Console.WriteLine("Invalid input.");
                                        break;

                                }

                            }


                        }

                        break;

                    case "QUEUE":
                        QueueList myQueue = new QueueList();

                        Console.WriteLine("This program implements a queue..." +
                            "\nCommands:\n" +
                            "\n1: Enqueue item [name]" +
                            "\n2: Dequeue next item" +
                            "\n3: Read next item" +
                            "\n4: Read all items" +
                            "\n0: Empty the queue" +
                            "\nX: Stop");

                        while (!input.StartsWith("X"))
                        {
                            input = Console.ReadLine().ToUpper();

                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine("\nEnter new name:");
                                    String name = Console.ReadLine();
                                    myQueue.enqueueList(name);

                                    break;

                                case "2":
                                    String deQResult = myQueue.dequeueList();

                                    if (deQResult != null)
                                    {
                                        Console.WriteLine("\nItem " + deQResult + " has been pulled.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nEmpty Queue.");
                                    }

                                    break;

                                case "3":
                                    String readResult = myQueue.readNext();

                                    if (readResult != null)
                                    {
                                        Console.WriteLine("\nNext item is queue: " + readResult);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nEmpty Queue.");
                                    }

                                    break;

                                case "4":
                                    Console.WriteLine("\nItems in queue:\n");
                                    if (myQueue != null)
                                    {
                                        myQueue.readAll();
                                    }
                                    else
                                    {
                                        Console.WriteLine("No stack.");
                                    }

                                    break;

                                case "0":
                                    myQueue.emptyList();
                                    
                                    break;

                                case "X":
                                    Console.WriteLine("\n\nStopping...\n\n");
                                    break;

                                default:
                                    Console.WriteLine("Invalid input.");
                                    break;
                            }
                        }

                        break;

                    case "HASHTABLE":
                        HashTable<String> myHash = new HashTable<String>(10);

                        Console.WriteLine("This program implements a hashmap..." +
                            "\nCommands:\n" +
                            "\n1: Add item [name][key]" +
                            "\n2: Get value of item [key]" +
                            "\n3: Delete item [key]" +
                            "\nX: Stop");

                        while (!input.StartsWith("X"))
                        {
                            input = Console.ReadLine().ToUpper();

                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine("\nEnter new name:");
                                    String name = Console.ReadLine();
                                    Console.WriteLine("Enter key:");
                                    String keyAdd = Console.ReadLine();
                                    myHash.AddItem(keyAdd, name);

                                    Console.WriteLine("Added " + name);

                                    break;

                                case "2":
                                    Console.WriteLine("\nEnter key:");
                                    String keyFind = Console.ReadLine();
                                    String hashResult = myHash.GetValue(keyFind);

                                    if (hashResult != null)
                                    {
                                        Console.WriteLine("\nValue of keyed node is:\n" + hashResult);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nItem not found or empty table.");
                                    }

                                    break;

                                case "3":
                                    Console.WriteLine("Enter key:");
                                    String keyDelete = Console.ReadLine();
                                    String readResult = myHash.DeleteItem(keyDelete);
                                    if (readResult != null)
                                    {
                                        Console.WriteLine("\nDeleted " + readResult);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nItem not found or empty table.");
                                    }

                                    break;

                                case "X":
                                    Console.WriteLine("\n\nStopping...\n\n");
                                    break;

                                default:
                                    Console.WriteLine("Invalid input.");
                                    break;
                            }
                        }


                        break;

                    case "EXIT":
                        break;

                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }              
            }       
        }
    }

    class StackedList
    {
        List<String> stackedList = new List<string>();

        public void pushToStack(String name)
        {
            stackedList.Add(name);
        }

        public String pullFromStack()
        {
            if (stackedList.Count != 0)
            {
                var pulledName = stackedList[stackedList.Count - 1];

                stackedList.RemoveAt(stackedList.Count - 1);
                return pulledName;
            }
            else
            {
                return null;
            }

        }

        public String readNext()
        {
            if (stackedList != null && stackedList.Count > 0)
            {
                return stackedList[stackedList.Count - 1];
            }

            return null;
        }

        public void readAll()
        {
            int total = stackedList.Count-1;
            while(total >= 0)
            {
                Console.WriteLine(readIndex(total));
                total--;
            }
        }

        public String readIndex(int index)
        {
            try
            {
                return stackedList[index];
            }
            catch (NullReferenceException)
            {
                return "Index was out of bounds.";
            }
        }

        public void emptyStack()
        {
            Console.WriteLine("\nConfirm stack deletion (Y/N)...");
            String confirmation = Console.ReadLine().ToUpper();

            if (confirmation.StartsWith("Y"))
            {
                stackedList.RemoveRange(0, stackedList.Count);
                Console.WriteLine("Confirmation accepted. Stack emptied.");
            }
            else
            {
                Console.WriteLine("\nNo confirmation. Stack retained.");
            }
        }
    }

    class QueueList
    {
        List<String> queueList = new List<string>();

        public String enqueueList(String name)
        {
            try
            {
                queueList.Add(name);
                return name;
            }
            catch (NullReferenceException)
            {
                return "";
            }
        }

        public String dequeueList()
        {
            if(queueList.Count > 0)
            {
                try
                {
                    String itemName = queueList[0];
                    queueList.RemoveAt(0);
                    return itemName;
                }
                catch (NullReferenceException)
                {
                    return "Item not found.";
                }
            }
            else
            {
                return null;
            }
        }

        public String readNext()
        {
            if(queueList.Count > 0 && queueList[0] != null)
            {
                    return queueList[0];
            }
            else
            {
                return null;
            }
        }

        public void readAll()
        {
            if(queueList.Count > 0)
            {
                Console.WriteLine("\nQueued items:\n");
                for(int i = 0; i < queueList.Count; i++)
                {
                    Console.WriteLine(queueList[i]);
                }
            }
            else
            {
                Console.WriteLine("Empty list.");
            }
        }

        public void emptyList()
        {
            if(queueList.Count > 0)
            {
                try
                {
                    queueList.RemoveRange(0, queueList.Count);
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Index not found.");
                }

            }
            else
            {
                Console.WriteLine("Empty List.");
            }
        }



    }

    class Node<Generic>
    {
        public Node<Generic> next;
        public String key;
        public Generic value;
               
    }

    public class HashTable<Generic>
    {
        Node<Generic>[] buckets;

        public HashTable(int size)
        {
            buckets = new Node<Generic>[size];
        }

        public Generic GetValue(String key)
        {
            var (prevNode, keyedNode) = FindNodeByHash(key); //Locate the node via given keys

            if(keyedNode == null)
            {
                Console.WriteLine("Key not found.");
                return default;
            }
            return keyedNode.value;

        }

        public void AddItem(String key, Generic item)
        {
            var newNode = new Node<Generic> //newNode has following attributes
            {key = key, value = item, next = null};

            int position = FindBucketByHash(key); //Locate the appropriate bucket
            Node<Generic> nodeList = buckets[position]; //Start at front of bucket

            if(nodeList == null) //if this list is empty, start it with this new node
            {
                buckets[position] = newNode;
            }
            else
            {
                while(nodeList.next != null) //if the list has nodes, traverse to the end and tack on the new node
                {
                    nodeList = nodeList.next;
                }
                nodeList.next = newNode;
            }
        }

        public Generic DeleteItem(String key)
        {
            var (prevNode, keyedNode) = FindNodeByHash(key); //Locate the node via given key
            

            if(keyedNode == null)
            {
                Console.WriteLine("Key not found.");
            }
            else
            {
                var removedValue = keyedNode.value;
                if(prevNode != null)
                {
                    prevNode.next = null;
                }
                else
                {
                    buckets[FindBucketByHash(key)] = null;
                }
                return removedValue;
            }
            return default;

        }

        public int FindBucketByHash(String key)
        {
            int hashedKey = key.GetHashCode() % buckets.Length;
            if (hashedKey < 0)
            {
                hashedKey *= -1;
            }
            return hashedKey; //get the hash code of the key, this identifies the appropriate bucket
        }

        (Node<Generic>, Node<Generic>) FindNodeByHash(String key) //Locates node with given key value
        {
            int position = FindBucketByHash(key); //Locate proper bucket
            Node<Generic> nodeList = buckets[position]; //List to traverse is the bucket we found
            Node<Generic> prevNode = null; //Pointer to parent

            while(nodeList != null) //If there are items in the list, traverse it
            {
                if(nodeList.key == key) //If we find the node, return it and its parent (parent helpful for deletion)
                {
                    return (prevNode, nodeList);
                }

                prevNode = nodeList; //traversal
                nodeList = nodeList.next;
            }

            return (null, null); //if not found
        }


    }
}
