using System;
class Node
{
	public int data;
	public Node next;
    public Node(int d){
        data=d;
        next=null;
    }
		
}
class Solution {

	public static  Node insert(Node head,int data)
	{
        Node headNode = head;
        Node current = head;
        
        if(headNode == null)
        {
            headNode = new Node(data);
        }
        else
        {
            while(current.next != null)
            {
                current = current.next;
            }
            
            current.next = new Node(data);
        }
        return headNode;
      //Complete this method
    }

	public static void display(Node head)
	{
		Node start=head;
		while(start!=null)
		{
			Console.Write(start.data+" ");
			start=start.next;
		}
	}
    static void Main(String[] args) {
	
		Node head=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            head=insert(head,data);
        }
		display(head);
	}
}
	