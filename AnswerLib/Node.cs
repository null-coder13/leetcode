namespace AnswerLib;

public class Node
{
    public int val {get; set;}
    public Node? next {get; set;}

    public Node(int value, Node? next) 
    {
        val = value;
        this.next = next;
    }
}
