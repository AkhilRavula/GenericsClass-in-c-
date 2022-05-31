using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClass
{


    public class utilities<T> where T : IComparable,new()
    {

        public void DoSomething(T Value)
        {
            var obj = new T();
        }

        public int Max(int a ,int b)
        {
            return a>b?a:b;
        }

       public T Max(T a,T b)
       {

            return a.CompareTo(b) > 0 ? a : b;
       }

    }
}
