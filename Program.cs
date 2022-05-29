using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagramss
{
    public class Program
    {
        


        static void Main(string[] args)
        {
            

            string[][] rows;
            string name, lastname;int deep;
            int idex=0;
            var file =File.ReadLines(Directory.GetCurrentDirectory()+"/companies_data.csv");
            rows = new string[file.Count()][];
            foreach (string line in file)
            {
                rows[idex] =new string[10];
                rows[idex] = line.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            idex++;
            }
            rows =rows.ToList().OrderBy(x =>Int32.Parse( x[0])).ToArray();
            Console.WriteLine("Podaj imie i nazwisko pracownika");
            string[] token;
            do
            {
                token = Console.ReadLine().Split();
                if (token.Length==2)
                {
                    break;
                }
            } while (true);
            

            name = token[0];
            lastname = token[1];
            Console.WriteLine("Podaj głębokość patrzenia");
            deep =Int32.Parse( Console.ReadLine());
            var listoflist = hierarchical.Ogramhierarchical(rows, name, lastname, deep);
            string tab = "";
            int a = 0;
            foreach (var list in listoflist)
            {
                foreach (var row in list)
                {
                    Console.Write("\n" + tab + "->" + (row[2] + " " + row[3], row[4], row[6]).ToTuple()
                        .ToString().Replace('(', ' ').Replace(')', ' ').ToString());
                    if (a <= 0||list.Count()==1)
                    {
                        a = list.Count()+1;
                        tab += "    ";

                    }
                    a--;
                }
            }
            Console.ReadLine();
        }
    }
}
