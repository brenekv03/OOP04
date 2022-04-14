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
        private TimeSpan dobaJizdyCelkem;
        private bool jede;
        public string GetZnacka()
        {
            return znacka;
        }
        public double GetSpotrebaNa100()
        {
            return spotrebaNa100;
        }
        public int GetUjetoCelkem()
        {
            return ujetoCelkem;
        }
        public DateTime GetRozjezdTime()
        {
            return rozjezdTime;
        }
        public TimeSpan GetDobaJizdyCelkem()
        {
            return dobaJizdyCelkem;
        }
        public bool GetJede()
        {
            return jede;
        }
}
