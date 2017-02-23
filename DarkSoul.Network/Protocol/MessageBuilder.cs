using DarkSoul.Core.IO;
using System;

namespace DarkSoul.Network.Protocol
{
    public class MessageBuilder
    {
        private byte[] m_data;

        /// <summary>
        ///     Set to true when the message is whole
        /// </summary>
        public bool IsValid => Header.HasValue && Length.HasValue &&
                               Length == Data.Length;

        public int? Header { get; private set; }

        /// <summary>
        /// Recognize Message
        /// </summary>
        public int? MessageId => Header >> 2;

        public int? LengthBytesCount => Header & 0x3;

        public int? Length { get; private set; }

        /// <summary>
        /// Avalible Data to read
        /// </summary>
        public byte[] Data
        {
            get { return m_data; }
            set { m_data = value; }
        }

        /// <summary>
        ///     Build or continue building the message. Returns true if the resulted message is valid and ready to be parsed
        /// </summary>
        public bool Build(BigEndianReader reader)
        {
            try
            {
                if (reader.BytesAvailable <= 0)
                    return false;

                if (IsValid)
                    return true;

                if (!Header.HasValue && reader.BytesAvailable < 2)
                    return false;

                if (reader.BytesAvailable >= 2 && !Header.HasValue)
                    Header = reader.ReadShort();

                if (LengthBytesCount.HasValue &&
                    reader.BytesAvailable >= LengthBytesCount && !Length.HasValue)
                {
                    if (LengthBytesCount < 0 || LengthBytesCount > 3)
                        throw new Exception(
                            "Malformated Message Header, invalid bytes number to read message length (inferior to 0 or superior to 3)");

                    Length = 0;

                    // 3..0 or 2..0 or 1..0
                    for (var i = LengthBytesCount.Value - 1; i >= 0; i--)
                    {
                        Length |= reader.ReadByte() << (i * 8);
                    }
                }

                // first case : no data read
                if (Data == null && Length.HasValue)
                {
                    if (Length == 0)
                        Data = new byte[0];

                    // enough bytes in the buffer to build a complete message
                    if (reader.BytesAvailable >= Length)
                    {
                        Data = reader.ReadBytes(Length.Value);
                        return true;
                    }
                    // not enough bytes, so we read what we can
                    else if (Length > reader.BytesAvailable)
                    {
                        Data = reader.ReadBytes((int)reader.BytesAvailable);
                        return false;
                    }
                }
                //second case : the message was split and it missed some bytes 
                if (Data != null && Length.HasValue && Data.Length < Length)
                {
                    // still miss some bytes ...
                    if (Data.Length + reader.BytesAvailable < Length)
                    {
                        var lastLength = Data.Length;
                        Array.Resize(ref m_data, (int)(Data.Length + reader.BytesAvailable));
                        var array = reader.ReadBytes((int)reader.BytesAvailable);

                        Array.Copy(array, 0, Data, lastLength, array.Length);
                    }
                    // there is enough bytes in the buffer to complete the message :)
                    else if (Data.Length + reader.BytesAvailable >= Length)
                    {
                        var bytesToRead = Length.Value - Data.Length;

                        Array.Resize(ref m_data, Data.Length + bytesToRead);
                        var array = reader.ReadBytes(bytesToRead);

                        Array.Copy(array, 0, Data, Data.Length - bytesToRead, bytesToRead);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return IsValid;
        }
    }
}
