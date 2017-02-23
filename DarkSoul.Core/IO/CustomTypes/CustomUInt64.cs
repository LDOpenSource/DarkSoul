using System;


namespace DarkSoul.Core.IO.CustomTypes
{
    public class CustomUInt64 : Binary64
    {
        public CustomUInt64()
            : base()
        { }

        public CustomUInt64(uint low = 0, uint high = 0)
            : base(low, high)
        { }

        public static CustomUInt64 fromNumber(ulong n)
        {
            return new CustomUInt64((uint)n, (uint)Math.Floor(n / 4.294967296E9));
        }

        public uint high
        {
            get { return internalHigh; }
            set { internalHigh = value; }
        }

        public ulong toNumber()
        {
            return (ulong)(high * 4.294967296E9 + low);
        }
    }
}
