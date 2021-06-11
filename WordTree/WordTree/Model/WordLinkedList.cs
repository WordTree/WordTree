using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordTree.Model
{
    public class Node
    {
        public Word Data { get; set; }
        public Node Next { get; set; }
        public Node()
        {

            Data = new Word();
            Next = null;
        }
        public Node(Word item)
        {
            Data = item;
            Next = null;
        }
    }
    /// <summary>
    /// 节点数据为Word的循环链表
    /// </summary>
    public class WordLinkedList
    {
        public Node head;
        public int Count { get; set; }
        public WordLinkedList()
        {
            head = new Node();
            head.Next = head;
            Count = 0;
        }

        /// <summary>
        /// 向链表中添加元素
        /// </summary>
        /// <param name="item"></param>
        public void Add(Word item)
        {
            Node p = new Node(item);
            Node c = head;

            if (IsEmpty())
            {
                head.Next = p;
                p.Next = head;
                Count++;
                return;
            }

            while (c.Next != head)
            {
                c = c.Next;
            }

            c.Next = p;
            p.Next = head;
            Count++;
        }

        /// <summary>
        /// 清空链表
        /// </summary>
        public void Clear()
        {
            head.Next = head;
            Count = 0;
        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="i">删除节点的位置</param>
        public void Remove(int i)
        {
            if (IsEmpty() || i < 0 || i > Count-1)
            {
                Console.WriteLine("链表为空或位置错误");
                throw new ApplicationException("链表为空或位置错误");
            }

            //遍历位置删除节点
            Node c = head;  
            Node pre = new Node(); 
            int j = -1;
            while (c.Next != head && j < i)
            {
                pre = c;
                c = c.Next;
                ++j;
            }
            //遍历到位置
            pre.Next = pre.Next.Next;
            Count--;
        }
        /// <summary>
        /// 根据位置获取元素值
        /// </summary>
        /// <param name="i">元素位置</param>
        /// <returns>元素数据域值</returns>
        public Word GetElem(int i)
        {
            //链表为空时返回默认值。
            if (IsEmpty() || i < 0 || i > Count-1)
            {
                Console.WriteLine("链表为空或位置错误");
                throw new ApplicationException("链表为空或位置错误");
            }
            //遍历查找并返回
            Node c = head;
            int j = -1;
            while (c.Next != head && j < i)
            {
                c = c.Next;
                ++j;
            }
            //遍历找到
            return c.Data;
        }

        //判断链表是否为空
        public bool IsEmpty()
        {
            return head.Next == head;
        }

        /// <summary>
        /// 根据节点值查找位置
        /// </summary>
        /// <param name="value">节点值</param>
        /// <returns>节点位置</returns>
        public int Locate(Word value)
        {
            int i = 0;
            Node c = head.Next;
            while (c != head || !c.Data.Equals(value))
            {
                c = c.Next;
                ++i;
            }
            if (c == head)
            {
                Console.WriteLine("不存在这样的节点");
                return -1;
            }
            else
            {
                return i;
            }
        }
    }
}


        
