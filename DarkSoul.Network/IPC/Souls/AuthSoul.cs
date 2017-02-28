using DarkSoul.Network.Interface;
using System;

namespace DarkSoul.GUI.Auth.Souls
{
    /// <summary>
    /// Just for fast testing, delete later
    /// </summary>
    public class AuthSoul : ISoul
    {
        public string Test(string text)
        {
            return "lol " + text;
        }

        public string Test2(string text)
        {
            return "test2 " + text;
        }

        public string Test3(int text)
        {
            return "test3 " + text;
        }

        public string Test4(int text)
        {
            return "test4 " + text;
        }

        public User Test5(string text)
        {
            return new User
            {
                Id = double.MaxValue,
                Name = text,
                CreatedAt = DateTime.Now
            };
        }

        public User Test6(string text)
        {
            return new User
            {
                Id = double.MinValue,
                Name = text,
                CreatedAt = DateTime.Now
            };
        }
    }

    public class User
    {
        public double Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, CreatedAt: {CreatedAt}";
        }
    }
}
