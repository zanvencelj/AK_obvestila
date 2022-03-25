using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_obvestila
{
    internal class Obvestila
    {
        private string _obvestilo;
        private DateTime _datum;
        private int _delay;

        public Obvestila(string obvestilo, DateTime datum, int delay)
        { 
            _obvestilo = obvestilo;
            _datum = datum;
            _delay = delay;
        }

        public string Obvestilo
        {
            get { return _obvestilo;}
            set { _obvestilo = value; }
        }
        public DateTime Datum 
        { 
            get { return _datum;} 
            set { _datum = value; }
        }
        public int Delay
        {
            get { return _delay;}
            set { _delay = value; }
        }
    }
}
