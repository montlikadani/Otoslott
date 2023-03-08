using System;
using System.Collections.Generic;
using System.Linq;

namespace OtosLott {
    internal class Program {

        static void Main(string[] args) {
            List<int> list = new List<int>();

            foreach (string line in Properties.Resources.otoslott.Split('\n').Skip(1)) {
                string[] split = line.Split(';');

                for (int i = 11; i < split.Length; i++) {
                    list.Add(int.Parse(split[i]));
                }
            }

            Console.WriteLine($@"Eddigi legkevesebbszer kihúzott 5 szám: {string.Join(", ", list.GroupBy(x => x).OrderBy(gr => gr.Count()).Take(5)
                .Select(gr => $"{gr.Key} ({gr.Count()} db)"))}");
            Console.ReadKey();
        }
    }
}
