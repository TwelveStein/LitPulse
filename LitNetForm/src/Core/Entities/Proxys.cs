using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Proxys
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Server => $"http://{Host}:{Port}";

        public override string ToString()
        {
            return $"{Host}:{Port}:{Username}:{Password}";
        }

        public static Proxys Parse(string line)
        {
            try
            {
                var parts = line.Split(':');
                if (parts.Length >= 4)
                {
                    return new Proxys
                    {
                        Host = parts[0],
                        Port = int.Parse(parts[1]),
                        Username = parts[2],
                        Password = parts[3]
                    };
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
