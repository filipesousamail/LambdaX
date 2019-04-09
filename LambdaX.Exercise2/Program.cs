using System;

namespace LambdaX.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new LinkedListNode(1);
            var b = new LinkedListNode(2);
            var c = new LinkedListNode(3);
            a.Next = b;
            b.Next = c;

            DeleteNode(b);
        }
        
        private static void DeleteNode(LinkedListNode node)
        {
            if (node.Next is null)
                node = null;
            
            var temp = node.Next;  
            node.Value = temp.Value;  
            node.Next = temp.Next;
            temp = null;
        }
    }
}