using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0412
{
    public interface Stack
    {
        bool Empty { get; }
        void push(char item);
        char pop();
        void delete();
        char peek();
    }


    public class StackNode
    {
        internal char data;
        internal StackNode link;
    }



    public class LinkedStack : Stack
    {
        private StackNode top;

        public virtual bool Empty
        {
            get
            {
                return (top == null);
            }
        }

        public virtual void push(char item)
        {
            StackNode newNode = new StackNode();
            newNode.data = item;
            newNode.link = top;
            top = newNode;
            // System.out.println("Inserted Item : " + item);
        }

        public virtual char pop()
        {
            if (Empty)
            {
                Console.WriteLine("Deleting fail! Linked Stack is empty!!");
                return (char)0;
            }
            else
            {
                char item = top.data;
                top = top.link;
                return item;
            }
        }

        public virtual void delete()
        {
            if (Empty)
            {
                Console.WriteLine("Deleting fail! Linked Stack is empty!!");

            }
            else
            {
                top = top.link;
            }
        }

        public virtual char peek()
        {
            if (Empty)
            {
                Console.WriteLine("Peeking fail! Linked Stack is empty!!");
                return (char)0;
            }
            else
            {
                return top.data;
            }
        }

        public virtual void printStack()
        {
            if (Empty)
            {
                Console.Write("Linked Stack is empty!! %n %n");
            }
            else
            {
                StackNode temp = top;
                Console.WriteLine("Linked Stack>> ");
                while (temp != null)
                {
                    Console.Write("\t {0} \n", temp.data);
                    temp = temp.link;
                }
                Console.WriteLine();
            }
        }
    }




    public class OptExp
    {
        private string exp;
        private int expSize;
        private char testCh, openPair;

        public virtual bool testPair(string exp)
        {
            this.exp = exp;
            LinkedStack S = new LinkedStack();
            expSize = this.exp.Length;
            for (int i = 0; i < expSize; i++)
            {
                testCh = this.exp[i];
                switch (testCh)
                {
                    case '(':
                    case '{':
                    case '[':
                        S.push(testCh);
                        break;
                    case ')':
                    case '}':
                    case ']':
                        if (S.Empty)
                        {
                            return false;
                        }
                        else
                        {
                            openPair = S.pop();
                            if ((openPair == '(' && testCh != ')') || (openPair == '{' && testCh != '}') || (openPair == '[' && testCh != ']'))
                            {
                                return false;
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                }
            }
            if (S.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OptExp opt = new OptExp();
            string exp = "(3*5)-6/2)";

            Console.WriteLine(exp);

            if (opt.testPair(exp))
            {
                Console.WriteLine("괄호 맞음!!");
            }
            else
            {
                Console.WriteLine("괄호 틀림!!");
            }
        }
    }
}
