/*

int[] arr1 = { 1,3,5,7,13 };
int[] arr2 = { 2, 4, 6, 7 };
int[] result = mergeArrays(arr1, arr2);
foreach (int i in result) {
Console.WriteLine($"{i}-");
}
Console.WriteLine();

static int[] mergeArrays(int[] arrA, int [] arrB)
{
    int[] res = new int[arrA.Length+arrB.Length];
    int red = 0;
    int blu = 0;
    int resPos = 0;
    while (red < arrA.Length && blu < arrB.Length)
    {
        if (arrA[red] <= arrB[blu])
        {
            res[resPos] = arrA[red];
            red++;
        }
        else
        {
            res[resPos]= arrA[red];
            blu++;
        }
        resPos++;
    }
    while (red < arrA.Length)
    {
        res[resPos = arrA[red];
        red++;
        resPos++;
    }
    while (red < arrB.Length)
    {
        res[resPos = arrB[blu];
        blu++;
        resPos++;
    }
    return res;
}
*/

/*
//O(n log n)
using System;

class Program {
	public static void Main() {
		int[] array = { 5, 8, 3, -5, 7, 13, 16, 40, -21 };
		int[] sequence = { 8, 7, 13, -21 };
        Console.WriteLine(IsSubsequence(array, sequence));
    }
	
	public static bool IsSubsequence(int[] array, int[] sequence)
    {
        int arrPos = 0;
        int seqPos = 0;
       
        while (arrPos < array.Length)
        {
            if (array[arrPos] == sequence[seqPos]) seqPos++;
            if (seqPos == sequence.Length) return true;
            arrPos++;
            
            }

		return false;
	}

}
*/
/*

using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        LinkedStateNodes linkedStateNodes = new LinkedStateNodes();
        StateNode node1 = new StateNode(1);
        StateNode node2 = new StateNode(2);
        StateNode node3 = new StateNode(3);
        StateNode node4 = new StateNode(4);
        StateNode node5 = new StateNode(5);
        StateNode node6 = new StateNode(6);
        StateNode node7 = new StateNode(7);
        StateNode node8 = new StateNode(8);
        //StateNode node9 = new StateNode(9);

        linkedStateNodes.AddFirst(node1);
        linkedStateNodes.AddLast(node2);
        linkedStateNodes.AddAfter(node1, node3);
        linkedStateNodes.AddFirst(node4);
        linkedStateNodes.AddLast(node5);
        linkedStateNodes.AddLast(node6);
        linkedStateNodes.AddLast(node7);
        linkedStateNodes.AddLast(node8);
        //linkedStateNodes.AddLast(node9);
        linkedStateNodes.RemoveLast();
        linkedStateNodes.RemoveAfter(node5);
        Console.WriteLine(linkedStateNodes.GetStateNodeAtIndex(1)?.code); // 1
        linkedStateNodes.PrintAllLinkedStateNodes(); // 4-1-3-2-5-7-8
    }
}

class StateNode
{
    public int code { get; }
    public StateNode? nextStateNode { get; set; }

    public StateNode(int code)
    {
        this.code = code;
        this.nextStateNode = null;
    }
}

class LinkedStateNodes
{
    StateNode? tail, head;
    int length = 0;

    public LinkedStateNodes()
    {
        this.tail = null;
        this.head = null;
    }

    public StateNode? First()
    {
        // add code here
        return head;
        
    }

    public StateNode? Last()
    {
        // add code here
        return tail;

    }

    public void AddLast(StateNode newStateNode)
    {
        // add code here

       
        if (head == null || tail == null)
        {
            head = newStateNode;
            tail = newStateNode;
        }
        else
        {
            StateNode origLast = tail;
            origLast.nextStateNode = newStateNode;
            tail = newStateNode;
        }
    }

    public void AddFirst(StateNode newStateNode)
    {
        // add code here
        if (head == null || tail == null)
        {
            head = newStateNode;
            tail = newStateNode;
        }
        else
        {
            StateNode origFirst = head;
            head = newStateNode;
            newStateNode.nextStateNode = origFirst;
        }
    }

    public void AddAfter(StateNode prevStateNode, StateNode newStateNode)
    {
        // add code here


        StateNode origNext = prevStateNode.nextStateNode;
        prevStateNode.nextStateNode = newStateNode;
        newStateNode.nextStateNode= origNext;
        
        if (origNext == null)
        {

            //prevStateNode was the tail.

            tail = newStateNode;
        }
    }

    public StateNode? RemoveFirst()
    {
        // add code here
        
        
        StateNode origFirst = head;
        StateNode origSecond = null;
        
        if (origFirst != null)
        {
            origSecond = origFirst.nextStateNode;
        }
        head = origSecond;
        return origFirst;
    }

    public StateNode? RemoveAfter(StateNode prevStateNode)
    {
        // add code here


        StateNode toBeRemoved = prevStateNode.nextStateNode;
        if (toBeRemoved!=null) {
            StateNode nodeAfterOnetoBeRemoved = toBeRemoved.nextStateNode;
            prevStateNode.nextStateNode = nodeAfterOnetoBeRemoved;
        }
        return toBeRemoved;
    }

    public void PrintAllLinkedStateNodes()
    {
        // add code here
    StateNode? current = head;
    while (current != null)
    {
        Console.Write($"{current.code}-");
        current = current.nextStateNode;
    }
    Console.WriteLine();
       
         
    }

    public StateNode? GetStateNodeAtIndex(int n)
    {
        if (n < 0 || n >= length)
        {
            // Invalid index
            return null;
        }

        StateNode current = head;
        int currentIndex = 0;
        while (currentIndex < n && current != null)
        {
            current = current.nextStateNode;
            currentIndex++;
        }

        return current;
    }

    public StateNode? RemoveLast()
    {
        if (head == null || tail == null)
        {
            // List is empty
            return null;
        }
        else if (head == tail)
        {
            // Only one node in the list
            StateNode removedNode = head;
            head = null;
            tail = null;
            return removedNode;
        }
        else
        {
            // Traverse the list to find the second-to-last node
            StateNode current = head;
            while (current.nextStateNode != tail)
            {
                current = current.nextStateNode;
            }

            // Remove the last node and update tail
            StateNode removedNode = tail;
            current.nextStateNode = null;
            tail = current;
            return removedNode;
        }
    }


}
*/


/*
using System;
using System.Collections.Generic;
using System.Text;
public class Node
{
    public Node? left { get; set; } = null;
    public int value { get; }
    public Node? right { get; set; } = null;

    public Node(int value)
    {
        this.value = value;
    }
}

public class BinarySearchTree
{
    public Node? root { get; set; }

    public BinarySearchTree()
    {
        this.root = null;
    }

    public void Insert(int value)
    {
        // add code here
        Node currentRoot = root;
        if (root == null)
        {
            this.root = new Node(value);
            return;
        }
        else
        {
            while (true)
            {
                if (value < currentRoot.value)
                {
                    // go to the left
                    if (currentRoot.left == null)
                    {
                        currentRoot.left = new Node(value);
                        return;
                    }
                    else
                    {
                        currentRoot = currentRoot.left;
                    }

                }
                else
                {
                    // go to the right
                    if (currentRoot.right == null)
                    {
                        currentRoot.right = new Node(value);
                        return;
                    }
                    else
                    {
                        currentRoot = currentRoot.right;
                    }
                }
            }
        }
    }

    public Node? Lookup(int value)
    {
        // add code here
        return null;
    }

    // ##################################################################

    public static int GetMaxDepth(Node? node)
    {
        // add code here
        return 0;
    }

    // ##################################################################

    // Inorder: Left-Parent-Right
    public static void InOrderDFS(Node? node)
    {
        // add code here
        if (node == null) return;
        if (node.left != null) InOrderDFS(node.left); // left
        Console.Write($"{node.value},"); // parent
        if (node.right != null) InOrderDFS(node.left); // right

        

    }

    // Preorder: Parent-Left-Right
    public static void PreOrderDFS(Node? node)
    {
        // add code here


    }

    // Postorder: Left-Right-Parent
    public static void PostOrderDFS(Node? node)
    {
        // add code here
    }
}

public class Program
{
    public static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();
        bst.Insert(40);
        bst.Insert(20);
        bst.Insert(60);
        bst.Insert(10);
        bst.Insert(30);
        bst.Insert(50);
        bst.Insert(80);
        bst.Insert(70);
        bst.Insert(90);
        //bst.Insert(5);
        //bst.Insert(25);
        //bst.Insert(14);
        //bst.Insert(35);
        //bst.Insert(38);
        //bst.Insert(55);
        //bst.Insert(45);

        // ##################################################################

        // Node? search25 = bst.Lookup(25);
        // Console.WriteLine("Searching for 25: "+(search25!=null?"Found":"Not found"));

        // Node? search70 = bst.Lookup(70);
        // Console.WriteLine("Searching for 70: "+(search70!=null?"Found":"Not found"));
        // Console.WriteLine();

        // ##################################################################

        // //Inorder: Left-Parent-Right: 10-20-30-40-50-60-70-80-90-
        // Console.Write("Inorder  : ");
         BinarySearchTree.InOrderDFS(bst.root);
         Console.WriteLine();

        // // Preorder: Parent-Left-Right: 4-2-1-3-6-5-8-7-9-
        // Console.Write("Preorder : ");
        // BinarySearchTree.PreOrderDFS(bst.root);
        // Console.WriteLine();

        // // Postorder: Left-Right-Parent: 1-3-2-5-7-9-8-6-4-
        // Console.Write("Postorder: ");
        // BinarySearchTree.PostOrderDFS(bst.root);
        // Console.WriteLine();
    }
}
*/
/*
using System;

public class Node
{
    public Node? left { get; set; } = null;
    public int value { get; }
    public Node? right { get; set; } = null;

    public Node(int value)
    {
        this.value = value;
    }
}

public class BinarySearchTree
{
    public Node? root { get; set; }

    public BinarySearchTree()
    {
        this.root = null;
    }

    public void Insert(int value)
    {
        Node? currentRoot = root;
        if (root == null)
        {
            this.root = new Node(value);
            return;
        }
        else
        {
            while (true)
            {
                if (value < currentRoot.value)
                {
                    // go to the left
                    if (currentRoot.left == null)
                    {
                        currentRoot.left = new Node(value);
                        return;
                    }
                    else
                    {
                        currentRoot = currentRoot.left;
                    }
                }
                else
                {
                    // go to the right
                    if (currentRoot.right == null)
                    {
                        currentRoot.right = new Node(value);
                        return;
                    }
                    else
                    {
                        currentRoot = currentRoot.right;
                    }
                }
            }
        }
    }

    public Node? Lookup(int value)
    {
        Node? current = root;
        while (current != null)
        {
            if (value == current.value)
            {
                return current;
            }
            else if (value < current.value)
            {
                current = current.left;
            }
            else
            {
                current = current.right;
            }
        }
        return null; // Node with the given value was not found
    }

    public static int GetMaxDepth(Node? node)
    {
        if (node == null)
        {
            return 0;
        }

        int leftDepth = GetMaxDepth(node.left);
        int rightDepth = GetMaxDepth(node.right);

        return Math.Max(leftDepth, rightDepth) + 1;
    }

    public static void InOrderDFS(Node? node)
    {
        if (node == null)
        {
            return;
        }

        InOrderDFS(node.left);
        Console.Write($"{node.value}, ");
        InOrderDFS(node.right);
    }

    public static void PreOrderDFS(Node? node)
    {
        if (node == null)
        {
            return;
        }

        Console.Write($"{node.value}, ");
        PreOrderDFS(node.left);
        PreOrderDFS(node.right);
    }

    public static void PostOrderDFS(Node? node)
    {
        if (node == null)
        {
            return;
        }

        PostOrderDFS(node.left);
        PostOrderDFS(node.right);
        Console.Write($"{node.value}, ");
    }
}

public class Program
{
    public static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();
        bst.Insert(40);
        bst.Insert(20);
        bst.Insert(60);
        bst.Insert(10);
        bst.Insert(30);
        bst.Insert(50);
        bst.Insert(80);
        bst.Insert(70);
        bst.Insert(90);

        Node? search25 = bst.Lookup(25);
        Console.WriteLine("Searching for 25: " + (search25 != null ? "Found" : "Not found"));

        Node? search70 = bst.Lookup(70);
        Console.WriteLine("Searching for 70: " + (search70 != null ? "Found" : "Not found"));
        Console.WriteLine();

        Console.Write("Inorder  : ");
        BinarySearchTree.InOrderDFS(bst.root);
        Console.WriteLine();

        Console.Write("Preorder : ");
        BinarySearchTree.PreOrderDFS(bst.root);
        Console.WriteLine();

        Console.Write("Postorder: ");
        BinarySearchTree.PostOrderDFS(bst.root);
        Console.WriteLine();
    }
}
*/
/*
// O(n^2)
int[] bubble = { 3, 1, 2, 6, 8, 1, 9, 5, 33 };

for (int i = 0; i < bubble.Length; i++)
{
    for (int j = 0; j < bubble.Length - i - 1; j++)
    {
        if (bubble[j] > bubble[j+1])
        {
            int temp = bubble[j];
            bubble[j] = bubble[j+1];
            bubble[j+1] = temp;
        }
    }
    Console.Write(bubble[i] + " ");

}

*/