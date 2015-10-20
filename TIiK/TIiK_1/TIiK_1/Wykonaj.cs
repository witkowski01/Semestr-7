using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIiK_1
{
    class Wykonaj
    {
        public Wykonaj () { }
        public string wynik(string wej)
        {
            var text = wej;
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"temp");
            var dictionary = text.GroupBy(i => i).Distinct().ToDictionary(i => i.Key, i => i.Count());
            var dictionary2 = dictionary.OrderBy(i => i.Key);
            foreach (var i in dictionary2)
            {
                double PofE = ((double)i.Value / (double)text.Length);
                double procent = PofE * 100;
                double oneByProbability = (1 / PofE);
                //binary unit log2 1/p(E)
                var BinaryUnit = Math.Log(oneByProbability, 2);
                string line = ("Key:" + i.Key + "--Count:" + i.Value + "--I(E):" + BinaryUnit + "--" + Math.Round(procent, 6) + "%\n");

                file.WriteLine(line);

            }
            file.Close();
            var wynik = System.IO.File.ReadAllText(@"temp");
            return wynik;
        }

        public Dictionary<char, int> wynikDictionary(string wej)
        {
            var text = wej;
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"temp");
            var dictionary = text.GroupBy(i => i).Distinct().ToDictionary(i => i.Key, i => i.Count());
            var dictionary2 = dictionary.OrderBy(i => i.Key);
            foreach (var i in dictionary2)
            {
                double PofE = ((double)i.Value / (double)text.Length);
                double procent = PofE * 100;
                double oneByProbability = (1 / PofE);
                //binary unit log2 1/p(E)
                var BinaryUnit = Math.Log(oneByProbability, 2);
                string line = ("Key:" + i.Key + "--Count:" + i.Value + "--I(E):" + BinaryUnit + "--" + Math.Round(procent, 6) + "%\n");

                file.WriteLine(line);

            }
            file.Close();
            var wynik = System.IO.File.ReadAllText(@"temp");
            return  dictionary;
        }
    }
}
