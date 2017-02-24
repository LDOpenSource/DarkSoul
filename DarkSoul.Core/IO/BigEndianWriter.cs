using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO.CustomTypes;
using System;
using System.IO;
using System.Text;

namespace DarkSoul.Core.IO
{
    public class BigEndianWriter : IWriter
    {
        private BinaryWriter m_writer;

        public Stream BaseStream
        {
            get { return m_writer.BaseStream; }
        }

        /// <summary>
        ///   Gets available bytes number in the buffer
        /// </summary>
        public long BytesAvailable
        {
            get { return m_writer.BaseStream.Length - m_writer.BaseStream.Position; }
        }

        public long Position
        {
            get { return m_writer.BaseStream.Position; }
            set
            {
                m_writer.BaseStream.Position = value;
            }
        }

        public byte[] Data
        {
            get
            {
                var pos = m_writer.BaseStream.Position;

                var data = new byte[m_writer.BaseStream.Length];
                m_writer.BaseStream.Position = 0;
                m_writer.BaseStream.Read(data, 0, (int)m_writer.BaseStream.Length);

                m_writer.BaseStream.Position = pos;

                return data;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BigEndianWriter"/> class.
        /// </summary>
        public BigEndianWriter()
        {
            m_writer = new BinaryWriter(new MemoryStream(), Encoding.UTF8);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BigEndianWriter"/> class.
        /// </summary>
        /// <param name="stream">The stream.</param>
        public BigEndianWriter(Stream stream)
        {
            m_writer = new BinaryWriter(stream, Encoding.UTF8);
        }

        public BigEndianWriter(byte[] buffer)
        {
            m_writer = new BinaryWriter(new MemoryStream(buffer));
        }

        /// <summary>
        ///   Reverse bytes and write them into the buffer
        /// </summary>
        private void WriteBigEndianBytes(byte[] endianBytes)
        {
            for (int i = endianBytes.Length - 1; i >= 0; i--)
            {
                m_writer.Write(endianBytes[i]);
            }
        }

        /// <summary>
        ///   Write a Short into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteShort(short @short)
        {
            WriteBigEndianBytes(BitConverter.GetBytes(@short));
        }

        /// <summary>
        ///   Write a int into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteInt(int @int)
        {
            WriteBigEndianBytes(BitConverter.GetBytes(@int));
        }

        /// <summary>
        ///   Write a long into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteLong(Int64 @long)
        {
            WriteBigEndianBytes(BitConverter.GetBytes(@long));
        }

        /// <summary>
        ///   Write a UShort into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteUShort(ushort @ushort)
        {
            WriteBigEndianBytes(BitConverter.GetBytes(@ushort));
        }

        /// <summary>
        ///   Write a int into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteUInt(UInt32 @uint)
        {
            WriteBigEndianBytes(BitConverter.GetBytes(@uint));
        }

        /// <summary>
        ///   Write a long into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteULong(UInt64 @ulong)
        {
            WriteBigEndianBytes(BitConverter.GetBytes(@ulong));
        }

        /// <summary>
        ///   Write a byte into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteByte(byte @byte)
        {
            m_writer.Write(@byte);
        }

        public void WriteSByte(sbyte @byte)
        {
            m_writer.Write(@byte);
        }
        /// <summary>
        ///   Write a Float into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteFloat(float @float)
        {
            m_writer.Write(@float);
        }

        /// <summary>
        ///   Write a Boolean into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteBoolean(Boolean @bool)
        {
            if (@bool)
            {
                m_writer.Write((byte)1);
            }
            else
            {
                m_writer.Write((byte)0);
            }
        }

        /// <summary>
        ///   Write a Char into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteChar(Char @char)
        {
            WriteBigEndianBytes(BitConverter.GetBytes(@char));
        }

        /// <summary>
        ///   Write a Double into the buffer
        /// </summary>
        public void WriteDouble(Double @double)
        {
            WriteBigEndianBytes(BitConverter.GetBytes(@double));
        }

        /// <summary>
        ///   Write a Single into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteSingle(Single @single)
        {
            WriteBigEndianBytes(BitConverter.GetBytes(@single));
        }

        /// <summary>
        ///   Write a string into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteUTF(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            var len = (ushort)bytes.Length;
            WriteUShort(len);

            int i;
            for (i = 0; i < len; i++)
                m_writer.Write(bytes[i]);
        }

        /// <summary>
        ///   Write a string into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteUTFBytes(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            var len = bytes.Length;
            int i;
            for (i = 0; i < len; i++)
                m_writer.Write(bytes[i]);
        }

        /// <summary>
        ///   Write a bytes array into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteBytes(byte[] data)
        {
            m_writer.Write(data);
        }

        /// <summary>
        ///   Write a bytes array into the buffer
        /// </summary>
        /// <returns></returns>
        public void WriteBytes(byte[] data, int length)
        {
            byte[] array = new byte[length];
            Array.Copy(data, array, length);
            m_writer.Write(array);
        }


        public void Seek(int offset, SeekOrigin seekOrigin)
        {
            m_writer.BaseStream.Seek(offset, seekOrigin);
        }


        public void Clear()
        {
            m_writer = new BinaryWriter(new MemoryStream(), Encoding.UTF8);
        }

        private const int INT_SIZE = 32;
        private const int CHUNCK_BIT_SIZE = 7;

        private static int SHORT_MIN_VALUE = -32768;
        private static int SHORT_MAX_VALUE = 32767;

        private const int MASK_1 = 128;
        private const int MASK_0 = 127;

        public void WriteVarInt(int value)
        {
            WriteInt(value); //just for fast for the moment
            //if (value >= 0 && value <= MASK_0)
            //{
            //    WriteByte((byte)value);
            //    return;
            //}
            //int b = 0;
            //int c = value;
            //while (c != 0 && c != -1)
            //{
            //    b = c & MASK_0;
            //    c = c >> CHUNCK_BIT_SIZE;
            //    if (c > 0)
            //    {
            //        b = b | MASK_1;
            //    }
            //    WriteByte((byte)b);
            //}
        }

        public void WriteVarShort(int value)
        {
            WriteInt(value); //just for fast for the moment
            //if (value > SHORT_MAX_VALUE || value < SHORT_MIN_VALUE)            
            //    throw new Exception("Forbidden value");            
            //else
            //{
            //    var b = 0;
            //    if ((value >= 0) && (value <= MASK_0))
            //    {
            //        WriteByte((byte)value);
            //        return;
            //    }
            //    var c = value & 65535;
            //    while (c != 0 && c != -1)
            //    {
            //        b = (c & MASK_0);
            //        c = c >> CHUNCK_BIT_SIZE;
            //        if (c > 0)                    
            //            b = b | MASK_1;                    
            //        WriteByte((byte)b);
            //    }
            //}
        }

        public void WriteVarLong(double value)
        {
            WriteDouble(value); //just for fast for the moment
            //uint i = 0;
            //var val = CustomInt64.fromNumber(value);
            //if (val.high == 0)            
            //    Writeint32(val.low);            
            //else
            //{
            //    i = 0;
            //    while (i < 4)
            //    {
            //        WriteByte((byte)(val.low & 127 | 128));
            //        val.low = val.low >> 7;
            //        i++;
            //    }
            //    if ((val.high & 268435455 << 3) == 0)                
            //        WriteByte((byte)(val.high << 4 | val.low));                
            //    else
            //    {
            //        WriteByte((byte)(((val.high << 4) | val.low) & 127 | 128));
            //        Writeint32(val.high >> 3);
            //    }
            //}
        }

        private void Writeint32(uint value)
        {
            while (value >= 128)
            {
                WriteByte((byte)(value & 127 | 128));
                value = value >> 7;
            }
            WriteByte((byte)value);
        }

        public void Dispose()
        {
            m_writer.Dispose();
            m_writer = null;
        }
    }
}
