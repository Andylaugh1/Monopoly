using System;
using Microsoft.EntityFrameworkCore.Design;
using Monopoly;
using Monopoly.NewDb;

namespace StartupApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var game1 = new MonopolyDB();
            game1.SaveChanges();
        }
    }
}
