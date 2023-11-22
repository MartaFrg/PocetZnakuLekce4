using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocetZnakuLekce4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Tohle je můj pokusný text pro statistiku znaků.";
            List<ZnakVListu> listVsechZnaku = new List<ZnakVListu>();
            foreach (char pismeno in text)
            {
                if (listVsechZnaku.Any(hod=>hod.znak== pismeno))
                {
                    foreach (ZnakVListu znakVListu in listVsechZnaku) if (znakVListu.znak == pismeno) znakVListu.pocet++;
                }
                else
                {
                    listVsechZnaku.Add(new ZnakVListu() { znak = pismeno, pocet = 1 });
                }
            }
            vypisList(listVsechZnaku);
        }
        static void vypisList(List<ZnakVListu> listVsechZnaku)
        {
            foreach (ZnakVListu znakVListu in listVsechZnaku) Console.WriteLine(znakVListu.znak+" - "+ znakVListu.pocet);
        }
    }
}
