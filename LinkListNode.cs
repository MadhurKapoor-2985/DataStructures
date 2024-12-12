public class LinkListNode {
    public string Value {get;set;}
    public LinkListNode Next {get;set;}

    public LinkListNode(string value) {
        this.Value = value;
        this.Next = null;
    }
}