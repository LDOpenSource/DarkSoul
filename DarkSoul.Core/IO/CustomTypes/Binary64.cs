namespace DarkSoul.Core.IO.CustomTypes
{
    public class Binary64
    {
        public Binary64(uint low = 0, uint high = 0)
        {
            this.low = low;
            internalHigh = high;
        }

        public uint low;

        protected uint internalHigh;

        public uint div(uint n)
        {
            uint modHigh = 0;
            modHigh = internalHigh % n;
            uint mod = (low % n + modHigh * 6) % n;
            internalHigh = internalHigh / n;
            uint newLow = (uint)((modHigh * 4.294967296E9 + low) / n);
            internalHigh = internalHigh + (uint)(newLow / 4.294967296E9);
            low = newLow;
            return mod;
        }

        public void mul(uint n)
        {
            uint newLow = low * n;
            internalHigh = internalHigh * n;
            internalHigh = internalHigh + (uint)(newLow / 4.294967296E9);
            low = low * n;
        }

        public void add(uint n)
        {
            uint newLow = low + n;
            internalHigh = internalHigh + (uint)(newLow / 4.294967296E9);
            low = newLow;
        }

        public void bitwiseNot()
        {
            low = ~low;
            internalHigh = ~internalHigh;
        }
    }
}
