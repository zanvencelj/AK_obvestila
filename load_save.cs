using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_obvestila
{
    internal class load_save
    {
        List<Obvestila> obvestilas = new List<Obvestila>();
        public Obvestila ReadAllLines()
        {
            using (StreamReader sr = new StreamReader("data.csv"))
            {
                while (sr.Peek() >= 0)
                {
                    string line = sr.ReadLine();
                    string[] lines = line.Split(';');
                    obvestilas.Add(new Obvestila(lines[0], DateTime.Parse(lines[1]), int.Parse(lines[2])));
                }
            }
            return this.obvestilas.FirstOrDefault();
        }



        // string[][] readData;
        // readData = File.ReadAllLines("data.csv").Select(line => line.Split(';')).ToArray();


        // dataTable = File.ReadAllLines("data.csv").Select(line => line.Split(',')).ToArray();



        //obvestilas = File.ReadAllLines("data.csv")
        //    .Skip(0)
        //    .Select(line => line.Split(';'))
        //    .ToList();
    }
}
