using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagramss
{
    public class hierarchical
    {
        public static List<List<string[]>> Ogramhierarchical(string[][] rows, string name, string lastname, int deep)
        {
            List<List<string[]>> liststrings = new List<List<string[]>>();
            List<string[]> pusta = new List<string[]>(rows.ToList().Where(x => x[2] == "" && x[3] == "").ToList());
            liststrings.Add(rows.ToList().Where(x => x[2] == name && x[3] == lastname).ToList());
            for (int i = 0; i <= deep; i++)
            {
                for (int j = 0; j < liststrings[i].Count; j++)
                {
                    if (rows.ToList().Where(x => x[1] == liststrings[i][j][0]).ToList().Count == 0) { }
                    else
                    {
                        liststrings.Add(rows.ToList().Where(x => x[1] == liststrings[i][j][0]).ToList());
                    }

                }


            }
            return liststrings;
        }
    }
}
