using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Gems.Identity;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            var longIds = File.ReadAllLines("D:\\mem.txt");
            SimpleIdentityConverter c = new SimpleIdentityConverter();
            var strIds = new List<string>();
            foreach (var longId in longIds)
            {
                strIds.Add($"{c.Convert(long.Parse(longId))}");
            }

            File.WriteAllLines("D:\\id_conve.txt", strIds);

            var existedStrIs = File.ReadAllLines("D:\\existed.txt");

            var notExisted = strIds.Except(existedStrIs).ToList();

            File.WriteAllLines("D:\\notExisted.txt", notExisted);




        }
    }
}
