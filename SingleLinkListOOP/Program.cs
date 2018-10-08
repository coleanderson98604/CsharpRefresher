using System;

namespace SingleLinkListOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList test = new SinglyLinkedList();
            test.Add(40);
            test.Add(50);
            test.Add(60);
            test.Add(32);
            test.RemoveAt(2);
            SllNode exampole = test.Find(40);
            test.PrintValues();
        }
    }
    public class SllNode
    {
        public int Value;
        public SllNode Next;
        public SllNode(int value)
        {
            this.Value = value;
            Next = null;
        }
    }
    public class SinglyLinkedList
    {
        public SllNode Head;
        public SinglyLinkedList()
        {
            Head = null;
        }
        public void Add(int value)
        {
            SllNode newNode = new SllNode(value);
            if(Head == null)
            {
                Head = newNode;
            }
            else
            {
                SllNode runner = Head;
                while(runner.Next != null)
                {
                    runner = runner.Next;
                }
                runner.Next = newNode;
            }
        }
        public bool Remove()
        {
            if(Head == null)
            {
                return false;
            }
            else
            {
                SllNode prev = Head;
                SllNode runner = Head;
                while(runner.Next != null)
                {
                    prev = runner;
                    runner = runner.Next;
                }
                prev.Next = null;
                return true;
            }
        }
        public void PrintValues()
        {
            if(Head == null)
            {
                return;
            }
            else
            {
                SllNode runner = Head;
                while(runner.Next != null)
                {
                    System.Console.WriteLine(runner.Value);
                    runner = runner.Next;
                }
                System.Console.WriteLine(runner.Value);
            }
        }
        public SllNode Find(int value)
        {
            if(Head == null)
            {
                return null;
            }
            else
            {
                SllNode runner = Head;
                while(runner.Next != null)
                {
                    if(runner.Value == value)
                    {
                        return runner;
                    }
                    runner = runner.Next;
                }
            }
            return null;
        }
        public bool RemoveAt(int value)
        {
            if(Head == null)
            {
                return false;
            }
            else
            {
                int index = 0;
                SllNode runner = Head;
                SllNode prev = Head;
                if(value == 0)
                {
                    Head.Next = null;
                }
                else
                {
                    while(runner.Next != null)
                    {
                        index++;
                        prev = runner;
                        runner = runner.Next;
                        if(index == value)
                        {
                            prev.Next = runner.Next;
                            return true;
                        }
                    }
                }
                return false;
            }
        }
    }
}
