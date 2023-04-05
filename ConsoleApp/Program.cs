// See https://aka.ms/new-console-template for more information
using AnswerLib;
using SeventyFive;

ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

DayThree three = new();

ListNode list = three.MergeTwoLists(list1, list2);

PrintList(list);

static void PrintList(ListNode list) 
{
    while (list != null) 
    {
        Console.Write(list.val + " ");
        list = list.next;
    }
    System.Console.WriteLine();
}

