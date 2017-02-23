using System;

namespace DarkSoul.Network.Attribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class HandleAttribute : System.Attribute
    {
        /// <summary>
        /// Message Identifier
        /// </summary>
        public ushort Id { get; set; }

        public HandleAttribute(ushort id)
        {
            Id = id;
        }
    }
}
