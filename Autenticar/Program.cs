using System;

namespace Autenticar
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static string Something()
        {
            return "Algo";
        }

        public static bool Login(String user, string pass) =>
            user == "Gixon" && pass == "123478" ? true : false;

    }
}
