using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class MyDictionary <T1, T2>
    {
        T1[] keyArray = new T1[1];
        T2[] valueArray = new T2[1];
        private int count = 0;

        public int Count { get { return keyArray.Length; } }
        public void Add(T1 key, T2 value)
        {
            bool isContinue = true;
            for (int i = 0; i < keyArray.Length; i++)
            {
                if (count == i)
                {
                    keyArray[i] = key;
                    valueArray[i] = value;
                    count++;
                    isContinue = false;
                }
            }
            if (count == keyArray.Length && isContinue == true)
            {
                T1[] newkeyArray = new T1[keyArray.Length + 1];
                int a = newkeyArray.Length;
                T2[] newvalueArray = new T2[valueArray.Length + 1];
                for (int i = 0; i < keyArray.Length; i++)
                {
                    newkeyArray[i] = keyArray[i];
                    newvalueArray[i] = valueArray[i];
                }
                newkeyArray[count] = key;
                newvalueArray[count] = value;
                count++;
                keyArray = newkeyArray;
                valueArray = newvalueArray;
            }
        }

        public T2 this[T1 keyValue]
        {
            get 
            {
                for (int i = 0; i < keyArray.Length; i++)
                {
                    if (keyValue.Equals(keyArray[i]))
                    {
                        return valueArray[i];
                    }
                }
                return default; 
            }
        }
    }
}
