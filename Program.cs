// See https://aka.ms/new-console-template for more information

StackTest();

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
    stack.Pop();
    stack.Pop();
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