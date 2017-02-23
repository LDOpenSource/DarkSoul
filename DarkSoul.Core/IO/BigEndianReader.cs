using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO.CustomTypes;
using System;
using System.IO;
using System.Text;

namespace DarkSoul.Core.IO
{
    public unsafe class BigEndianReader : IReader
    {
        public int Position { get; set; }

        public byte[] Buffer { get; private set; }
        public int Length { get; set; }

        public BigEndianReader()
        {
            Position = 0;
        }

        public BigEndianReader(byte[] buff, int len)
        {
            Buffer = buff;
            Length = len;
        }

        public byte ReadByte()
        {
            fixed (byte* pbyte = &Buffer[Position++])
            {
                return *pbyte;
            }
        }

        public sbyte ReadSByte()
        {
            fixed (byte* pbyte = &Buffer[Position++])
            {
                return (sbyte)*pbyte;
            }
        }

        public long BytesAvailable => Length - Position;

        public short ReadShort()
        {
            var position = Position;
            Position += 2;
            fixed (byte* pbyte = &Buffer[position])
            {
                return (short)((*pbyte << 8) | (*(pbyte + 1)));
            }
        }

        public int ReadInt()
        {
            var position = Position;
            Position += 4;
            fixed (byte* pbyte = &Buffer[position])
            {
                return (*pbyte << 24) | (*(pbyte + 1) << 16) | (*(pbyte + 2) << 8) | (*(pbyte + 3));
            }
        }

        public long ReadLong()
        {
            var position = Position;
            Position += 8;
            fixed (byte* pbyte = &Buffer[position])
            {
                int i1 = (*pbyte << 24) | (*(pbyte + 1) << 16) | (*(pbyte + 2) << 8) | (*(pbyte + 3));
                int i2 = (*(pbyte + 4) << 24) | (*(pbyte + 5) << 16) | (*(pbyte + 6) << 8) | (*(pbyte + 7));
                return (uint)i2 | ((long)i1 << 32);
            }
        }

        public ushort ReadUShort() => (ushort)ReadShort();

        public uint ReadUInt() => (uint)ReadInt();

        public ulong ReadULong() => (ulong)ReadLong();

        public byte[] ReadBytes(int n)
        {
            var dst = new byte[n];
            fixed (byte* pSrc = &Buffer[Position], pDst = dst)
            {
                byte* ps = pSrc;
                byte* pd = pDst;

                // Loop over the count in blocks of 4 bytes, copying an integer (4 bytes) at a time:
                for (int i = 0; i < n / 4; i++)
                {
                    *((int*)pd) = *((int*)ps);
                    pd += 4;
                    ps += 4;
                }

                // Complete the copy by moving any bytes that weren't moved in blocks of 4:
                for (int i = 0; i < n % 4; i++)
                {
                    *pd = *ps;
                    pd++;
                    ps++;
                }
            }

            Position += n;

            return dst;
        }

        public bool ReadBoolean() => ReadByte() != 0;

        public char ReadChar() => (char)ReadShort();

        public float ReadFloat()
        {
            int val = ReadInt();
            return *(float*)&val;
        }

        public double ReadDouble()
        {
            long val = ReadLong();
            return *(double*)&val;
        }

        public string ReadUTF()
        {
            ushort length = ReadUShort();

            byte[] bytes = ReadBytes(length);
            return Encoding.UTF8.GetString(bytes);
        }

        public string ReadUTFBytes(ushort len)
        {
            byte[] bytes = ReadBytes(len);
            return Encoding.UTF8.GetString(bytes);
        }

        private const int INT_SIZE = 32;
        private const int CHUNCK_BIT_SIZE = 7;

        private static int SHORT_SIZE = 16;
        private static int SHORT_MAX_VALUE = 32767;
        private static int UNSIGNED_SHORT_MAX_VALUE = 65536;

        private const int MASK_1 = 128;
        private const int MASK_0 = 127;


        public int ReadVarInt()
        {
            var local_4 = 0;
            var local_1 = 0;
            var local_2 = 0;
            var local_3 = false;

            while (local_2 < INT_SIZE)
            {
                local_4 = ReadByte();
                local_3 = (local_4 & MASK_1) == MASK_1;

                if (local_2 > 0)
                {
                    local_1 += ((local_4 & MASK_1) << local_2);
                }
                else
                {
                    local_1 += (local_4 & MASK_0);
                }

                local_2 += CHUNCK_BIT_SIZE;

                if (!local_3)
                {
                    return local_1;
                }
            }

            throw new Exception("Too much data");
        }

        public short ReadVarShort()
        {
            int b = 0;
            short value = 0;
            int offset = 0;
            bool hasNext = false;
            while (offset < SHORT_SIZE)
            {
                b = ReadByte();
                hasNext = (b & MASK_1) == MASK_1;
                if (offset > 0)
                {
                    value = (short)(value + ((b & MASK_0) << offset));
                }
                else
                {
                    value = (short)(value + (b & MASK_0));
                }
                offset = offset + CHUNCK_BIT_SIZE;
                if (!hasNext)
                {
                    if (value > SHORT_MAX_VALUE)
                    {
                        value = (short)(value - UNSIGNED_SHORT_MAX_VALUE);
                    }
                    return value;
                }
            }
            throw new Exception("Too much data");
        }


        public double ReadVarLong() => ReadInt64().toNumber();

        private CustomInt64 ReadInt64()
        {
            uint b = 0;
            var result = new CustomInt64();
            int i = 0;
            while (true)
            {
                b = ReadByte();
                if (i == 28)                
                    break;                
                if (b >= 128)
                {
                    result.low = result.low | (b & 127) << i;
                    i = i + 7;
                    continue;
                }
                result.low = result.low | b << i;
                return result;
            }

            if (b >= 128)
            {
                b = b & 127;
                result.low = result.low | b << i;
                result.high = b >> 4;
                i = 3;
                while (true)
                {
                    b = ReadByte();
                    if (i < 32)
                    {
                        if (b >= 128)                        
                            result.high = (result.high | (b & 127) << i);                        
                        else                        
                            break;                        
                    }
                    i = i + 7;
                }
                result.high = (result.high | (b << i));
                return result;
            }
            result.low = result.low | b << i;
            result.high = b >> 4;
            return result;
        }

        public void Seek(int offset, SeekOrigin seekOrigin)
        {
            if (seekOrigin == SeekOrigin.Begin)
                Position = offset;
            else if (seekOrigin == SeekOrigin.End)
                Position = Buffer.Length + offset;
            else if (seekOrigin == SeekOrigin.Current)
                Position += offset;
        }

        public void SkipBytes(int n)
        {
            Position += n;
        }

        public void Dispose()
        {

        }
    }
}
