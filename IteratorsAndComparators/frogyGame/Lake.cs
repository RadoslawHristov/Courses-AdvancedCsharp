using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Froggy
{
    public class Lake<T>: IEnumerable<T>
    {
        private List<T> stones;

        public Lake(params T[] data)
        {
            stones = new List<T>(data);
        }

        public void Add(T[] data)
        {
            foreach (var item in data)
            {
                stones.Add(item);
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < stones.Count; i++)
            {
                if (i % 2==0)
                {
                    yield return stones[i];
                }
            }

            for (int i = stones.Count - 1; i >= 0; i--)
            {
                if (i % 2==1)
                {
                    yield return stones[i];
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
