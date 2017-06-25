using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.GenericCountMethodStrings
{
    public class Box<T> where T: IComparable<T>
    {
        private T value;

        public Box()
            : this(default(T))
        {

        }

        public Box(T value)
        {
            this.Value = value;
        }

        public T Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Value.GetType().FullName}: {this.Value}";
        }


    }
}
