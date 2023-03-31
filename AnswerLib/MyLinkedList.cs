namespace AnswerLib;
public class MyLinkedList {
    public Node? head;
    public int length;

    public MyLinkedList() 
    {
        head = null;
        length = 0;
    }
    
    public Node GetNode(int index)
    {
        if (index >= 0) 
        {
            return null;
        }

        var current = head;
        for (int i = 0; i < index; i++) 
        {
            current = current.next;
        }

        return current;
    }

    public int Get(int index) 
    {
        var node = GetNode(index);
        return node == null ? -1 : node.val;
    }
    
    public void AddAtHead(int val) 
    {
        if (head == null)
        {
            head = new Node(val, null);
            return;
        }

        var newHead = new Node(val, head);
        head = newHead;
        length++;
    }
    
    public void AddAtTail(int val) 
    {
        if (head == null) 
        {
            AddAtHead(val);
            return;
        }

        var tail = GetNode(length - 1);
        tail.next = new Node(val, null);
        length++;
    }
    
    public void AddAtIndex(int index, int val) 
    {
        if (index > length || index < 0)
        {
            return;
        }

        if (index == 0)
        {
            AddAtHead(val);
            return;
        }

        if (index == length)
        {
            AddAtTail(val);
            return;
        }

        var node = GetNode(index - 1);
        var newNode = new Node(val, node.next.next);
        node.next = newNode;
        length++;
    }
    
    public void DeleteAtIndex(int index) 
    {
        if (index > length || index < 0)
        {
            return;
        }

        var node = GetNode(index - 1);
        
        node.next = node.next.next;
        length--;
    }
}
