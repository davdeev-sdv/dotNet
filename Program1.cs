using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("D:\\Expr.csv");
            var sqls = new List<string>();
            foreach (var line in lines)
            {
                string[] idExpr = line.Split(',');
                sqls.Add($"INSERT INTO [MCS.Commissions].[Expressions]([AgencyId],[AgencyFamily],[Expression]) VALUES('{idExpr[0]}', 'cp', '{idExpr[1]}')");
            }

            File.WriteAllLines("D:\\Expr.sql", sqls);
        }
    }
}
