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
        object[] arrayList = new object[1];
        public void Add(object value)
        {
            bool isContinue = true;
            int count = 0;
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
    }
}
