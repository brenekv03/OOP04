using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    class Auto
    {
        private string znacka;
        private double spotrebaNa100;
        private int ujetoCelkem;
        private DateTime rozjezdTime;
        private DateTime dobaJizdyCelkem;
        private bool jede;
        public Auto(string znacka, int ujetoCelkem, DateTime dobaJizdyCelkem, bool jede)
        {
            this.znacka = znacka;
            this.ujetoCelkem = ujetoCelkem;
            dobaJizdyCelkem = DateTime.Parse("0-0-0000");
            this.dobaJizdyCelkem = dobaJizdyCelkem;
            jede = false;
            this.jede = jede;
        }
        public bool GetJede()
        {
            return jede;
        }
        public void Rozjed()
        {
            jede = true;
            rozjezdTime = DateTime.Now;
        }
        public void Zastav(int ujeteKilometryZaJednuJizdu)
        {
            jede = false;
            ujetoCelkem += ujeteKilometryZaJednuJizdu;
            TimeSpan ujetoZaJednuJizdu = DateTime.Now - rozjezdTime;
            dobaJizdyCelkem = dobaJizdyCelkem.AddSeconds(double.Parse(ujetoZaJednuJizdu.ToString())); //aktualizace ujete doby
        }
        public double CelkovaSpotreba(double spotrebaNa100)
        {
            double celkovaSpotreba = ujetoCelkem / spotrebaNa100;
            return celkovaSpotreba;
        }
        public override string ToString()
        {
            string s = "";
            if(GetJede())
            {
                s = "\nAuto jede\nZnačka auta je: " + znacka + "\nSpotřeba auta na 100km je: " + spotrebaNa100 + "\nCelkem ujeto: " + ujetoCelkem + "\nCelková doba jízdy auta: " + dobaJizdyCelkem + "\nCelková spotřeba auta je: " + CelkovaSpotreba(spotrebaNa100);
            }
            else
            {
                s = "\nAuto nejede\nZnačka auta je: " + znacka + "\nSpotřeba auta na 100km je: " + spotrebaNa100 + "\nCelkem ujeto: " + ujetoCelkem + "\nCelková doba jízdy auta: " + dobaJizdyCelkem + "\nCelková spotřeba auta je: " + CelkovaSpotreba(spotrebaNa100);
            }
            return base.ToString() + s;
        }
    }
}
