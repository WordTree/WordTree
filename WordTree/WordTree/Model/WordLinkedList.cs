using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordTree.Model
{
    [Serializable]
    public class Node
    {
        public Word Data { get; set; }
        public int StrangeDegree { get; set; }
        public Node Next { get; set; }
        public Node()
        {

            Data = new Word();
            Next = null;
            StrangeDegree = 3;
        }
        public Node(Word item)
        {
            Data = item;
            Next = null;
            StrangeDegree = 3;
        }
    }
    /// <summary>
    /// 节点数据为Word的循环链表
    /// </summary>
    [Serializable]
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
            Node newNode = new Node(item);
            Node tempPtr = head;

            if (IsEmpty())
            {
                head.Next = newNode;
                newNode.Next = head;
                Count++;
                return;
            }

            while (tempPtr.Next != head)
            {
                tempPtr = tempPtr.Next;
            }

            tempPtr.Next = newNode;
            newNode.Next = head;
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
        /// <param name="index">删除节点的位置</param>
        public void Remove(int index)
        {
            if (IsEmpty() || index < 0 || index > Count-1)
            {
                Console.WriteLine("链表为空或位置错误");
                throw new ApplicationException("链表为空或位置错误");
            }

            //遍历位置删除节点
            Node tempPtr = head;  
            Node pre = new Node(); 
            int scanner = -1;
            while (tempPtr.Next != head && scanner < index)
            {
                pre = tempPtr;
                tempPtr = tempPtr.Next;
                ++scanner;
            }
            //遍历到位置
            pre.Next = pre.Next.Next;
            Count--;
        }
        /// <summary>
        /// 根据位置获取元素值
        /// </summary>
        /// <param name="index">元素位置</param>
        /// <returns>元素数据域值</returns>
        public Node GetElem(int index)
        {
            //链表为空时返回默认值。
            if (IsEmpty() || index < 0 || index > Count-1)
            {
                Console.WriteLine("链表为空或位置错误");
                throw new ApplicationException("链表为空或位置错误");
            }
            //遍历查找并返回
            Node tempPtr = head;
            int scanner = -1;
            while (tempPtr.Next != head && scanner < index)
            {
                tempPtr = tempPtr.Next;
                ++scanner;
            }
            //遍历找到
            return tempPtr;
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
            int index = 0;
            Node tempPtr = head.Next;
            while (tempPtr != head || !tempPtr.Data.Equals(value))
            {
                tempPtr = tempPtr.Next;
                ++index;
            }
            if (tempPtr == head)
            {
                Console.WriteLine("不存在这样的节点");
                return -1;
            }
            else
            {
                return index;
            }
        }
    }
}


        
