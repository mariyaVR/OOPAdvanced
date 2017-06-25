using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.GenericBox
{
    public class Box<T>
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

        public static void Swap<Tvalue>(List<Box<Tvalue>> list, int firstPosition, int secondPosition)
        {
            Box<Tvalue> oldFirstPositionValue = list[firstPosition];
            list[firstPosition] = list[secondPosition];
            list[secondPosition] = oldFirstPositionValue;
        }
    }
}