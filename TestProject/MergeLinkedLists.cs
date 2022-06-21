using System;
using System.IO;

namespace TestProject
{
    public class MergeLinkedLists
    {
        public class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        public class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                }

                this.tail = node;
            }
        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
        {
            while (node != null)
            {
                textWriter.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    textWriter.Write(sep);
                }
            }
        }

        public static SinglyLinkedListNode MergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            var newList = new SinglyLinkedList();

            while (true)
            {
                if (head1 == null)
                {
                    newList.tail.next = head2;
                    break;
                }

                if (head2 == null)
                {
                    newList.tail.next = head1;
                    break;
                }

                if (head1.data < head2.data)
                {
                    newList.InsertNode(head1.data);
                    head1 = head1.next;
                }
                else if (head1.data > head2.data)
                {
                    newList.InsertNode(head2.data);
                    head2 = head2.next;
                }
                else
                {
                    newList.InsertNode(head1.data);
                    newList.InsertNode(head2.data);
                    head1 = head1.next;
                    head2 = head2.next;
                }
            }

            return newList.head;
        }
    }
}
