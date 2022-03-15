using System;
using CheckbookRegister.Models;

namespace CheckbookRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var checkbook = new Checkbook();
            checkbook.Run();
        }
    }
}