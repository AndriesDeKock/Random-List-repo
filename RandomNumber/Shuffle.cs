using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RandomNumber
{
    public static class ShuffleClass
    {
        public static void Shuffle<T>(this IList<T> List) {

            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int ListCount = List.Count;

            while (ListCount > 1)
            {
                byte[] box = new byte[1];

                do
                {
                    provider.GetBytes(box);

                } while (box[0] > ListCount * (Byte.MaxValue / ListCount));

                int k = (box[0] % ListCount);
                ListCount--;

                T value = List[k];
                
                List[k] = List[ListCount];
                List[ListCount] = value;
                
            }

        }
    }
}
