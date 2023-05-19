using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class MyArrayList
    {
        object[] arrayList = new object[0];
        public int Count { get { return arrayList.Length;} }
        int count = 0;
        public void Add(object value)
        {
            bool isContinue = true;
            if(count < arrayList.Length)
            { 
            for (int i = 0; i < arrayList.Length; i++)
            {
                if(count == i)
                {
                    arrayList[i] = value;
                    count++;
                    isContinue= false;
                }
            }
            }
            if(count == arrayList.Length && isContinue == true)
            {
                object[] newArrayList = new object[arrayList.Length + 1];
                for (int i = 0; i < arrayList.Length; i++)
                {
                    newArrayList[i] = arrayList[i];
                }
                newArrayList[count] = value;
                count++;
                arrayList = newArrayList;
            }
        }
        public object this[int index]
        {
            get 
            {
                for (int i = 0; i < arrayList.Length; i++)
                {
                    if(index == i)
                    {
                        object a = arrayList[i];
                        return a;
                    }
                }
                return 0; 
            }
        }
        public void Clear()
        {
            object[] emptyArrayList = new object[0];
            arrayList = emptyArrayList;
        }
    }
}
