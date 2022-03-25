using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK_obvestila
{
    internal class Storage
    {
        public void ExportAll(List<Obvestila> obvestilas)
        {
            StreamWriter sw = new StreamWriter("data.csv");
            for (int i = 0; i < obvestilas.Count; i++)
            {
                sw.Write(obvestilas[i].Obvestilo);
                sw.Write(";");
                sw.Write(obvestilas[i].Datum);
                sw.Write(";");
                sw.Write(obvestilas[i].Delay);
                sw.Write(";");

                sw.Write(Environment.NewLine);
            }
            sw.Close();
        }

        public List<Obvestila> ImportAll()
        {
            List<Obvestila> obvestilas = new List<Obvestila>();
            using (StreamReader sr = new StreamReader("data.csv"))
            {
                while (sr.Peek() >= 0)
                {
                    string line = sr.ReadLine();
                    string[] lines = line.Split(';');
                    obvestilas.Add(new Obvestila(lines[0], DateTime.Parse(lines[1]), int.Parse(lines[2])));
                }
            }

            return obvestilas;
        }

        public void RefreshList(ListBox o, List<Obvestila> obvestilas)
        {
            o.ClearSelected();
            o.DataSource = null;
            o.DataSource = obvestilas;
            o.DisplayMember = "Obvestilo";
        }
    }
}
