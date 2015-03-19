namespace BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    class BitArray64 : IEnumerable<int>
    {
        public ulong Number { get; private set; }

        public BitArray64() { }
        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return (this.Number & ((ulong)1 << index)) == 0 ? 0 : 1;
                }
            }
            set
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException();
                }
                if (value != 0 && value != 1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.Number = (this.Number & ~((ulong)1 << index) | ((ulong)value << index));
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                return this.Number.Equals((obj as BitArray64).Number);
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !first.Equals(second);
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            for (int i = 0; i < 64; i += 4)
            {
                result.AppendFormat("[{0}]={1} \t[{2}]={3} \t[{4}]={5} \t[{6}]={7}\n",
                    i, this[i], i + 1, this[i + 1], i + 2, this[i + 2], i + 3, this[i + 3]);
            }

            return result.ToString();
        }
    }
}