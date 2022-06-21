using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> vgNames = new List<string>();

            // add names using .Append()
            vgNames = vgNames
                .Append("Microsoft Flight Simulator")
                .Append("Unreal")
                .Append("Doom")
                .Append("Galaga")
                .Append("Baldur's Gate")
                .Append("Valheim")
                .Append("Mario Cart")
                .Append("Grand Theft Auto")
                .Append("Dr Mario")
                .Append("Erica")
                .ToList();

            //Sort list by name length, then by alphabetical (eg. to put Galaga before Valheim)
            vgNames = vgNames.OrderBy(n => n.Length).ThenBy(n => n).ToList();

            Console.WriteLine();
            Console.WriteLine("Games sorted by name length");
            foreach (var vg in vgNames)
            {
                Console.WriteLine(vg);
            }

            Console.WriteLine();
            Console.WriteLine("Total names in list");
            Console.WriteLine(vgNames.Count());

            Console.WriteLine();
            Console.WriteLine("only games with Mario in the name, alphabetical.");
            var marioGames = vgNames.Where(x => x.Contains("Mario", StringComparison.OrdinalIgnoreCase)).OrderBy(n => n).ToList();
            foreach (var marioGame in marioGames)
            {
                Console.WriteLine(marioGame);
            }

            Console.WriteLine();
            Console.WriteLine("First 3 games sorted by name, reverse alphabetical");
            foreach (var vg in vgNames.OrderByDescending(n => n).Take(3))
            {
                Console.WriteLine(vg);
            }
            Console.WriteLine();
            Console.WriteLine("Total length of names");
            Console.WriteLine(vgNames.Select(x => x.Length).Sum());

            Console.WriteLine();
            Console.WriteLine("Average length of name");
            Console.WriteLine(vgNames.Select(x => x.Length).Average());

            Console.WriteLine();
            Console.WriteLine("Max length of name");
            Console.WriteLine(vgNames.Select(x => x.Length).Max());

            Console.WriteLine();
            Console.WriteLine("Min length of name");
            Console.WriteLine(vgNames.Select(x => x.Length).Min());


            //Linq Methods used above:
            // Where() Select() OrderBy() Sum() Average() Count() Min() Max() Take() Append() ThenBy() OrderByDescending()
        }
    }
}
