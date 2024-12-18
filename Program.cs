// See https://aka.ms/new-console-template for more information

//StackTest();
using DataStructures;

//QueueTest();

BinarySearchTreeTest();

void StackTest() {
    DataStructures.Stack stack = new DataStructures.Stack();

    stack.Push("Madhur");
    stack.Push("Salony");
    stack.Push("Henry");

    Console.WriteLine($"Peek - {stack.Peek()}");
    stack.Pop();
    stack.Pop();
    stack.Pop();
    stack.Push("Reeshan");
    stack.Push("Alex");
    stack.Push("Jimmy");
    stack.PeekAll();
    stack.Pop();
    stack.Pop();
}

void BinarySearchTreeTest() {
    BinarySearchTree tree = new BinarySearchTree();

    tree.Insert(5);
    tree.Insert(89);
    tree.Insert(15);
    tree.Insert(24);
    tree.Insert(67);
    tree.Insert(90);

    if(tree.Lookup(567)) {
        Console.WriteLine("Found");
    }
    if(!tree.Lookup(4)) {
        Console.WriteLine("Not Found");
    }
}

void LinkListTest() {
    Console.WriteLine("Hello, World!");

LinkList list = new LinkList();
list.Append("Madhur");
list.Append("Salony");

Console.WriteLine($"Count is {list.GetCount()}");
list.Append("Henry");
Console.WriteLine($"Count is {list.GetCount()}");

list.PrintElements();
list.Prepend("Reeshan");
list.PrintElements();
list.Insert(0, "Sushma");
Console.WriteLine($"Count is {list.GetCount()}");
list.PrintElements();

list.Insert(5,"Pradeep");
list.PrintElements();
list.Insert(3, "Deepshikha");

Console.WriteLine("Before Removal");
list.PrintElements();

list.Remove(2);
Console.WriteLine("After Removal");
list.PrintElements();
}

 void QueueTest() {

    DataStructures.Queue queue = new DataStructures.Queue();

    queue.Enqueue("Madhur");
    queue.Enqueue("Salony");
    queue.Enqueue("Henry");

    //Console.WriteLine($"Peek - {queue.()}");
    queue.Dequeye();
    queue.Dequeye();
    queue.Dequeye();
    queue.Enqueue("Reeshan");
    queue.Enqueue("Alex");
    queue.Enqueue("Jimmy");
   // queue.PeekAll();
    queue.Dequeye();
    queue.Dequeye();

}