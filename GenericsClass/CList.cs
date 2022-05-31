using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClass
{
    public class CList
    {

        public void Add(int Number)
        {
            throw new NotImplementedException();
        }

        public int this[int index]
        { get { throw new NotImplementedException(); } }
    }

    public class CList<T>
    {
        public T this[int index] { get { throw new NotImplementedException(); } }

        public void Add(T Value)
        {
            throw new NotImplementedException();
        }

    }

    public class GenericDictionary<TKey,TValue>
    {
        public void Add(TKey key,TValue value)
        {

        }

    }

}
