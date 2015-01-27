using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_IndexerDeclaration
{
    public class BitArray32
    {
        private int value;
        //private static int bitCounter; //static member

        public BitArray32(int value)
        {
            //bitCounter++; //static member does not use 'this'
            this.value = value;
        }

        //indexer declaration
        public int this[int index]
        {
            get
            {
                if(index < 0 || index > 31){
                    throw new IndexOutOfRangeException("Index must be in the range[0...31].");
                }
                int bit = (this.value >> index) & 1;
                return bit;
            }
            set
            {
                if (index < 0 || index > 31)
                {
                    throw new IndexOutOfRangeException("Index must be in the range[0...31].");
                }
                if (value != 0 && value != 1)
                {
                    throw new ArgumentException("Argument must be either 0 or 1.");
                }
                int mask = 1;
                this.value &= ~(mask << index);//returned all bits in 0
                this.value |= value << index;
            }
        }
        //overloading operator '+', '+='
        public static BitArray32 operator +(BitArray32 first, BitArray32 second)
        {
            int sum = first.value + second.value;
            return new BitArray32(sum);
        }

        public override string ToString()
        {
            return this.value.ToString();//print value to string
        }
    }
}
