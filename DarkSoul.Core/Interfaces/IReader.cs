using System;

namespace DarkSoul.Core.Interfaces
{
    public interface IReader : IDisposable
    {
        int Position { get; set; }

        long BytesAvailable { get; }

        short ReadShort();

        int ReadInt();

        long ReadLong();

        ushort ReadUShort();

        uint ReadUInt();

        ulong ReadULong();

        byte ReadByte();

        sbyte ReadSByte();

        byte[] ReadBytes(int n);

        bool ReadBoolean();

        char ReadChar();

        double ReadDouble();

        float ReadFloat();

        string ReadUTF();

        string ReadUTFBytes(ushort len);

        double ReadVarLong();

        int ReadVarInt();

        uint ReadVarUhInt();

        double ReadVarUhLong();

        short ReadVarShort();

        ushort ReadVarUhShort();

        void SkipBytes(int n);
    }
}
