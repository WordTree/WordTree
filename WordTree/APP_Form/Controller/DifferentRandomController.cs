using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Form.Controller
{
    class DifferentRandomController<T>
    {
        /// <summary>
        /// 从原数组中随机选出指定数量的元素（顺序不变）
        /// </summary>
        /// <param name="array"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static T[] GetDifferentRandom(T[] array, int count)
        {
            T[] output = new T[count];
            Random rd = new Random();
            for (int i = array.Length - 1; i >= 0 && count > 0; i--)
            {
                if (rd.Next(0, i + 1) < count)//概率是 剩余取数长度/总数组剩余的长度
                {
                    output[count - 1] = array[i];//output从最后一位开始往前存
                    count--;
                }
            }
            return output;
        }
        public static void Shuffle(T[] array)
        {
            Random random = new Random();
            int target = 0;
            T temp;
            for (int i = 0; i < array.Length; i++)
            {
                target = random.Next(0, array.Length);
                temp = array[i];
                array[i] = array[target];
                array[target] = temp;
            }
        }
    }
}
