using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    unsafe internal class Program
    {
        public struct list
        {
            public int value;
            public list* next;
            public list(int value)
            {
                this.value = value;
                this.next = null;
            }
           
        }
        static void Main(string[] args)
        {
            list* numbers = stackalloc list[10];
            list root = new list(7);
            root.next = &numbers[0];

            list* R = &root;
            for (int i = 0; i < 10; i++)
            {
                numbers[i].value = i;
                if(i!=0)
                    numbers[i - 1].next = &numbers[i];

            }
            


        }
        public static list* addFirst(list* root, list *add)
        {
           
            add->next = root;
            root = add;
            return root;

        }
        public static list* removeLast(list* root)
        {
            list* P = root;
            if(isEmpty(P))
            {
                return null;
            }
            if (!isEmpty(P->next))
            {
                while (root->next->next != null)
                {
                    root = root->next;
                }
                root->next = null;
                return P;
            }
            return null;
        }
        public static bool isEmpty(list* root)
        {
            return (root == null);
        }
        public static void print(list* root)
        {
            if (!isEmpty(root))
            {
                while (root != null)
                {
                    Console.Write(root->value);
                    root = root->next;
                }
            }
            else
            {
                Console.WriteLine("Очередь пуста");
            }
            Console.WriteLine();
        }
    }
}
