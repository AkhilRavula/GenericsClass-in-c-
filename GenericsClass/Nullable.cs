using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClass
{
    public class Nullable<T> where T : struct
    {
        private object _value;  
        public Nullable(T Value)
        {
            _value = Value; 
        }

        public Nullable()
        {

        }

        public bool HasValue
        {
          get { return _value != null; }
        }

        public T GetValueDefault() 
        {
           if(HasValue)
                return (T)_value;
           return default(T);
        
        }
    }
}
