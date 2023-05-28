using System;
using System.Collections.Generic;

namespace TesteListasemCsharp {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);



        }
    }
}