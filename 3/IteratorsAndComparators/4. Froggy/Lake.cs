using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Froggy
{
    public class Lake : IEnumerable<Stone>
    {
        public List<Stone> Collection { get; }

        public Lake()
        {
            Collection = new List<Stone>();
        }


        public IEnumerator<Stone> GetEnumerator()
        {
            for (int i = 0; i < Collection.Count; i+=2)
            {
                yield return Collection[i];                
            }
            int lastEvenPosition = Collection.Count - 1;
            if ((Collection.Count - 1) % 2 != 0)
            {
                lastEvenPosition = Collection.Count - 2;
            }
            if ((Collection.Count-1) % 2!=0)
            {
                for (int i = Collection.Count - 1; i >=0 ; i-=2)
                {
                    yield return Collection[i];
                }
            }
            else
            {
                for (int i = Collection.Count - 2; i >= 0; i -= 2)
                {
                    yield return Collection[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
