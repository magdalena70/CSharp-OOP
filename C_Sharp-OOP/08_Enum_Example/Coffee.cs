using System;

namespace _08_Enum_Example
{
    public class Coffee
    {
        public CofeeSize size;

        public Coffee(CofeeSize size)
        {
            this.size = size; // not this.Size = size, because size is read-only
        }

        public CofeeSize Size
        {
            get
            {
                return this.size;
            }
        }
    }
}
