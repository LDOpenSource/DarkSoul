﻿using System;

namespace DarkSoul.Core.Interfaces
{
    public interface IWriter : IDisposable
    {
        byte[] Data { get; }

        long Position { get; set; }

        void WriteShort(short @short);

        void WriteInt(int @int);

        void WriteLong(long @long);

        void WriteUShort(ushort @ushort);

        void WriteUInt(uint @uint);

        void WriteULong(ulong @ulong);

        void WriteByte(byte @byte);

        void WriteSByte(sbyte @byte);

        void WriteFloat(float @float);

        void WriteBoolean(bool @bool);

        void WriteChar(char @char);

        void WriteDouble(double @double);

        void WriteSingle(float single);

        void WriteUTF(string str);

        void WriteUTFBytes(string str);

        void WriteBytes(byte[] data);

        void Clear();
    }
}
