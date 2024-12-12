public class LinkList {
    public LinkListNode Head {get;set;}
    public LinkListNode Tail {get;set;}

    private int Count {get;set;}

    public LinkList() {
        Count = 0;
    }

    public void Append(string value) {
        var node = new LinkListNode(value);

        if(Count == 0) {
            Head = node;
            Tail = node;
        } 
        else {
            Tail.Next = node;
            Tail = node;
        }
        Count++;
    }

    public int GetCount() {
        return Count;
    }

    public void Prepend(string value) {
        var node = new LinkListNode(value);
        node.Next = Head;
        Head = node;

        if(Count == 0) {
            Tail = node;
        }

        Count++;
    }

    public void PrintElements() {
        var start = Head;

        while(start != null) {
            Console.WriteLine(start.Value);
            start = start.Next;
        }
    }

    public void Insert(int index, string value) {
        if(index == 0) {
            Prepend(value);
            return;
        }

        if(index == Count) {
            Append(value);
            return;
        }

        if(index > Count) {
            Console.WriteLine("Invalid INdex");
            return;
        }

        var current = Head;
        for(int i=0 ; i<index-1 ; i++) {
            current = current.Next;
        }
         var node = new LinkListNode(value);
         node.Next = current.Next;
         current.Next = node;
    }

    public void Remove(int index) {
         if(index == 0) {
            Head = Head.Next;
            Count--;
            return;
        }

        var current = Head;
        for(int i=0 ; i<index-1 ; i++) {
            current = current.Next;
        }

        var remove = current.Next;

        current.Next = remove.Next;
        Count--;

    }

}